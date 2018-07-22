namespace AdvoGarcia.UC
{
    partial class ucMsg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucMsg));
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnSaveAnot = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMsg = new System.Windows.Forms.RichTextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSaveAnot)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkCyan;
            this.panel4.Controls.Add(this.btnSaveAnot);
            this.panel4.Location = new System.Drawing.Point(423, 13);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(120, 70);
            this.panel4.TabIndex = 93;
            // 
            // btnSaveAnot
            // 
            this.btnSaveAnot.BackColor = System.Drawing.Color.DarkCyan;
            this.btnSaveAnot.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveAnot.Image")));
            this.btnSaveAnot.ImageActive = null;
            this.btnSaveAnot.Location = new System.Drawing.Point(25, 0);
            this.btnSaveAnot.Name = "btnSaveAnot";
            this.btnSaveAnot.Size = new System.Drawing.Size(71, 67);
            this.btnSaveAnot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSaveAnot.TabIndex = 76;
            this.btnSaveAnot.TabStop = false;
            this.btnSaveAnot.Zoom = 10;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel6.Location = new System.Drawing.Point(18, 386);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(564, 2);
            this.panel6.TabIndex = 91;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.panel2.Controls.Add(this.metroComboBox1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtMsg);
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Location = new System.Drawing.Point(18, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(564, 358);
            this.panel2.TabIndex = 92;
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Location = new System.Drawing.Point(245, 20);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(142, 29);
            this.metroComboBox1.TabIndex = 91;
            this.metroComboBox1.UseSelectable = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 21);
            this.label4.TabIndex = 82;
            this.label4.Text = "Enviar mensagem para:";
            // 
            // txtMsg
            // 
            this.txtMsg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMsg.Enabled = false;
            this.txtMsg.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMsg.Location = new System.Drawing.Point(29, 65);
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.Size = new System.Drawing.Size(497, 267);
            this.txtMsg.TabIndex = 81;
            this.txtMsg.Text = "";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.Control;
            this.panel8.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(2, 358);
            this.panel8.TabIndex = 77;
            // 
            // ucMsg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel2);
            this.Name = "ucMsg";
            this.Size = new System.Drawing.Size(600, 400);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnSaveAnot)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private Bunifu.Framework.UI.BunifuImageButton btnSaveAnot;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox txtMsg;
        private System.Windows.Forms.Panel panel8;
    }
}
