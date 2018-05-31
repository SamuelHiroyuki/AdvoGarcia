namespace AdvoGarcia.UC
{
    partial class ucCustomSaveBtn
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucCustomSaveBtn));
            this.pic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // pic
            // 
            this.pic.Image = ((System.Drawing.Image)(resources.GetObject("pic.Image")));
            this.pic.Location = new System.Drawing.Point(13, 13);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(26, 26);
            this.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic.TabIndex = 0;
            this.pic.TabStop = false;
            this.pic.MouseLeave += new System.EventHandler(this.pic_MouseLeave);
            this.pic.MouseHover += new System.EventHandler(this.pic_MouseHover);
            // 
            // ucCustomSaveBtn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.pic);
            this.Name = "ucCustomSaveBtn";
            this.Size = new System.Drawing.Size(52, 52);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pic;
    }
}
