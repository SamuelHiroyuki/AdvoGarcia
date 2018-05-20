namespace AdvoGarcia
{
    partial class Teste
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
            this.adv1 = new AdvoGarcia.UC.Adv();
            this.SuspendLayout();
            // 
            // adv1
            // 
            this.adv1.Location = new System.Drawing.Point(12, 12);
            this.adv1.Name = "adv1";
            this.adv1.Size = new System.Drawing.Size(950, 585);
            this.adv1.TabIndex = 0;
            // 
            // Teste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 749);
            this.Controls.Add(this.adv1);
            this.Name = "Teste";
            this.Text = "Teste";
            this.ResumeLayout(false);

        }

        #endregion

        private UC.Adv adv1;
    }
}