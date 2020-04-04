using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDFDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHello_Click(object sender, EventArgs e)
        {
            PdfDocument document = new PdfDocument();
            document.Info.Title = "Created with PDFsharp";
            PdfPage page = document.AddPage();
            //page.Size = PdfSharp.PageSize.A5;
            XGraphics gfx = XGraphics.FromPdfPage(page);
            XFont font = new XFont("Verdana", 20, XFontStyle.BoldItalic);
            gfx.DrawString("Hello, World!", font, XBrushes.Black,
                new XRect(0, 0, page.Width, page.Height),
                XStringFormats.Center);
            const string filename = "c:\\PDFDemoTemp\\ResultHelloWorld.pdf";
            document.Save(filename);
        }

        private void btnJPGtoPDF_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();

            dlg.InitialDirectory = "C:\\PDFDemoTemp";
            dlg.Filter = "JPEG files (*.jpg)|*.jpg|All files (*.*)|*.*";
            dlg.Multiselect = true;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                PdfDocument document = new PdfDocument();
                document.Info.Title = "Created using PDFsharp";

                foreach (string fileSpec in dlg.FileNames)
                {
                    PdfPage page = document.AddPage();
                    XGraphics gfx = XGraphics.FromPdfPage(page);
                    DrawImage(gfx, fileSpec, 0, 0, (int)page.Width, (int)page.Height);
                }
                if (document.PageCount > 0) document.Save(@"C:\PDFDemoTemp\ResultOneImagePerPage.pdf");
            }
        }

        void DrawImage(XGraphics gfx, string jpegSamplePath, int x, int y, int width, int height)
        {
            XImage image = XImage.FromFile(jpegSamplePath);
            gfx.DrawImage(image, x, y, width, height);
        }

        private void btnMultiplePDF_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();

            dlg.InitialDirectory = "C:\\PDFDemoTemp";
            dlg.Filter = "JPEG files (*.jpg)|*.jpg|All files (*.*)|*.*";
            dlg.Multiselect = true;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                PdfDocument document = new PdfDocument();
                document.Info.Title = "Created using PDFsharp";

                PdfPage page = document.AddPage();
                int StartX = 0 - (int)page.Width/2;
                int StartY = 0 - (int)page.Height / 2;
                XGraphics gfx = XGraphics.FromPdfPage(page);
                foreach (string fileSpec in dlg.FileNames)
                {
                    DrawImage(gfx, fileSpec, StartX, StartY, (int)page.Width*2, (int)page.Height*2);
                    StartX += (int)page.Width / 2;
                    StartY += (int)page.Height / 2;
                }
                if (document.PageCount > 0) document.Save(@"C:\PDFDemoTemp\ResultZoomInOnImage.pdf");
            }
        }

        private void btnFitPageToImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();

            dlg.InitialDirectory = "C:\\PDFDemoTemp";
            dlg.Filter = "JPEG files (*.jpg)|*.jpg|All files (*.*)|*.*";
            dlg.Multiselect = true;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                PdfDocument document = new PdfDocument();
                document.Info.Title = "Created using PDFsharp";

                PdfPage page = document.AddPage();
                XGraphics gfx = XGraphics.FromPdfPage(page);
            
                foreach (string fileSpec in dlg.FileNames)
                {
                    System.Drawing.Image img = System.Drawing.Image.FromFile(fileSpec);
                    page.Width = img.Width;
                    page.Height = img.Height;
                    DrawImage(gfx, fileSpec, 0, 0, (int)page.Width, (int)page.Height);
                }
                if (document.PageCount > 0) document.Save(@"C:\PDFDemoTemp\ResultFitPageToImage.pdf");
            }
        }

        private void btnMultipleImagesPerPage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();

            dlg.InitialDirectory = "C:\\PDFDemoTemp";
            dlg.Filter = "JPEG files (*.jpg)|*.jpg|All files (*.*)|*.*";
            dlg.Multiselect = true;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                PdfDocument document = new PdfDocument();
                document.Info.Title = "Created using PDFsharp";

                PdfPage page = document.AddPage();
                int StartX = 0;
                int StartY = 0;
                XGraphics gfx = XGraphics.FromPdfPage(page);
                foreach (string fileSpec in dlg.FileNames)
                {
                    DrawImage(gfx, fileSpec, StartX, StartY, (int)page.Width / 2, (int)page.Height / 2);
                    StartX += (int)page.Width / 2;
                    StartY += (int)page.Height / 2;
                }
                if (document.PageCount > 0) document.Save(@"C:\PDFDemoTemp\ResultMultipleImagesPerPage.pdf");
            }
        }
    }
}
