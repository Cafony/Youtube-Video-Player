namespace Youtube_Video_Player
{
    partial class Main
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.textBoxUrl = new System.Windows.Forms.TextBox();
            this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonPasteLink = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(216, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Simple Youtube Video Player";
            // 
            // buttonPlay
            // 
            this.buttonPlay.Location = new System.Drawing.Point(85, 75);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(75, 23);
            this.buttonPlay.TabIndex = 7;
            this.buttonPlay.Text = "Play";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // textBoxUrl
            // 
            this.textBoxUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUrl.Location = new System.Drawing.Point(85, 104);
            this.textBoxUrl.Name = "textBoxUrl";
            this.textBoxUrl.Size = new System.Drawing.Size(615, 26);
            this.textBoxUrl.TabIndex = 6;
            // 
            // webView21
            // 
            this.webView21.AllowExternalDrop = true;
            this.webView21.CreationProperties = null;
            this.webView21.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView21.Location = new System.Drawing.Point(85, 159);
            this.webView21.Name = "webView21";
            this.webView21.Size = new System.Drawing.Size(615, 303);
            this.webView21.TabIndex = 10;
            this.webView21.ZoomFactor = 1D;
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(166, 75);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStop.TabIndex = 11;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonPasteLink
            // 
            this.buttonPasteLink.Location = new System.Drawing.Point(625, 75);
            this.buttonPasteLink.Name = "buttonPasteLink";
            this.buttonPasteLink.Size = new System.Drawing.Size(75, 23);
            this.buttonPasteLink.TabIndex = 12;
            this.buttonPasteLink.Text = "Paste Link";
            this.buttonPasteLink.UseVisualStyleBackColor = true;
            this.buttonPasteLink.Click += new System.EventHandler(this.buttonPasteLink_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 474);
            this.Controls.Add(this.buttonPasteLink);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.webView21);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.textBoxUrl);
            this.Name = "Main";
            this.Text = "Youtube Video Player";
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.TextBox textBoxUrl;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonPasteLink;
    }
}

