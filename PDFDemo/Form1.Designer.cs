namespace PDFDemo
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnHello = new System.Windows.Forms.Button();
            this.btnJPGtoPDF = new System.Windows.Forms.Button();
            this.btnZoom = new System.Windows.Forms.Button();
            this.btnFitPageToImage = new System.Windows.Forms.Button();
            this.btnMultipleImagesPerPage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHello
            // 
            this.btnHello.Location = new System.Drawing.Point(12, 36);
            this.btnHello.Name = "btnHello";
            this.btnHello.Size = new System.Drawing.Size(260, 23);
            this.btnHello.TabIndex = 0;
            this.btnHello.Text = "Create a Hello World PDF";
            this.btnHello.UseVisualStyleBackColor = true;
            this.btnHello.Click += new System.EventHandler(this.btnHello_Click);
            // 
            // btnJPGtoPDF
            // 
            this.btnJPGtoPDF.Location = new System.Drawing.Point(12, 65);
            this.btnJPGtoPDF.Name = "btnJPGtoPDF";
            this.btnJPGtoPDF.Size = new System.Drawing.Size(260, 23);
            this.btnJPGtoPDF.TabIndex = 1;
            this.btnJPGtoPDF.Text = "One Image Per Page";
            this.btnJPGtoPDF.UseVisualStyleBackColor = true;
            this.btnJPGtoPDF.Click += new System.EventHandler(this.btnJPGtoPDF_Click);
            // 
            // btnZoom
            // 
            this.btnZoom.Location = new System.Drawing.Point(12, 94);
            this.btnZoom.Name = "btnZoom";
            this.btnZoom.Size = new System.Drawing.Size(260, 23);
            this.btnZoom.TabIndex = 2;
            this.btnZoom.Text = "Zoom in on Image";
            this.btnZoom.UseVisualStyleBackColor = true;
            this.btnZoom.Click += new System.EventHandler(this.btnMultiplePDF_Click);
            // 
            // btnFitPageToImage
            // 
            this.btnFitPageToImage.Location = new System.Drawing.Point(12, 123);
            this.btnFitPageToImage.Name = "btnFitPageToImage";
            this.btnFitPageToImage.Size = new System.Drawing.Size(260, 23);
            this.btnFitPageToImage.TabIndex = 3;
            this.btnFitPageToImage.Text = "Fit Page To Image";
            this.btnFitPageToImage.UseVisualStyleBackColor = true;
            this.btnFitPageToImage.Click += new System.EventHandler(this.btnFitPageToImage_Click);
            // 
            // btnMultipleImagesPerPage
            // 
            this.btnMultipleImagesPerPage.Location = new System.Drawing.Point(13, 153);
            this.btnMultipleImagesPerPage.Name = "btnMultipleImagesPerPage";
            this.btnMultipleImagesPerPage.Size = new System.Drawing.Size(259, 23);
            this.btnMultipleImagesPerPage.TabIndex = 4;
            this.btnMultipleImagesPerPage.Text = "More than one Image per Page";
            this.btnMultipleImagesPerPage.UseVisualStyleBackColor = true;
            this.btnMultipleImagesPerPage.Click += new System.EventHandler(this.btnMultipleImagesPerPage_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnMultipleImagesPerPage);
            this.Controls.Add(this.btnFitPageToImage);
            this.Controls.Add(this.btnZoom);
            this.Controls.Add(this.btnJPGtoPDF);
            this.Controls.Add(this.btnHello);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHello;
        private System.Windows.Forms.Button btnJPGtoPDF;
        private System.Windows.Forms.Button btnZoom;
        private System.Windows.Forms.Button btnFitPageToImage;
        private System.Windows.Forms.Button btnMultipleImagesPerPage;
    }
}

