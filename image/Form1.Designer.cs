namespace imageobjdecect
{
    partial class frmmain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.picimage = new System.Windows.Forms.PictureBox();
            this.btnbrowse = new System.Windows.Forms.Button();
            this.btndetect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picimage)).BeginInit();
            this.SuspendLayout();
            // 
            // picimage
            // 
            this.picimage.Location = new System.Drawing.Point(43, 23);
            this.picimage.Name = "picimage";
            this.picimage.Size = new System.Drawing.Size(231, 265);
            this.picimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picimage.TabIndex = 0;
            this.picimage.TabStop = false;
            // 
            // btnbrowse
            // 
            this.btnbrowse.Location = new System.Drawing.Point(43, 320);
            this.btnbrowse.Name = "btnbrowse";
            this.btnbrowse.Size = new System.Drawing.Size(94, 29);
            this.btnbrowse.TabIndex = 1;
            this.btnbrowse.Text = "browse";
            this.btnbrowse.UseVisualStyleBackColor = true;
            this.btnbrowse.Click += new System.EventHandler(this.btnbrowse_Click);
            // 
            // btndetect
            // 
            this.btndetect.Location = new System.Drawing.Point(180, 320);
            this.btndetect.Name = "btndetect";
            this.btndetect.Size = new System.Drawing.Size(94, 29);
            this.btndetect.TabIndex = 2;
            this.btndetect.Text = "detect";
            this.btndetect.UseVisualStyleBackColor = true;
            this.btndetect.Click += new System.EventHandler(this.btndetect_Click);
            // 
            // frmmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 361);
            this.Controls.Add(this.btndetect);
            this.Controls.Add(this.btnbrowse);
            this.Controls.Add(this.picimage);
            this.Name = "frmmain";
            this.Text = "object detection";
            ((System.ComponentModel.ISupportInitialize)(this.picimage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox picimage;
        private Button btnbrowse;
        private Button btndetect;
    }
}