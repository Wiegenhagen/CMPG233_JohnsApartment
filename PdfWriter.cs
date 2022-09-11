using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_26_Johns_RealEstate_Management_System
{
    class PdfWriter
    {
        public static void WritePdf(string fileName, string query, string reportName, SqlConnection conn, SqlCommand comm, SqlDataReader reader)
        {
            Document doc = new Document(PageSize.A3.Rotate());
            var outputFile = new FileStream(fileName + ".pdf", FileMode.Create);
            var writer = iTextSharp.text.pdf.PdfWriter.GetInstance(doc, outputFile);

            doc.Open();

            Paragraph heading = new Paragraph(reportName);
            heading.Alignment = Element.ALIGN_CENTER;
            heading.IndentationRight = 100;
            heading.IndentationLeft = 100;
            doc.Add(heading);

            conn.Open();//connection open

            comm = new SqlCommand(query, conn);//Command database to show
            reader = comm.ExecuteReader();

            // Creating a table       
            float[] pointColumnWidths = new float[reader.FieldCount];

            for (int i = 0; i < reader.FieldCount; i++)
            {
                pointColumnWidths[i] = 230f;
            }

            PdfPTable table = new PdfPTable(pointColumnWidths);

            bool columnNames = true;
            bool colColor = true;

            while (reader.Read())
            {
                // Add headers that are gray or light gray in order, and replace the _ with a space, and only add headers once
                for (int i = 0; i < reader.FieldCount && columnNames; i++)
                {
                    PdfPCell cell = new PdfPCell();
                    cell.AddElement((new Chunk(reader.GetName(i).ToString().Replace('_', ' '))));
                    cell.Border = 0;
                    cell.BackgroundColor = colColor ? BaseColor.GRAY : BaseColor.LIGHT_GRAY;
                    colColor = !colColor;
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    cell.VerticalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                }
                columnNames = false;

                for (int i = 0; i < reader.FieldCount; i++)
                {
                    PdfPCell cell = new PdfPCell();
                    cell.AddElement((new Chunk(reader.GetValue(i).ToString())));
                    cell.Border = 0;
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    cell.VerticalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                }
            }
            conn.Close();//connection close

            table.SpacingBefore = 15;
            table.SpacingAfter = 15;

            doc.Add(table);

            Paragraph footer = (new Paragraph("Report was pulled on: " + DateTime.Now));
            footer.Alignment = Element.ALIGN_CENTER;
            footer.IndentationRight = 100;
            footer.IndentationLeft = 100;
            doc.Add(footer);

            doc.Close();
        }
    }
}
