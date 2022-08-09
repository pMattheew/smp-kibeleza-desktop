namespace kibelezaPMS
{
    partial class frmMenu
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
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtFuncionario = new System.Windows.Forms.TextBox();
            this.chkFuncionario = new System.Windows.Forms.CheckBox();
            this.chkCliente = new System.Windows.Forms.CheckBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.picSair = new System.Windows.Forms.PictureBox();
            this.btnAgendar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAprovar = new System.Windows.Forms.Button();
            this.dgvMenu = new System.Windows.Forms.DataGridView();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.picContato = new System.Windows.Forms.PictureBox();
            this.picBanner = new System.Windows.Forms.PictureBox();
            this.picEmail = new System.Windows.Forms.PictureBox();
            this.picRelatorio = new System.Windows.Forms.PictureBox();
            this.picSobre = new System.Windows.Forms.PictureBox();
            this.picFuncionario = new System.Windows.Forms.PictureBox();
            this.picServico = new System.Windows.Forms.PictureBox();
            this.picCliente = new System.Windows.Forms.PictureBox();
            this.picEmpresa = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picContato)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBanner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRelatorio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSobre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFuncionario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picServico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEmpresa)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.txtCliente);
            this.pnlMenu.Controls.Add(this.txtFuncionario);
            this.pnlMenu.Controls.Add(this.chkFuncionario);
            this.pnlMenu.Controls.Add(this.chkCliente);
            this.pnlMenu.Controls.Add(this.cmbStatus);
            this.pnlMenu.Controls.Add(this.lblHora);
            this.pnlMenu.Controls.Add(this.lblData);
            this.pnlMenu.Controls.Add(this.lblStatus);
            this.pnlMenu.Controls.Add(this.picSair);
            this.pnlMenu.Controls.Add(this.btnAgendar);
            this.pnlMenu.Controls.Add(this.btnEditar);
            this.pnlMenu.Controls.Add(this.button3);
            this.pnlMenu.Controls.Add(this.button2);
            this.pnlMenu.Controls.Add(this.button1);
            this.pnlMenu.Controls.Add(this.btnAprovar);
            this.pnlMenu.Controls.Add(this.dgvMenu);
            this.pnlMenu.Controls.Add(this.lblUsuario);
            this.pnlMenu.Controls.Add(this.picContato);
            this.pnlMenu.Controls.Add(this.picBanner);
            this.pnlMenu.Controls.Add(this.picEmail);
            this.pnlMenu.Controls.Add(this.picRelatorio);
            this.pnlMenu.Controls.Add(this.picSobre);
            this.pnlMenu.Controls.Add(this.picFuncionario);
            this.pnlMenu.Controls.Add(this.picServico);
            this.pnlMenu.Controls.Add(this.picCliente);
            this.pnlMenu.Controls.Add(this.picEmpresa);
            this.pnlMenu.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlMenu.Location = new System.Drawing.Point(167, 73);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(1000, 600);
            this.pnlMenu.TabIndex = 0;
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(339, 23);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(373, 25);
            this.txtCliente.TabIndex = 7;
            this.txtCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtFuncionario
            // 
            this.txtFuncionario.Location = new System.Drawing.Point(339, 54);
            this.txtFuncionario.Name = "txtFuncionario";
            this.txtFuncionario.Size = new System.Drawing.Size(373, 25);
            this.txtFuncionario.TabIndex = 7;
            this.txtFuncionario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chkFuncionario
            // 
            this.chkFuncionario.AutoSize = true;
            this.chkFuncionario.Location = new System.Drawing.Point(182, 50);
            this.chkFuncionario.Name = "chkFuncionario";
            this.chkFuncionario.Size = new System.Drawing.Size(145, 21);
            this.chkFuncionario.TabIndex = 6;
            this.chkFuncionario.Text = "FUNCIONÁRIO(A)";
            this.chkFuncionario.UseVisualStyleBackColor = true;
            // 
            // chkCliente
            // 
            this.chkCliente.AutoSize = true;
            this.chkCliente.Location = new System.Drawing.Point(182, 23);
            this.chkCliente.Name = "chkCliente";
            this.chkCliente.Size = new System.Drawing.Size(86, 21);
            this.chkCliente.TabIndex = 6;
            this.chkCliente.Text = "CLIENTE";
            this.chkCliente.UseVisualStyleBackColor = true;
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "APROVADA",
            "CANCELADO",
            "FINALIZADO",
            "AGUARDANDO"});
            this.cmbStatus.Location = new System.Drawing.Point(767, 54);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(121, 25);
            this.cmbStatus.TabIndex = 5;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.lblHora.Location = new System.Drawing.Point(26, 50);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(53, 17);
            this.lblHora.TabIndex = 4;
            this.lblHora.Text = "00:00";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.lblData.Location = new System.Drawing.Point(26, 23);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(102, 17);
            this.lblData.TabIndex = 4;
            this.lblData.Text = "00/00/0000";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(797, 27);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(61, 17);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "STATUS";
            // 
            // picSair
            // 
            this.picSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picSair.Image = global::kibelezaPMS.Properties.Resources.fechar;
            this.picSair.Location = new System.Drawing.Point(930, 23);
            this.picSair.Name = "picSair";
            this.picSair.Size = new System.Drawing.Size(60, 60);
            this.picSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSair.TabIndex = 3;
            this.picSair.TabStop = false;
            this.picSair.Click += new System.EventHandler(this.picSair_Click);
            // 
            // btnAgendar
            // 
            this.btnAgendar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.btnAgendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgendar.Font = new System.Drawing.Font("Britannic Bold", 14F);
            this.btnAgendar.ForeColor = System.Drawing.Color.White;
            this.btnAgendar.Location = new System.Drawing.Point(840, 354);
            this.btnAgendar.Name = "btnAgendar";
            this.btnAgendar.Size = new System.Drawing.Size(150, 50);
            this.btnAgendar.TabIndex = 2;
            this.btnAgendar.Text = "AGENDAR";
            this.btnAgendar.UseVisualStyleBackColor = false;
            this.btnAgendar.Click += new System.EventHandler(this.btnAgendar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Britannic Bold", 14F);
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(840, 301);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(150, 50);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Britannic Bold", 14F);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(840, 248);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 50);
            this.button3.TabIndex = 2;
            this.button3.Text = "AGUARDAR";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Britannic Bold", 14F);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(840, 195);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 50);
            this.button2.TabIndex = 2;
            this.button2.Text = "FINALIZAR";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Britannic Bold", 14F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(840, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 50);
            this.button1.TabIndex = 2;
            this.button1.Text = "CANCELAR";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnAprovar
            // 
            this.btnAprovar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.btnAprovar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAprovar.Font = new System.Drawing.Font("Britannic Bold", 14F);
            this.btnAprovar.ForeColor = System.Drawing.Color.White;
            this.btnAprovar.Location = new System.Drawing.Point(840, 89);
            this.btnAprovar.Name = "btnAprovar";
            this.btnAprovar.Size = new System.Drawing.Size(150, 50);
            this.btnAprovar.TabIndex = 2;
            this.btnAprovar.Text = "APROVAR";
            this.btnAprovar.UseVisualStyleBackColor = false;
            // 
            // dgvMenu
            // 
            this.dgvMenu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.dgvMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenu.EnableHeadersVisualStyles = false;
            this.dgvMenu.Location = new System.Drawing.Point(339, 89);
            this.dgvMenu.Name = "dgvMenu";
            this.dgvMenu.Size = new System.Drawing.Size(495, 321);
            this.dgvMenu.TabIndex = 1;
            // 
            // lblUsuario
            // 
            this.lblUsuario.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.lblUsuario.Location = new System.Drawing.Point(0, 577);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(1000, 23);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "USUÁRIO";
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picContato
            // 
            this.picContato.BackColor = System.Drawing.Color.White;
            this.picContato.Image = global::kibelezaPMS.Properties.Resources.btnContato;
            this.picContato.Location = new System.Drawing.Point(660, 410);
            this.picContato.Name = "picContato";
            this.picContato.Size = new System.Drawing.Size(165, 165);
            this.picContato.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picContato.TabIndex = 0;
            this.picContato.TabStop = false;
            this.picContato.Click += new System.EventHandler(this.picContato_Click);
            // 
            // picBanner
            // 
            this.picBanner.BackColor = System.Drawing.Color.White;
            this.picBanner.Image = global::kibelezaPMS.Properties.Resources.btnBanner;
            this.picBanner.Location = new System.Drawing.Point(330, 410);
            this.picBanner.Name = "picBanner";
            this.picBanner.Size = new System.Drawing.Size(165, 165);
            this.picBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBanner.TabIndex = 0;
            this.picBanner.TabStop = false;
            // 
            // picEmail
            // 
            this.picEmail.BackColor = System.Drawing.Color.White;
            this.picEmail.Image = global::kibelezaPMS.Properties.Resources.btnEmail;
            this.picEmail.Location = new System.Drawing.Point(825, 410);
            this.picEmail.Name = "picEmail";
            this.picEmail.Size = new System.Drawing.Size(165, 165);
            this.picEmail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picEmail.TabIndex = 0;
            this.picEmail.TabStop = false;
            this.picEmail.Click += new System.EventHandler(this.picEmail_Click);
            // 
            // picRelatorio
            // 
            this.picRelatorio.BackColor = System.Drawing.Color.White;
            this.picRelatorio.Image = global::kibelezaPMS.Properties.Resources.btnRelatorio;
            this.picRelatorio.Location = new System.Drawing.Point(165, 410);
            this.picRelatorio.Name = "picRelatorio";
            this.picRelatorio.Size = new System.Drawing.Size(165, 165);
            this.picRelatorio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRelatorio.TabIndex = 0;
            this.picRelatorio.TabStop = false;
            this.picRelatorio.Click += new System.EventHandler(this.picRelatorio_Click);
            // 
            // picSobre
            // 
            this.picSobre.BackColor = System.Drawing.Color.White;
            this.picSobre.Image = global::kibelezaPMS.Properties.Resources.btnSobre;
            this.picSobre.Location = new System.Drawing.Point(495, 410);
            this.picSobre.Name = "picSobre";
            this.picSobre.Size = new System.Drawing.Size(165, 165);
            this.picSobre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSobre.TabIndex = 0;
            this.picSobre.TabStop = false;
            // 
            // picFuncionario
            // 
            this.picFuncionario.BackColor = System.Drawing.Color.White;
            this.picFuncionario.Image = global::kibelezaPMS.Properties.Resources.btnFuncionario;
            this.picFuncionario.Location = new System.Drawing.Point(0, 410);
            this.picFuncionario.Name = "picFuncionario";
            this.picFuncionario.Size = new System.Drawing.Size(165, 165);
            this.picFuncionario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFuncionario.TabIndex = 0;
            this.picFuncionario.TabStop = false;
            this.picFuncionario.Click += new System.EventHandler(this.picFuncionario_Click);
            // 
            // picServico
            // 
            this.picServico.BackColor = System.Drawing.Color.White;
            this.picServico.Image = global::kibelezaPMS.Properties.Resources.btnServico;
            this.picServico.Location = new System.Drawing.Point(165, 245);
            this.picServico.Name = "picServico";
            this.picServico.Size = new System.Drawing.Size(165, 165);
            this.picServico.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picServico.TabIndex = 0;
            this.picServico.TabStop = false;
            this.picServico.Click += new System.EventHandler(this.picServico_Click);
            // 
            // picCliente
            // 
            this.picCliente.BackColor = System.Drawing.Color.White;
            this.picCliente.Image = global::kibelezaPMS.Properties.Resources.btnCliente;
            this.picCliente.Location = new System.Drawing.Point(0, 245);
            this.picCliente.Name = "picCliente";
            this.picCliente.Size = new System.Drawing.Size(165, 165);
            this.picCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCliente.TabIndex = 0;
            this.picCliente.TabStop = false;
            this.picCliente.Click += new System.EventHandler(this.picCliente_Click);
            // 
            // picEmpresa
            // 
            this.picEmpresa.BackColor = System.Drawing.Color.White;
            this.picEmpresa.Image = global::kibelezaPMS.Properties.Resources.logo;
            this.picEmpresa.Location = new System.Drawing.Point(0, 89);
            this.picEmpresa.Name = "picEmpresa";
            this.picEmpresa.Size = new System.Drawing.Size(330, 150);
            this.picEmpresa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picEmpresa.TabIndex = 0;
            this.picEmpresa.TabStop = false;
            this.picEmpresa.Click += new System.EventHandler(this.picEmpresa_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::kibelezaPMS.Properties.Resources.fundo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1360, 768);
            this.Controls.Add(this.pnlMenu);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picContato)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBanner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRelatorio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSobre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFuncionario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picServico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEmpresa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.PictureBox picSair;
        private System.Windows.Forms.Button btnAgendar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAprovar;
        private System.Windows.Forms.DataGridView dgvMenu;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.PictureBox picContato;
        private System.Windows.Forms.PictureBox picBanner;
        private System.Windows.Forms.PictureBox picEmail;
        private System.Windows.Forms.PictureBox picRelatorio;
        private System.Windows.Forms.PictureBox picSobre;
        private System.Windows.Forms.PictureBox picFuncionario;
        private System.Windows.Forms.PictureBox picServico;
        private System.Windows.Forms.PictureBox picCliente;
        private System.Windows.Forms.PictureBox picEmpresa;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.TextBox txtFuncionario;
        private System.Windows.Forms.CheckBox chkFuncionario;
        private System.Windows.Forms.CheckBox chkCliente;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Timer timer1;
    }
}