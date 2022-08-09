namespace kibelezaPMS
{
    partial class frmCadEmpresa
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
            this.pnlCadEmpresa = new System.Windows.Forms.Panel();
            this.pnlTelefone = new System.Windows.Forms.Panel();
            this.dgvFoneEmpresa = new System.Windows.Forms.DataGridView();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.picSair = new System.Windows.Forms.PictureBox();
            this.cmbHorario = new System.Windows.Forms.ComboBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.mkdDataCad = new System.Windows.Forms.MaskedTextBox();
            this.mkdCnpjCpf = new System.Windows.Forms.MaskedTextBox();
            this.radCpf = new System.Windows.Forms.RadioButton();
            this.radCnpj = new System.Windows.Forms.RadioButton();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtRazao = new System.Windows.Forms.TextBox();
            this.lblHorario = new System.Windows.Forms.Label();
            this.lblDataCad = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtNomeEmpresa = new System.Windows.Forms.TextBox();
            this.lblRazao = new System.Windows.Forms.Label();
            this.lblNomeEmpresa = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblCadEmpresa = new System.Windows.Forms.Label();
            this.pnlCadEmpresa.SuspendLayout();
            this.pnlTelefone.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoneEmpresa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSair)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCadEmpresa
            // 
            this.pnlCadEmpresa.BackgroundImage = global::kibelezaPMS.Properties.Resources.empresa;
            this.pnlCadEmpresa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlCadEmpresa.Controls.Add(this.pnlTelefone);
            this.pnlCadEmpresa.Controls.Add(this.picSair);
            this.pnlCadEmpresa.Controls.Add(this.cmbHorario);
            this.pnlCadEmpresa.Controls.Add(this.cmbStatus);
            this.pnlCadEmpresa.Controls.Add(this.mkdDataCad);
            this.pnlCadEmpresa.Controls.Add(this.mkdCnpjCpf);
            this.pnlCadEmpresa.Controls.Add(this.radCpf);
            this.pnlCadEmpresa.Controls.Add(this.radCnpj);
            this.pnlCadEmpresa.Controls.Add(this.txtEmail);
            this.pnlCadEmpresa.Controls.Add(this.txtRazao);
            this.pnlCadEmpresa.Controls.Add(this.lblHorario);
            this.pnlCadEmpresa.Controls.Add(this.lblDataCad);
            this.pnlCadEmpresa.Controls.Add(this.lblStatus);
            this.pnlCadEmpresa.Controls.Add(this.lblEmail);
            this.pnlCadEmpresa.Controls.Add(this.txtNomeEmpresa);
            this.pnlCadEmpresa.Controls.Add(this.lblRazao);
            this.pnlCadEmpresa.Controls.Add(this.lblNomeEmpresa);
            this.pnlCadEmpresa.Controls.Add(this.txtCodigo);
            this.pnlCadEmpresa.Controls.Add(this.lblCodigo);
            this.pnlCadEmpresa.Controls.Add(this.btnLimpar);
            this.pnlCadEmpresa.Controls.Add(this.btnSalvar);
            this.pnlCadEmpresa.Controls.Add(this.lblCadEmpresa);
            this.pnlCadEmpresa.Location = new System.Drawing.Point(180, 84);
            this.pnlCadEmpresa.Name = "pnlCadEmpresa";
            this.pnlCadEmpresa.Size = new System.Drawing.Size(1000, 600);
            this.pnlCadEmpresa.TabIndex = 2;
            // 
            // pnlTelefone
            // 
            this.pnlTelefone.BackColor = System.Drawing.Color.Transparent;
            this.pnlTelefone.BackgroundImage = global::kibelezaPMS.Properties.Resources.fonemepresa;
            this.pnlTelefone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlTelefone.Controls.Add(this.dgvFoneEmpresa);
            this.pnlTelefone.Controls.Add(this.btnCadastrar);
            this.pnlTelefone.Controls.Add(this.btnAlterar);
            this.pnlTelefone.Controls.Add(this.btnExcluir);
            this.pnlTelefone.Enabled = false;
            this.pnlTelefone.Location = new System.Drawing.Point(184, 271);
            this.pnlTelefone.Name = "pnlTelefone";
            this.pnlTelefone.Size = new System.Drawing.Size(569, 263);
            this.pnlTelefone.TabIndex = 19;
            // 
            // dgvFoneEmpresa
            // 
            this.dgvFoneEmpresa.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.dgvFoneEmpresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFoneEmpresa.Location = new System.Drawing.Point(107, 13);
            this.dgvFoneEmpresa.Name = "dgvFoneEmpresa";
            this.dgvFoneEmpresa.Size = new System.Drawing.Size(448, 192);
            this.dgvFoneEmpresa.TabIndex = 0;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(52)))), ((int)(((byte)(96)))));
            this.btnCadastrar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCadastrar.FlatAppearance.BorderSize = 2;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.btnCadastrar.ForeColor = System.Drawing.Color.White;
            this.btnCadastrar.Location = new System.Drawing.Point(107, 217);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(134, 35);
            this.btnCadastrar.TabIndex = 9;
            this.btnCadastrar.Text = "CADASTRAR";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(52)))), ((int)(((byte)(96)))));
            this.btnAlterar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAlterar.FlatAppearance.BorderSize = 2;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.btnAlterar.ForeColor = System.Drawing.Color.White;
            this.btnAlterar.Location = new System.Drawing.Point(264, 217);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(134, 35);
            this.btnAlterar.TabIndex = 10;
            this.btnAlterar.Text = "ALTERAR";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(52)))), ((int)(((byte)(96)))));
            this.btnExcluir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExcluir.FlatAppearance.BorderSize = 2;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.btnExcluir.ForeColor = System.Drawing.Color.White;
            this.btnExcluir.Location = new System.Drawing.Point(421, 217);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(134, 35);
            this.btnExcluir.TabIndex = 11;
            this.btnExcluir.Text = "EXCLUIR";
            this.btnExcluir.UseVisualStyleBackColor = false;
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
            this.picSair.Click += new System.EventHandler(this.picSair_Click_1);
            // 
            // cmbHorario
            // 
            this.cmbHorario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHorario.FormattingEnabled = true;
            this.cmbHorario.Items.AddRange(new object[] {
            "6:00",
            "8:00",
            "10:00",
            "12:00",
            "14:00",
            "16:00"});
            this.cmbHorario.Location = new System.Drawing.Point(759, 454);
            this.cmbHorario.Name = "cmbHorario";
            this.cmbHorario.Size = new System.Drawing.Size(222, 21);
            this.cmbHorario.TabIndex = 7;
            this.cmbHorario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbHorario_KeyPress);
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "ATIVA",
            "INATIVA"});
            this.cmbStatus.Location = new System.Drawing.Point(761, 314);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(222, 21);
            this.cmbStatus.TabIndex = 6;
            this.cmbStatus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbStatus_KeyPress);
            // 
            // mkdDataCad
            // 
            this.mkdDataCad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.mkdDataCad.Location = new System.Drawing.Point(761, 384);
            this.mkdDataCad.Mask = "00/00/0000";
            this.mkdDataCad.Name = "mkdDataCad";
            this.mkdDataCad.Size = new System.Drawing.Size(222, 23);
            this.mkdDataCad.TabIndex = 16;
            this.mkdDataCad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mkdCnpjCpf
            // 
            this.mkdCnpjCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.mkdCnpjCpf.Location = new System.Drawing.Point(184, 168);
            this.mkdCnpjCpf.Mask = "00,000,000/0000-00";
            this.mkdCnpjCpf.Name = "mkdCnpjCpf";
            this.mkdCnpjCpf.Size = new System.Drawing.Size(161, 23);
            this.mkdCnpjCpf.TabIndex = 3;
            this.mkdCnpjCpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mkdCnpjCpf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mkdCnpjCpf_KeyPress);
            // 
            // radCpf
            // 
            this.radCpf.AutoSize = true;
            this.radCpf.BackColor = System.Drawing.Color.Transparent;
            this.radCpf.Font = new System.Drawing.Font("Britannic Bold", 14F);
            this.radCpf.Location = new System.Drawing.Point(259, 141);
            this.radCpf.Name = "radCpf";
            this.radCpf.Size = new System.Drawing.Size(59, 25);
            this.radCpf.TabIndex = 2;
            this.radCpf.Text = "CPF";
            this.radCpf.UseVisualStyleBackColor = false;
            this.radCpf.CheckedChanged += new System.EventHandler(this.radCpf_CheckedChanged);
            // 
            // radCnpj
            // 
            this.radCnpj.AutoSize = true;
            this.radCnpj.BackColor = System.Drawing.Color.Transparent;
            this.radCnpj.Checked = true;
            this.radCnpj.Font = new System.Drawing.Font("Britannic Bold", 14F);
            this.radCnpj.Location = new System.Drawing.Point(184, 141);
            this.radCnpj.Name = "radCnpj";
            this.radCnpj.Size = new System.Drawing.Size(69, 25);
            this.radCnpj.TabIndex = 1;
            this.radCnpj.TabStop = true;
            this.radCnpj.Text = "CNPJ";
            this.radCnpj.UseVisualStyleBackColor = false;
            this.radCnpj.CheckedChanged += new System.EventHandler(this.radCnpj_CheckedChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtEmail.Location = new System.Drawing.Point(391, 168);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(593, 23);
            this.txtEmail.TabIndex = 4;
            this.txtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmail_KeyPress);
            // 
            // txtRazao
            // 
            this.txtRazao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRazao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtRazao.Location = new System.Drawing.Point(184, 231);
            this.txtRazao.Name = "txtRazao";
            this.txtRazao.Size = new System.Drawing.Size(800, 23);
            this.txtRazao.TabIndex = 5;
            this.txtRazao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRazao_KeyPress);
            // 
            // lblHorario
            // 
            this.lblHorario.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblHorario.BackColor = System.Drawing.Color.Transparent;
            this.lblHorario.Font = new System.Drawing.Font("Britannic Bold", 14F);
            this.lblHorario.Location = new System.Drawing.Point(755, 429);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(226, 22);
            this.lblHorario.TabIndex = 13;
            this.lblHorario.Text = "Horário de atendimento:";
            this.lblHorario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDataCad
            // 
            this.lblDataCad.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDataCad.BackColor = System.Drawing.Color.Transparent;
            this.lblDataCad.Font = new System.Drawing.Font("Britannic Bold", 14F);
            this.lblDataCad.Location = new System.Drawing.Point(758, 359);
            this.lblDataCad.Name = "lblDataCad";
            this.lblDataCad.Size = new System.Drawing.Size(165, 22);
            this.lblDataCad.TabIndex = 13;
            this.lblDataCad.Text = "Data de cadastro:";
            this.lblDataCad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("Britannic Bold", 14F);
            this.lblStatus.Location = new System.Drawing.Point(758, 289);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(165, 22);
            this.lblStatus.TabIndex = 13;
            this.lblStatus.Text = "Status:";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Britannic Bold", 14F);
            this.lblEmail.Location = new System.Drawing.Point(387, 143);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(165, 22);
            this.lblEmail.TabIndex = 13;
            this.lblEmail.Text = "E-mail:";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNomeEmpresa
            // 
            this.txtNomeEmpresa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtNomeEmpresa.Location = new System.Drawing.Point(322, 109);
            this.txtNomeEmpresa.Name = "txtNomeEmpresa";
            this.txtNomeEmpresa.Size = new System.Drawing.Size(663, 23);
            this.txtNomeEmpresa.TabIndex = 0;
            this.txtNomeEmpresa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomeEmpresa_KeyPress);
            // 
            // lblRazao
            // 
            this.lblRazao.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblRazao.BackColor = System.Drawing.Color.Transparent;
            this.lblRazao.Font = new System.Drawing.Font("Britannic Bold", 14F);
            this.lblRazao.Location = new System.Drawing.Point(180, 206);
            this.lblRazao.Name = "lblRazao";
            this.lblRazao.Size = new System.Drawing.Size(165, 22);
            this.lblRazao.TabIndex = 13;
            this.lblRazao.Text = "Razão Social:";
            this.lblRazao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNomeEmpresa
            // 
            this.lblNomeEmpresa.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblNomeEmpresa.BackColor = System.Drawing.Color.Transparent;
            this.lblNomeEmpresa.Font = new System.Drawing.Font("Britannic Bold", 14F);
            this.lblNomeEmpresa.Location = new System.Drawing.Point(318, 84);
            this.lblNomeEmpresa.Name = "lblNomeEmpresa";
            this.lblNomeEmpresa.Size = new System.Drawing.Size(165, 22);
            this.lblNomeEmpresa.TabIndex = 13;
            this.lblNomeEmpresa.Text = "Nome da Empresa:";
            this.lblNomeEmpresa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
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
            // lblCadEmpresa
            // 
            this.lblCadEmpresa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCadEmpresa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.lblCadEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCadEmpresa.Font = new System.Drawing.Font("Britannic Bold", 16F);
            this.lblCadEmpresa.ForeColor = System.Drawing.Color.White;
            this.lblCadEmpresa.Location = new System.Drawing.Point(164, 0);
            this.lblCadEmpresa.Name = "lblCadEmpresa";
            this.lblCadEmpresa.Size = new System.Drawing.Size(836, 72);
            this.lblCadEmpresa.TabIndex = 12;
            this.lblCadEmpresa.Text = "CADASTRO DA EMPRESA";
            this.lblCadEmpresa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmCadEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::kibelezaPMS.Properties.Resources.fundo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1360, 768);
            this.Controls.Add(this.pnlCadEmpresa);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCadEmpresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Empresa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCadEmpresa_Load);
            this.pnlCadEmpresa.ResumeLayout(false);
            this.pnlCadEmpresa.PerformLayout();
            this.pnlTelefone.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoneEmpresa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSair)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCadEmpresa;
        private System.Windows.Forms.Label lblCadEmpresa;
        private System.Windows.Forms.MaskedTextBox mkdCnpjCpf;
        private System.Windows.Forms.RadioButton radCpf;
        private System.Windows.Forms.RadioButton radCnpj;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtRazao;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtNomeEmpresa;
        private System.Windows.Forms.Label lblRazao;
        private System.Windows.Forms.Label lblNomeEmpresa;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.Label lblDataCad;
        private System.Windows.Forms.ComboBox cmbHorario;
        private System.Windows.Forms.MaskedTextBox mkdDataCad;
        private System.Windows.Forms.PictureBox picSair;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Panel pnlTelefone;
        private System.Windows.Forms.DataGridView dgvFoneEmpresa;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnLimpar;
    }
}