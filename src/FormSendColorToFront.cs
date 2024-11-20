using PdfSharp.Drawing;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using PdfSharp.Drawing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using PdfSharp.Charting;

namespace pdf_tools {
    public partial class FormSendColorToFront : Form {
        public FormSendColorToFront() {
            InitializeComponent();
            textBoxPath.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        }

        private void button1_Click(object sender, EventArgs e) {
            var dialog = new ColorDialog();
            dialog.AllowFullOpen = true;
            dialog.ShowHelp = false;
            dialog.Color = textBoxColor.BackColor;

            // Update the text box color if the user clicks OK 
            if (dialog.ShowDialog() == DialogResult.OK)
                textBoxColor.BackColor = dialog.Color;
        }

        private void buttonFolderPicker_Click(object sender, EventArgs e) {
            var dialog = new FolderBrowserDialog();
            // Update the text box color if the user clicks OK 
            if (dialog.ShowDialog() == DialogResult.OK) {
                textBoxPath.Text = dialog.SelectedPath;
                textBoxPath.Select(textBoxPath.Text.Length, 0);
            }
        }

        private void buttonStart_Click(object sender, EventArgs e) {
            List<string> pdfPaths = new List<string>();

            if (Utils.PathIsdirectory(textBoxPath.Text)) {
                if (Directory.Exists(textBoxPath.Text)) {
                    foreach (string file in Directory.GetFiles(textBoxPath.Text, "*.pdf"))
                        pdfPaths.Add(file);
                }
            }
            else {
                pdfPaths.Add(textBoxPath.Text);
            }

            foreach (string path in pdfPaths) {
                string outputPath = path;
                if (checkBoxCopyFile.Checked)
                    outputPath = Path.Combine(path, "PDFtools");
                //TODO inset subfolder in before file
                if (checkBoxCopyFile.Checked && !Directory.Exists(path))
                    Directory.CreateDirectory(path);
                MoveColorObjectsToFront(path, outputPath, textBoxColor.BackColor);
            }
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
