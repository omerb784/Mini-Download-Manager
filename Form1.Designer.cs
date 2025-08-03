namespace MiniDownloadManager
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
            this.label1 = new System.Windows.Forms.Label();
            this.TfileName = new System.Windows.Forms.Label();
            this.PBpicture = new System.Windows.Forms.PictureBox();
            this.PBspinner = new System.Windows.Forms.ProgressBar();
            this.Bdownload = new System.Windows.Forms.Button();
            this.Lloading = new System.Windows.Forms.Label();
            this.BnextFile = new System.Windows.Forms.Button();
            this.Lscore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PBpicture)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(246, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mini-Download Manager";
            // 
            // TfileName
            // 
            this.TfileName.AutoSize = true;
            this.TfileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TfileName.Location = new System.Drawing.Point(342, 81);
            this.TfileName.Name = "TfileName";
            this.TfileName.Size = new System.Drawing.Size(0, 24);
            this.TfileName.TabIndex = 1;
            // 
            // PBpicture
            // 
            this.PBpicture.Location = new System.Drawing.Point(284, 132);
            this.PBpicture.Name = "PBpicture";
            this.PBpicture.Size = new System.Drawing.Size(185, 168);
            this.PBpicture.TabIndex = 2;
            this.PBpicture.TabStop = false;
            // 
            // PBspinner
            // 
            this.PBspinner.Location = new System.Drawing.Point(284, 355);
            this.PBspinner.Name = "PBspinner";
            this.PBspinner.Size = new System.Drawing.Size(185, 23);
            this.PBspinner.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.PBspinner.TabIndex = 3;
            this.PBspinner.Visible = false;
            // 
            // Bdownload
            // 
            this.Bdownload.Location = new System.Drawing.Point(284, 395);
            this.Bdownload.Name = "Bdownload";
            this.Bdownload.Size = new System.Drawing.Size(75, 23);
            this.Bdownload.TabIndex = 4;
            this.Bdownload.Text = "Download";
            this.Bdownload.UseVisualStyleBackColor = true;
            this.Bdownload.Click += new System.EventHandler(this.Bdownload_Click);
            // 
            // Lloading
            // 
            this.Lloading.AutoSize = true;
            this.Lloading.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lloading.Location = new System.Drawing.Point(310, 318);
            this.Lloading.Name = "Lloading";
            this.Lloading.Size = new System.Drawing.Size(129, 24);
            this.Lloading.TabIndex = 5;
            this.Lloading.Text = "Loading App";
            // 
            // BnextFile
            // 
            this.BnextFile.Location = new System.Drawing.Point(394, 395);
            this.BnextFile.Name = "BnextFile";
            this.BnextFile.Size = new System.Drawing.Size(75, 23);
            this.BnextFile.TabIndex = 6;
            this.BnextFile.Text = "Next File";
            this.BnextFile.UseVisualStyleBackColor = true;
            this.BnextFile.Click += new System.EventHandler(this.BnextFile_Click);
            // 
            // Lscore
            // 
            this.Lscore.AutoSize = true;
            this.Lscore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lscore.Location = new System.Drawing.Point(491, 208);
            this.Lscore.Name = "Lscore";
            this.Lscore.Size = new System.Drawing.Size(0, 20);
            this.Lscore.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Lscore);
            this.Controls.Add(this.BnextFile);
            this.Controls.Add(this.Lloading);
            this.Controls.Add(this.Bdownload);
            this.Controls.Add(this.PBspinner);
            this.Controls.Add(this.PBpicture);
            this.Controls.Add(this.TfileName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PBpicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TfileName;
        private System.Windows.Forms.PictureBox PBpicture;
        private System.Windows.Forms.ProgressBar PBspinner;
        private System.Windows.Forms.Button Bdownload;
        private System.Windows.Forms.Label Lloading;
        private System.Windows.Forms.Button BnextFile;
        private System.Windows.Forms.Label Lscore;
    }
}

