namespace AdvoGarcia.UC
{
    partial class ucConCaso
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtNome = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.chbAnd = new System.Windows.Forms.CheckBox();
            this.chbEnc = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboTipoCon = new MetroFramework.Controls.MetroComboBox();
            this.btnPegar = new System.Windows.Forms.Button();
            this.cboAdv = new MetroFramework.Controls.MetroComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(177)))), ((int)(((byte)(137)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(700, 374);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(171, 35);
            this.btnSearch.TabIndex = 99;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(701, 491);
            this.dataGridView1.TabIndex = 95;
            // 
            // txtNome
            // 
            // 
            // 
            // 
            this.txtNome.CustomButton.Image = null;
            this.txtNome.CustomButton.Location = new System.Drawing.Point(150, 1);
            this.txtNome.CustomButton.Name = "";
            this.txtNome.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNome.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNome.CustomButton.TabIndex = 1;
            this.txtNome.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNome.CustomButton.UseSelectable = true;
            this.txtNome.CustomButton.Visible = false;
            this.txtNome.Lines = new string[0];
            this.txtNome.Location = new System.Drawing.Point(700, 120);
            this.txtNome.MaxLength = 50;
            this.txtNome.Name = "txtNome";
            this.txtNome.PasswordChar = '\0';
            this.txtNome.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNome.SelectedText = "";
            this.txtNome.SelectionLength = 0;
            this.txtNome.SelectionStart = 0;
            this.txtNome.ShortcutsEnabled = true;
            this.txtNome.ShowClearButton = true;
            this.txtNome.Size = new System.Drawing.Size(172, 23);
            this.txtNome.TabIndex = 98;
            this.txtNome.UseSelectable = true;
            this.txtNome.WaterMark = "Digite o nome";
            this.txtNome.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNome.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(706, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 15);
            this.label1.TabIndex = 97;
            this.label1.Text = "Buscar por Nome do Cliente:";
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.Color.White;
            this.btnExcluir.Location = new System.Drawing.Point(700, 456);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(171, 35);
            this.btnExcluir.TabIndex = 96;
            this.btnExcluir.Text = "Encerrar Caso";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(168)))), ((int)(((byte)(1)))));
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(700, 415);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(171, 35);
            this.btnEdit.TabIndex = 100;
            this.btnEdit.Text = "Visualizar";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // chbAnd
            // 
            this.chbAnd.AutoSize = true;
            this.chbAnd.Location = new System.Drawing.Point(711, 212);
            this.chbAnd.Name = "chbAnd";
            this.chbAnd.Size = new System.Drawing.Size(97, 17);
            this.chbAnd.TabIndex = 101;
            this.chbAnd.Text = "Em andamento";
            this.chbAnd.UseVisualStyleBackColor = true;
            // 
            // chbEnc
            // 
            this.chbEnc.AutoSize = true;
            this.chbEnc.Location = new System.Drawing.Point(711, 235);
            this.chbEnc.Name = "chbEnc";
            this.chbEnc.Size = new System.Drawing.Size(75, 17);
            this.chbEnc.TabIndex = 102;
            this.chbEnc.Text = "Encerrado";
            this.chbEnc.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Emoji", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(707, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 19);
            this.label7.TabIndex = 104;
            this.label7.Text = "Consultar :";
            // 
            // cboTipoCon
            // 
            this.cboTipoCon.FormattingEnabled = true;
            this.cboTipoCon.ItemHeight = 23;
            this.cboTipoCon.Items.AddRange(new object[] {
            "Meus casos",
            "Pegar caso"});
            this.cboTipoCon.Location = new System.Drawing.Point(700, 177);
            this.cboTipoCon.Name = "cboTipoCon";
            this.cboTipoCon.PromptText = "Deseja consultar...";
            this.cboTipoCon.Size = new System.Drawing.Size(171, 29);
            this.cboTipoCon.TabIndex = 103;
            this.cboTipoCon.UseSelectable = true;
            // 
            // btnPegar
            // 
            this.btnPegar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnPegar.FlatAppearance.BorderSize = 0;
            this.btnPegar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPegar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPegar.ForeColor = System.Drawing.Color.White;
            this.btnPegar.Location = new System.Drawing.Point(700, 333);
            this.btnPegar.Name = "btnPegar";
            this.btnPegar.Size = new System.Drawing.Size(171, 35);
            this.btnPegar.TabIndex = 105;
            this.btnPegar.Text = "Pegar";
            this.btnPegar.UseVisualStyleBackColor = false;
            this.btnPegar.Click += new System.EventHandler(this.btnPegar_Click);
            // 
            // cboAdv
            // 
            this.cboAdv.FormattingEnabled = true;
            this.cboAdv.ItemHeight = 23;
            this.cboAdv.Items.AddRange(new object[] {
            "Possui advogado",
            "Não possui advogado"});
            this.cboAdv.Location = new System.Drawing.Point(700, 258);
            this.cboAdv.Name = "cboAdv";
            this.cboAdv.PromptText = "Consultar por...";
            this.cboAdv.Size = new System.Drawing.Size(171, 29);
            this.cboAdv.TabIndex = 106;
            this.cboAdv.UseSelectable = true;
            // 
            // ucConCaso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cboAdv);
            this.Controls.Add(this.btnPegar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cboTipoCon);
            this.Controls.Add(this.chbEnc);
            this.Controls.Add(this.chbAnd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExcluir);
            this.Name = "ucConCaso";
            this.Size = new System.Drawing.Size(871, 491);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroTextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.CheckBox chbAnd;
        private System.Windows.Forms.CheckBox chbEnc;
        private System.Windows.Forms.Label label7;
        private MetroFramework.Controls.MetroComboBox cboTipoCon;
        private System.Windows.Forms.Button btnPegar;
        private MetroFramework.Controls.MetroComboBox cboAdv;
    }
}
