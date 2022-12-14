namespace kibelezaPMS
{
    partial class frmCadReserva
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
            this.pnlCadReserva = new System.Windows.Forms.Panel();
            this.mkdDataCad = new System.Windows.Forms.MaskedTextBox();
            this.calReserva = new System.Windows.Forms.MonthCalendar();
            this.lblDataReserva = new System.Windows.Forms.Label();
            this.picSair = new System.Windows.Forms.PictureBox();
            this.cmbServico = new System.Windows.Forms.ComboBox();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.cmbFuncionario = new System.Windows.Forms.ComboBox();
            this.cmbHorario = new System.Windows.Forms.ComboBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.lblServico = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblFuncionario = new System.Windows.Forms.Label();
            this.lblHorario = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblObservacao = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblCadReserva = new System.Windows.Forms.Label();
            this.pnlCadReserva.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSair)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCadReserva
            // 
            this.pnlCadReserva.BackgroundImage = global::kibelezaPMS.Properties.Resources.reserva;
            this.pnlCadReserva.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlCadReserva.Controls.Add(this.mkdDataCad);
            this.pnlCadReserva.Controls.Add(this.calReserva);
            this.pnlCadReserva.Controls.Add(this.lblDataReserva);
            this.pnlCadReserva.Controls.Add(this.picSair);
            this.pnlCadReserva.Controls.Add(this.cmbServico);
            this.pnlCadReserva.Controls.Add(this.cmbCliente);
            this.pnlCadReserva.Controls.Add(this.cmbFuncionario);
            this.pnlCadReserva.Controls.Add(this.cmbHorario);
            this.pnlCadReserva.Controls.Add(this.cmbStatus);
            this.pnlCadReserva.Controls.Add(this.txtObservacao);
            this.pnlCadReserva.Controls.Add(this.lblServico);
            this.pnlCadReserva.Controls.Add(this.lblCliente);
            this.pnlCadReserva.Controls.Add(this.lblFuncionario);
            this.pnlCadReserva.Controls.Add(this.lblHorario);
            this.pnlCadReserva.Controls.Add(this.lblStatus);
            this.pnlCadReserva.Controls.Add(this.lblObservacao);
            this.pnlCadReserva.Controls.Add(this.txtCodigo);
            this.pnlCadReserva.Controls.Add(this.lblCodigo);
            this.pnlCadReserva.Controls.Add(this.btnLimpar);
            this.pnlCadReserva.Controls.Add(this.btnSalvar);
            this.pnlCadReserva.Controls.Add(this.lblCadReserva);
            this.pnlCadReserva.Location = new System.Drawing.Point(180, 84);
            this.pnlCadReserva.Name = "pnlCadReserva";
            this.pnlCadReserva.Size = new System.Drawing.Size(1000, 600);
            this.pnlCadReserva.TabIndex = 4;
            // 
            // mkdDataCad
            // 
            this.mkdDataCad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.mkdDataCad.Location = new System.Drawing.Point(184, 403);
            this.mkdDataCad.Mask = "00/00/0000";
            this.mkdDataCad.Name = "mkdDataCad";
            this.mkdDataCad.Size = new System.Drawing.Size(227, 23);
            this.mkdDataCad.TabIndex = 21;
            this.mkdDataCad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // calReserva
            // 
            this.calReserva.Location = new System.Drawing.Point(184, 234);
            this.calReserva.Name = "calReserva";
            this.calReserva.TabIndex = 2;
            this.calReserva.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calReserva_DateChanged);
            this.calReserva.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.calReserva_KeyPress);
            // 
            // lblDataReserva
            // 
            this.lblDataReserva.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDataReserva.BackColor = System.Drawing.Color.Transparent;
            this.lblDataReserva.Font = new System.Drawing.Font("Britannic Bold", 14F);
            this.lblDataReserva.Location = new System.Drawing.Point(180, 209);
            this.lblDataReserva.Name = "lblDataReserva";
            this.lblDataReserva.Size = new System.Drawing.Size(165, 22);
            this.lblDataReserva.TabIndex = 20;
            this.lblDataReserva.Text = "Data da reserva:";
            this.lblDataReserva.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picSair
            // 
            this.picSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.picSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picSair.Image = global::kibelezaPMS.Properties.Resources.fechar;
            this.picSair.Location = new System.Drawing.Point(934, 6);
            this.picSair.Name = "picSair";
            this.picSair.Size = new System.Drawing.Size(60, 60);
            this.picSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSair.TabIndex = 18;
            this.picSair.TabStop = false;
            this.picSair.Click += new System.EventHandler(this.picSair_Click);
            // 
            // cmbServico
            // 
            this.cmbServico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbServico.FormattingEnabled = true;
            this.cmbServico.Location = new System.Drawing.Point(472, 429);
            this.cmbServico.Name = "cmbServico";
            this.cmbServico.Size = new System.Drawing.Size(510, 21);
            this.cmbServico.TabIndex = 7;
            this.cmbServico.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbServico_KeyPress);
            // 
            // cmbCliente
            // 
            this.cmbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(472, 364);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(510, 21);
            this.cmbCliente.TabIndex = 6;
            this.cmbCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbCliente_KeyPress);
            // 
            // cmbFuncionario
            // 
            this.cmbFuncionario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFuncionario.FormattingEnabled = true;
            this.cmbFuncionario.Location = new System.Drawing.Point(472, 299);
            this.cmbFuncionario.Name = "cmbFuncionario";
            this.cmbFuncionario.Size = new System.Drawing.Size(510, 21);
            this.cmbFuncionario.TabIndex = 5;
            this.cmbFuncionario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbFuncionario_KeyPress);
            // 
            // cmbHorario
            // 
            this.cmbHorario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHorario.FormattingEnabled = true;
            this.cmbHorario.Items.AddRange(new object[] {
            "6:00",
            "6:30",
            "7:00",
            "7:30",
            "8:00",
            "8:30",
            "9:00",
            "9:30",
            "10:00",
            "10:30",
            "11:00",
            "11:30",
            "12:00",
            "12:30",
            "13:00",
            "13:30",
            "14:00",
            "14:30",
            "15:00",
            "15:30",
            "16:00",
            "16:30",
            "17:00",
            "17:30",
            "18:00",
            "18:30",
            "19:00",
            "19:30",
            "20:00",
            "20:30",
            "21:00",
            "21:30"});
            this.cmbHorario.Location = new System.Drawing.Point(472, 234);
            this.cmbHorario.Name = "cmbHorario";
            this.cmbHorario.Size = new System.Drawing.Size(222, 21);
            this.cmbHorario.TabIndex = 3;
            this.cmbHorario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbHorario_KeyPress);
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "AGUARDANDO",
            "APROVADA",
            "CANCELADA",
            "FINALIZADA"});
            this.cmbStatus.Location = new System.Drawing.Point(760, 234);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(222, 21);
            this.cmbStatus.TabIndex = 4;
            this.cmbStatus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbStatus_KeyPress);
            // 
            // txtObservacao
            // 
            this.txtObservacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtObservacao.Location = new System.Drawing.Point(184, 171);
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(800, 23);
            this.txtObservacao.TabIndex = 1;
            this.txtObservacao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtObservacao_KeyPress);
            // 
            // lblServico
            // 
            this.lblServico.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblServico.BackColor = System.Drawing.Color.Transparent;
            this.lblServico.Font = new System.Drawing.Font("Britannic Bold", 14F);
            this.lblServico.Location = new System.Drawing.Point(472, 404);
            this.lblServico.Name = "lblServico";
            this.lblServico.Size = new System.Drawing.Size(226, 22);
            this.lblServico.TabIndex = 13;
            this.lblServico.Text = "Serviço:";
            this.lblServico.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCliente
            // 
            this.lblCliente.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblCliente.Font = new System.Drawing.Font("Britannic Bold", 14F);
            this.lblCliente.Location = new System.Drawing.Point(472, 339);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(226, 22);
            this.lblCliente.TabIndex = 13;
            this.lblCliente.Text = "Cliente:";
            this.lblCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFuncionario
            // 
            this.lblFuncionario.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblFuncionario.BackColor = System.Drawing.Color.Transparent;
            this.lblFuncionario.Font = new System.Drawing.Font("Britannic Bold", 14F);
            this.lblFuncionario.Location = new System.Drawing.Point(472, 274);
            this.lblFuncionario.Name = "lblFuncionario";
            this.lblFuncionario.Size = new System.Drawing.Size(226, 22);
            this.lblFuncionario.TabIndex = 13;
            this.lblFuncionario.Text = "Funcionário:";
            this.lblFuncionario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHorario
            // 
            this.lblHorario.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblHorario.BackColor = System.Drawing.Color.Transparent;
            this.lblHorario.Font = new System.Drawing.Font("Britannic Bold", 14F);
            this.lblHorario.Location = new System.Drawing.Point(472, 209);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(178, 22);
            this.lblHorario.TabIndex = 13;
            this.lblHorario.Text = "Horário da reserva:";
            this.lblHorario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("Britannic Bold", 14F);
            this.lblStatus.Location = new System.Drawing.Point(758, 209);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(165, 22);
            this.lblStatus.TabIndex = 13;
            this.lblStatus.Text = "Status:";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblObservacao
            // 
            this.lblObservacao.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblObservacao.BackColor = System.Drawing.Color.Transparent;
            this.lblObservacao.Font = new System.Drawing.Font("Britannic Bold", 14F);
            this.lblObservacao.Location = new System.Drawing.Point(180, 146);
            this.lblObservacao.Name = "lblObservacao";
            this.lblObservacao.Size = new System.Drawing.Size(165, 22);
            this.lblObservacao.TabIndex = 13;
            this.lblObservacao.Text = "Obs.:";
            this.lblObservacao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtCodigo.Location = new System.Drawing.Point(184, 109);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 23);
            this.txtCodigo.TabIndex = 14;
            // 
            // lblCodigo
            // 
            this.lblCodigo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCodigo.BackColor = System.Drawing.Color.Transparent;
            this.lblCodigo.Font = new System.Drawing.Font("Britannic Bold", 14F);
            this.lblCodigo.Location = new System.Drawing.Point(180, 84);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(100, 22);
            this.lblCodigo.TabIndex = 13;
            this.lblCodigo.Text = "Código:";
            this.lblCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(52)))), ((int)(((byte)(96)))));
            this.btnLimpar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLimpar.FlatAppearance.BorderSize = 2;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Britannic Bold", 14F);
            this.btnLimpar.ForeColor = System.Drawing.Color.White;
            this.btnLimpar.Location = new System.Drawing.Point(636, 550);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(193, 35);
            this.btnLimpar.TabIndex = 11;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(52)))), ((int)(((byte)(96)))));
            this.btnSalvar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSalvar.FlatAppearance.BorderSize = 2;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Britannic Bold", 14F);
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Location = new System.Drawing.Point(322, 550);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(193, 35);
            this.btnSalvar.TabIndex = 8;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblCadReserva
            // 
            this.lblCadReserva.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCadReserva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.lblCadReserva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCadReserva.Font = new System.Drawing.Font("Britannic Bold", 16F);
            this.lblCadReserva.ForeColor = System.Drawing.Color.White;
            this.lblCadReserva.Location = new System.Drawing.Point(164, 0);
            this.lblCadReserva.Name = "lblCadReserva";
            this.lblCadReserva.Size = new System.Drawing.Size(836, 72);
            this.lblCadReserva.TabIndex = 12;
            this.lblCadReserva.Text = "CADASTRO DE RESERVA";
            this.lblCadReserva.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmCadReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::kibelezaPMS.Properties.Resources.fundo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1360, 768);
            this.Controls.Add(this.pnlCadReserva);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCadReserva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Reserva";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCadReserva_Load);
            this.pnlCadReserva.ResumeLayout(false);
            this.pnlCadReserva.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSair)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCadReserva;
        private System.Windows.Forms.MonthCalendar calReserva;
        private System.Windows.Forms.Label lblDataReserva;
        private System.Windows.Forms.PictureBox picSair;
        private System.Windows.Forms.ComboBox cmbServico;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.ComboBox cmbFuncionario;
        private System.Windows.Forms.ComboBox cmbHorario;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.Label lblServico;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblFuncionario;
        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblObservacao;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblCadReserva;
        private System.Windows.Forms.MaskedTextBox mkdDataCad;
    }
}