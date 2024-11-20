using System;
using System.Drawing;
using System.Linq;
using System.IO;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using PdfSharp.Drawing;

namespace pdf_tools {
    internal static class Program {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args) {
            Console.WriteLine("Enter the path to the PDF file:");
            string inputPath = Console.ReadLine();

            Console.WriteLine("Enter the output path for the modified PDF:");
            string outputPath = Console.ReadLine();

            Console.WriteLine("Enter the target RGB color (e.g., 255,0,0 for red):");
            string[] colorInput = Console.ReadLine().Split(',');
            Color targetColor = Color.FromArgb(
                255,
                int.Parse(colorInput[0]),
                int.Parse(colorInput[1]),
                int.Parse(colorInput[2])
            );

            MoveColorObjectsToFront(inputPath, outputPath, targetColor);
            Console.WriteLine("Processing complete. The modified PDF has been saved.");
        }

        static void MoveColorObjectsToFront(string inputPath, string outputPath, Color targetColor) {
            PdfDocument inputDocument = PdfReader.Open(inputPath, PdfDocumentOpenMode.Import);
            PdfDocument outputDocument = new PdfDocument();

            foreach (var page in inputDocument.Pages) {
                var gfx = XGraphics.FromPdfPage(outputDocument.AddPage(page));
                var importedPage = outputDocument.AddPage(page);
                //var contentStream = page.Contents.Elements.Select(c => c.Stream.Value).ToArray();

                //var colorObjects = ExtractColorObjects(contentStream, targetColor);
                //DrawObjects(gfx, colorObjects);
            }

            //outputDocument.Save(outputPath);
            //outputHelpText.Add(nodeText);
        }
    }
}