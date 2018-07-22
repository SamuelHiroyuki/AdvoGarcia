namespace AdvoGarcia.Telas
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panel3 = new System.Windows.Forms.Panel();
            this.tabControl = new MetroFramework.Controls.MetroTabControl();
            this.tabPageHome = new MetroFramework.Controls.MetroTabPage();
            this.ucChat1 = new AdvoGarcia.UC.ucChat();
            this.ucMsg1 = new AdvoGarcia.UC.ucMsg();
            this.lblHome = new System.Windows.Forms.Label();
            this.lblLastLog = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTempo = new System.Windows.Forms.Label();
            this.btnCaso = new MetroFramework.Controls.MetroTile();
            this.btnCli = new MetroFramework.Controls.MetroTile();
            this.picAdv = new System.Windows.Forms.PictureBox();
            this.tabPageCadAdv = new MetroFramework.Controls.MetroTabPage();
            this.btnVoltar = new MetroFramework.Controls.MetroTile();
            this.btnMin = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.pnlTopo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.drg1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.drg2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.ellipseForm = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.drg3 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.elipseAnot = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnAlt = new MetroFramework.Controls.MetroTile();
            this.btnLogout = new MetroFramework.Controls.MetroTile();
            this.btnCadCli = new MetroFramework.Controls.MetroTile();
            this.btnQuery = new MetroFramework.Controls.MetroTile();
            this.btnHome = new MetroFramework.Controls.MetroTile();
            this.btnCadAdv = new MetroFramework.Controls.MetroTile();
            this.tmrTempLog = new System.Windows.Forms.Timer(this.components);
            this.tabControl.SuspendLayout();
            this.tabPageHome.SuspendLayout();
            this.panel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAdv)).BeginInit();
            this.tabPageCadAdv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.pnlTopo.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
            this.panel3.Location = new System.Drawing.Point(168, 30);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(808, 16);
            this.panel3.TabIndex = 28;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageHome);
            this.tabControl.Controls.Add(this.tabPageCadAdv);
            this.tabControl.Location = new System.Drawing.Point(159, 8);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(826, 533);
            this.tabControl.TabIndex = 36;
            this.tabControl.UseSelectable = true;
            // 
            // tabPageHome
            // 
            this.tabPageHome.Controls.Add(this.ucChat1);
            this.tabPageHome.Controls.Add(this.ucMsg1);
            this.tabPageHome.Controls.Add(this.lblHome);
            this.tabPageHome.Controls.Add(this.lblLastLog);
            this.tabPageHome.Controls.Add(this.label2);
            this.tabPageHome.Controls.Add(this.panel13);
            this.tabPageHome.HorizontalScrollbarBarColor = true;
            this.tabPageHome.HorizontalScrollbarHighlightOnWheel = false;
            this.tabPageHome.HorizontalScrollbarSize = 10;
            this.tabPageHome.Location = new System.Drawing.Point(4, 38);
            this.tabPageHome.Name = "tabPageHome";
            this.tabPageHome.Size = new System.Drawing.Size(818, 491);
            this.tabPageHome.TabIndex = 0;
            this.tabPageHome.Text = "tabPageHome";
            this.tabPageHome.VerticalScrollbarBarColor = true;
            this.tabPageHome.VerticalScrollbarHighlightOnWheel = false;
            this.tabPageHome.VerticalScrollbarSize = 10;
            // 
            // ucChat1
            // 
            this.ucChat1.BackColor = System.Drawing.Color.White;
            this.ucChat1.Location = new System.Drawing.Point(22, 86);
            this.ucChat1.Name = "ucChat1";
            this.ucChat1.Size = new System.Drawing.Size(600, 400);
            this.ucChat1.TabIndex = 98;
            // 
            // ucMsg1
            // 
            this.ucMsg1.BackColor = System.Drawing.Color.White;
            this.ucMsg1.Location = new System.Drawing.Point(22, 86);
            this.ucMsg1.Name = "ucMsg1";
            this.ucMsg1.Size = new System.Drawing.Size(600, 400);
            this.ucMsg1.TabIndex = 97;
            // 
            // lblHome
            // 
            this.lblHome.AutoSize = true;
            this.lblHome.BackColor = System.Drawing.Color.White;
            this.lblHome.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHome.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblHome.Location = new System.Drawing.Point(11, 16);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(396, 39);
            this.lblHome.TabIndex = 94;
            this.lblHome.Text = "Seja bem-vindo *Nome*";
            // 
            // lblLastLog
            // 
            this.lblLastLog.AutoSize = true;
            this.lblLastLog.BackColor = System.Drawing.Color.White;
            this.lblLastLog.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastLog.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblLastLog.Location = new System.Drawing.Point(203, 64);
            this.lblLastLog.Name = "lblLastLog";
            this.lblLastLog.Size = new System.Drawing.Size(0, 21);
            this.lblLastLog.TabIndex = 96;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(38, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 21);
            this.label2.TabIndex = 95;
            this.label2.Text = "Última vez logado :";
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
            this.panel13.Controls.Add(this.label5);
            this.panel13.Controls.Add(this.lblTempo);
            this.panel13.Controls.Add(this.btnCaso);
            this.panel13.Controls.Add(this.btnCli);
            this.panel13.Controls.Add(this.picAdv);
            this.panel13.Location = new System.Drawing.Point(645, 0);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(168, 486);
            this.panel13.TabIndex = 86;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(46, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tempo logado";
            // 
            // lblTempo
            // 
            this.lblTempo.AutoSize = true;
            this.lblTempo.BackColor = System.Drawing.Color.Transparent;
            this.lblTempo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempo.ForeColor = System.Drawing.Color.White;
            this.lblTempo.Location = new System.Drawing.Point(43, 28);
            this.lblTempo.Name = "lblTempo";
            this.lblTempo.Size = new System.Drawing.Size(86, 32);
            this.lblTempo.TabIndex = 0;
            this.lblTempo.Text = "12 : 12";
            // 
            // btnCaso
            // 
            this.btnCaso.ActiveControl = null;
            this.btnCaso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(177)))), ((int)(((byte)(137)))));
            this.btnCaso.Location = new System.Drawing.Point(0, 418);
            this.btnCaso.Name = "btnCaso";
            this.btnCaso.Size = new System.Drawing.Size(168, 68);
            this.btnCaso.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnCaso.TabIndex = 3;
            this.btnCaso.TabStop = false;
            this.btnCaso.Text = "Casos";
            this.btnCaso.UseCustomBackColor = true;
            this.btnCaso.UseSelectable = true;
            this.btnCaso.Click += new System.EventHandler(this.btnCaso_Click);
            // 
            // btnCli
            // 
            this.btnCli.ActiveControl = null;
            this.btnCli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(177)))), ((int)(((byte)(137)))));
            this.btnCli.Location = new System.Drawing.Point(0, 344);
            this.btnCli.Name = "btnCli";
            this.btnCli.Size = new System.Drawing.Size(168, 68);
            this.btnCli.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnCli.TabIndex = 1;
            this.btnCli.TabStop = false;
            this.btnCli.Text = "Clientes";
            this.btnCli.UseCustomBackColor = true;
            this.btnCli.UseSelectable = true;
            // 
            // picAdv
            // 
            this.picAdv.BackColor = System.Drawing.SystemColors.Control;
            this.picAdv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picAdv.Location = new System.Drawing.Point(0, 64);
            this.picAdv.Name = "picAdv";
            this.picAdv.Size = new System.Drawing.Size(168, 274);
            this.picAdv.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAdv.TabIndex = 88;
            this.picAdv.TabStop = false;
            // 
            // tabPageCadAdv
            // 
            this.tabPageCadAdv.Controls.Add(this.btnVoltar);
            this.tabPageCadAdv.HorizontalScrollbarBarColor = true;
            this.tabPageCadAdv.HorizontalScrollbarHighlightOnWheel = false;
            this.tabPageCadAdv.HorizontalScrollbarSize = 10;
            this.tabPageCadAdv.Location = new System.Drawing.Point(4, 38);
            this.tabPageCadAdv.Name = "tabPageCadAdv";
            this.tabPageCadAdv.Size = new System.Drawing.Size(818, 491);
            this.tabPageCadAdv.TabIndex = 1;
            this.tabPageCadAdv.Text = "metroTabPage2";
            this.tabPageCadAdv.VerticalScrollbarBarColor = true;
            this.tabPageCadAdv.VerticalScrollbarHighlightOnWheel = false;
            this.tabPageCadAdv.VerticalScrollbarSize = 10;
            // 
            // btnVoltar
            // 
            this.btnVoltar.ActiveControl = null;
            this.btnVoltar.BackColor = System.Drawing.Color.DarkCyan;
            this.btnVoltar.Location = new System.Drawing.Point(5, 0);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(195, 41);
            this.btnVoltar.TabIndex = 52;
            this.btnVoltar.TabStop = false;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.TileImage = ((System.Drawing.Image)(resources.GetObject("btnVoltar.TileImage")));
            this.btnVoltar.UseCustomBackColor = true;
            this.btnVoltar.UseSelectable = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnMin
            // 
            this.btnMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(82)))));
            this.btnMin.Image = ((System.Drawing.Image)(resources.GetObject("btnMin.Image")));
            this.btnMin.ImageActive = null;
            this.btnMin.Location = new System.Drawing.Point(745, 3);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(25, 25);
            this.btnMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMin.TabIndex = 2;
            this.btnMin.TabStop = false;
            this.btnMin.Zoom = 10;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(82)))));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(776, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 0;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlTopo
            // 
            this.pnlTopo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(82)))));
            this.pnlTopo.Controls.Add(this.btnClose);
            this.pnlTopo.Controls.Add(this.btnMin);
            this.pnlTopo.Location = new System.Drawing.Point(168, 0);
            this.pnlTopo.Name = "pnlTopo";
            this.pnlTopo.Size = new System.Drawing.Size(808, 46);
            this.pnlTopo.TabIndex = 34;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(168, 30);
            this.panel1.TabIndex = 41;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(177)))), ((int)(((byte)(137)))));
            this.label6.Location = new System.Drawing.Point(57, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "AdvoGarcia";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-7, -9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 68;
            this.pictureBox1.TabStop = false;
            // 
            // drg1
            // 
            this.drg1.Fixed = true;
            this.drg1.Horizontal = true;
            this.drg1.TargetControl = this.panel1;
            this.drg1.Vertical = true;
            // 
            // drg2
            // 
            this.drg2.Fixed = true;
            this.drg2.Horizontal = true;
            this.drg2.TargetControl = this.pnlTopo;
            this.drg2.Vertical = true;
            // 
            // ellipseForm
            // 
            this.ellipseForm.ElipseRadius = 5;
            this.ellipseForm.TargetControl = this;
            // 
            // drg3
            // 
            this.drg3.Fixed = true;
            this.drg3.Horizontal = true;
            this.drg3.TargetControl = null;
            this.drg3.Vertical = true;
            // 
            // elipseAnot
            // 
            this.elipseAnot.ElipseRadius = 6;
            this.elipseAnot.TargetControl = this;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnAlt);
            this.panel7.Controls.Add(this.btnLogout);
            this.panel7.Controls.Add(this.panel1);
            this.panel7.Controls.Add(this.btnCadCli);
            this.panel7.Controls.Add(this.btnQuery);
            this.panel7.Controls.Add(this.btnHome);
            this.panel7.Controls.Add(this.btnCadAdv);
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(168, 532);
            this.panel7.TabIndex = 3;
            // 
            // btnAlt
            // 
            this.btnAlt.ActiveControl = null;
            this.btnAlt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(177)))), ((int)(((byte)(137)))));
            this.btnAlt.Location = new System.Drawing.Point(0, 385);
            this.btnAlt.Name = "btnAlt";
            this.btnAlt.Size = new System.Drawing.Size(168, 68);
            this.btnAlt.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnAlt.TabIndex = 4;
            this.btnAlt.TabStop = false;
            this.btnAlt.Text = "Alterar Dados";
            this.btnAlt.UseCustomBackColor = true;
            this.btnAlt.UseSelectable = true;
            this.btnAlt.Click += new System.EventHandler(this.btnAlt_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.ActiveControl = null;
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(124)))), ((int)(((byte)(96)))));
            this.btnLogout.Location = new System.Drawing.Point(0, 481);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(168, 51);
            this.btnLogout.Style = MetroFramework.MetroColorStyle.Lime;
            this.btnLogout.TabIndex = 5;
            this.btnLogout.TabStop = false;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseCustomBackColor = true;
            this.btnLogout.UseSelectable = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnCadCli
            // 
            this.btnCadCli.ActiveControl = null;
            this.btnCadCli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(177)))), ((int)(((byte)(137)))));
            this.btnCadCli.Location = new System.Drawing.Point(0, 237);
            this.btnCadCli.Name = "btnCadCli";
            this.btnCadCli.Size = new System.Drawing.Size(168, 68);
            this.btnCadCli.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnCadCli.TabIndex = 2;
            this.btnCadCli.TabStop = false;
            this.btnCadCli.Text = "Cadastro Cliente";
            this.btnCadCli.UseCustomBackColor = true;
            this.btnCadCli.UseSelectable = true;
            this.btnCadCli.Click += new System.EventHandler(this.btnCadCli_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.ActiveControl = null;
            this.btnQuery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(177)))), ((int)(((byte)(137)))));
            this.btnQuery.Location = new System.Drawing.Point(0, 311);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(168, 68);
            this.btnQuery.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnQuery.TabIndex = 3;
            this.btnQuery.TabStop = false;
            this.btnQuery.Text = "Consulta";
            this.btnQuery.UseCustomBackColor = true;
            this.btnQuery.UseSelectable = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // btnHome
            // 
            this.btnHome.ActiveControl = null;
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(82)))));
            this.btnHome.Location = new System.Drawing.Point(0, 65);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(84, 77);
            this.btnHome.TabIndex = 0;
            this.btnHome.TabStop = false;
            this.btnHome.Text = "Home";
            this.btnHome.UseCustomBackColor = true;
            this.btnHome.UseSelectable = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnCadAdv
            // 
            this.btnCadAdv.ActiveControl = null;
            this.btnCadAdv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(177)))), ((int)(((byte)(137)))));
            this.btnCadAdv.Location = new System.Drawing.Point(0, 163);
            this.btnCadAdv.Name = "btnCadAdv";
            this.btnCadAdv.Size = new System.Drawing.Size(168, 68);
            this.btnCadAdv.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnCadAdv.TabIndex = 1;
            this.btnCadAdv.TabStop = false;
            this.btnCadAdv.Text = "Cadastro Advogado";
            this.btnCadAdv.UseCustomBackColor = true;
            this.btnCadAdv.UseSelectable = true;
            this.btnCadAdv.Click += new System.EventHandler(this.btnCadAdv_Click);
            // 
            // tmrTempLog
            // 
            this.tmrTempLog.Enabled = true;
            this.tmrTempLog.Interval = 1000;
            this.tmrTempLog.Tick += new System.EventHandler(this.tmrTempLog_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(976, 533);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnlTopo);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.tabControl.ResumeLayout(false);
            this.tabPageHome.ResumeLayout(false);
            this.tabPageHome.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAdv)).EndInit();
            this.tabPageCadAdv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.pnlTopo.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private MetroFramework.Controls.MetroTabControl tabControl;
        private Bunifu.Framework.UI.BunifuImageButton btnMin;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private System.Windows.Forms.Panel pnlTopo;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuDragControl drg1;
        private Bunifu.Framework.UI.BunifuDragControl drg2;
        private Bunifu.Framework.UI.BunifuElipse ellipseForm;
        private Bunifu.Framework.UI.BunifuDragControl drg3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuElipse elipseAnot;
        private System.Windows.Forms.Label label6;
        private MetroFramework.Controls.MetroTabPage tabPageCadAdv;
        private System.Windows.Forms.Panel panel7;
        private MetroFramework.Controls.MetroTile btnAlt;
        private MetroFramework.Controls.MetroTile btnLogout;
        private MetroFramework.Controls.MetroTile btnCadCli;
        private MetroFramework.Controls.MetroTile btnQuery;
        private MetroFramework.Controls.MetroTile btnHome;
        private MetroFramework.Controls.MetroTile btnCadAdv;
        private MetroFramework.Controls.MetroTile btnVoltar;
        private System.Windows.Forms.Timer tmrTempLog;
        private MetroFramework.Controls.MetroTabPage tabPageHome;
        private System.Windows.Forms.Panel panel13;
        private MetroFramework.Controls.MetroTile btnCaso;
        private MetroFramework.Controls.MetroTile btnCli;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox picAdv;
        private System.Windows.Forms.Label lblTempo;
        private System.Windows.Forms.Label lblHome;
        private System.Windows.Forms.Label lblLastLog;
        private System.Windows.Forms.Label label2;
        private UC.ucMsg ucMsg1;
        private UC.ucChat ucChat1;
    }
}