namespace kibelezaPMS
{
    partial class frmCadCliente
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
            this.pnlCadCliente = new System.Windows.Forms.Panel();
            this.btnFoto = new System.Windows.Forms.Button();
            this.lblFoto = new System.Windows.Forms.Label();
            this.picFoto = new System.Windows.Forms.PictureBox();
            this.pnlTelefone = new System.Windows.Forms.Panel();
            this.dgvFoneCliente = new System.Windows.Forms.DataGridView();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.picSair = new System.Windows.Forms.PictureBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.mkdDataCad = new System.Windows.Forms.MaskedTextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblDataCad = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblNomeCliente = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblCadCliente = new System.Windows.Forms.Label();
            this.pnlCadCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).BeginInit();
            this.pnlTelefone.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoneCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSair)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCadCliente
            // 
            this.pnlCadCliente.BackgroundImage = global::kibelezaPMS.Properties.Resources.cliente;
            this.pnlCadCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlCadCliente.Controls.Add(this.btnFoto);
            this.pnlCadCliente.Controls.Add(this.lblFoto);
            this.pnlCadCliente.Controls.Add(this.picFoto);
            this.pnlCadCliente.Controls.Add(this.pnlTelefone);
            this.pnlCadCliente.Controls.Add(this.picSair);
            this.pnlCadCliente.Controls.Add(this.cmbStatus);
            this.pnlCadCliente.Controls.Add(this.mkdDataCad);
            this.pnlCadCliente.Controls.Add(this.txtEmail);
            this.pnlCadCliente.Controls.Add(this.txtSenha);
            this.pnlCadCliente.Controls.Add(this.lblDataCad);
            this.pnlCadCliente.Controls.Add(this.lblStatus);
            this.pnlCadCliente.Controls.Add(this.lblEmail);
            this.pnlCadCliente.Controls.Add(this.txtNomeCliente);
            this.pnlCadCliente.Controls.Add(this.lblSenha);
            this.pnlCadCliente.Controls.Add(this.lblNomeCliente);
            this.pnlCadCliente.Controls.Add(this.txtCodigo);
            this.pnlCadCliente.Controls.Add(this.lblCodigo);
            this.pnlCadCliente.Controls.Add(this.btnLimpar);
            this.pnlCadCliente.Controls.Add(this.btnSalvar);
            this.pnlCadCliente.Controls.Add(this.lblCadCliente);
            this.pnlCadCliente.Location = new System.Drawing.Point(180, 84);
            this.pnlCadCliente.Name = "pnlCadCliente";
            this.pnlCadCliente.Size = new System.Drawing.Size(1000, 600);
            this.pnlCadCliente.TabIndex = 3;
            // 
            // btnFoto
            // 
            this.btnFoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(52)))), ((int)(((byte)(96)))));
            this.btnFoto.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFoto.FlatAppearance.BorderSize = 2;
            this.btnFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFoto.Font = new System.Drawing.Font("Britannic Bold", 14F);
            this.btnFoto.ForeColor = System.Drawing.Color.White;
            this.btnFoto.Location = new System.Drawing.Point(959, 502);
            this.btnFoto.Name = "btnFoto";
            this.btnFoto.Size = new System.Drawing.Size(25, 32);
            this.btnFoto.TabIndex = 7;
            this.btnFoto.Text = "+";
            this.btnFoto.UseVisualStyleBackColor = false;
            this.btnFoto.Click += new System.EventHandler(this.btnFoto_Click);
            // 
            // lblFoto
            // 
            this.lblFoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.lblFoto.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.lblFoto.ForeColor = System.Drawing.Color.White;
            this.lblFoto.Location = new System.Drawing.Point(768, 334);
            this.lblFoto.Name = "lblFoto";
            this.lblFoto.Size = new System.Drawing.Size(19, 200);
            this.lblFoto.TabIndex = 21;
            this.lblFoto.Text = "FOTO";
            this.lblFoto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picFoto
            // 
            this.picFoto.Image = global::kibelezaPMS.Properties.Resources.semimagem;
            this.picFoto.Location = new System.Drawing.Point(784, 334);
            this.picFoto.Name = "picFoto";
            this.picFoto.Size = new System.Drawing.Size(200, 200);
            this.picFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFoto.TabIndex = 20;
            this.picFoto.TabStop = false;
            // 
            // pnlTelefone
            // 
            this.pnlTelefone.BackColor = System.Drawing.Color.Transparent;
            this.pnlTelefone.BackgroundImage = global::kibelezaPMS.Properties.Resources.fonecliente;
            this.pnlTelefone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlTelefone.Controls.Add(this.dgvFoneCliente);
            this.pnlTelefone.Controls.Add(this.btnCadastrar);
            this.pnlTelefone.Controls.Add(this.btnAlterar);
            this.pnlTelefone.Controls.Add(this.btnExcluir);
            this.pnlTelefone.Location = new System.Drawing.Point(184, 271);
            this.pnlTelefone.Name = "pnlTelefone";
            this.pnlTelefone.Size = new System.Drawing.Size(569, 263);
            this.pnlTelefone.TabIndex = 19;
            // 
            // dgvFoneCliente
            // 
            this.dgvFoneCliente.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.dgvFoneCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFoneCliente.Location = new System.Drawing.Point(107, 13);
            this.dgvFoneCliente.Name = "dgvFoneCliente";
            this.dgvFoneCliente.Size = new System.Drawing.Size(448, 192);
            this.dgvFoneCliente.TabIndex = 0;
            this.dgvFoneCliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFoneCliente_CellClick);
            this.dgvFoneCliente.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvFoneCliente_ColumnHeaderMouseClick);
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
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
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
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "ATIVO",
            "INATIVO"});
            this.cmbStatus.Location = new System.Drawing.Point(390, 231);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(222, 21);
            this.cmbStatus.TabIndex = 6;
            this.cmbStatus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbStatus_KeyPress);
            // 
            // mkdDataCad
            // 
            this.mkdDataCad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.mkdDataCad.Location = new System.Drawing.Point(658, 231);
            this.mkdDataCad.Mask = "00/00/0000";
            this.mkdDataCad.Name = "mkdDataCad";
            this.mkdDataCad.Size = new System.Drawing.Size(162, 23);
            this.mkdDataCad.TabIndex = 16;
            this.mkdDataCad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEmail
            // 
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtEmail.Location = new System.Drawing.Point(184, 168);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(800, 23);
            this.txtEmail.TabIndex = 4;
            this.txtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmail_KeyPress);
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtSenha.Location = new System.Drawing.Point(184, 231);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(161, 23);
            this.txtSenha.TabIndex = 5;
            this.txtSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSenha_KeyPress);
            // 
            // lblDataCad
            // 
            this.lblDataCad.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDataCad.BackColor = System.Drawing.Color.Transparent;
            this.lblDataCad.Font = new System.Drawing.Font("Britannic Bold", 14F);
            this.lblDataCad.Location = new System.Drawing.Point(655, 206);
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
            this.lblStatus.Location = new System.Drawing.Point(387, 206);
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
            this.lblEmail.Location = new System.Drawing.Point(184, 143);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(165, 22);
            this.lblEmail.TabIndex = 13;
            this.lblEmail.Text = "E-mail:";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtNomeCliente.Location = new System.Drawing.Point(322, 109);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(663, 23);
            this.txtNomeCliente.TabIndex = 0;
            this.txtNomeCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomeCliente_KeyPress);
            // 
            // lblSenha
            // 
            this.lblSenha.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSenha.BackColor = System.Drawing.Color.Transparent;
            this.lblSenha.Font = new System.Drawing.Font("Britannic Bold", 14F);
            this.lblSenha.Location = new System.Drawing.Point(180, 206);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(165, 22);
            this.lblSenha.TabIndex = 13;
            this.lblSenha.Text = "Senha:";
            this.lblSenha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNomeCliente
            // 
            this.lblNomeCliente.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblNomeCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblNomeCliente.Font = new System.Drawing.Font("Britannic Bold", 14F);
            this.lblNomeCliente.Location = new System.Drawing.Point(318, 84);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(165, 22);
            this.lblNomeCliente.TabIndex = 13;
            this.lblNomeCliente.Text = "Nome do Cliente:";
            this.lblNomeCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.btnSalvar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnSalvar_KeyPress);
            // 
            // lblCadCliente
            // 
            this.lblCadCliente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCadCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.lblCadCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCadCliente.Font = new System.Drawing.Font("Britannic Bold", 16F);
            this.lblCadCliente.ForeColor = System.Drawing.Color.White;
            this.lblCadCliente.Location = new System.Drawing.Point(164, 0);
            this.lblCadCliente.Name = "lblCadCliente";
            this.lblCadCliente.Size = new System.Drawing.Size(836, 72);
            this.lblCadCliente.TabIndex = 12;
            this.lblCadCliente.Text = "CADASTRO DE CLIENTE";
            this.lblCadCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmCadCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::kibelezaPMS.Properties.Resources.fundo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1360, 768);
            this.Controls.Add(this.pnlCadCliente);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCadCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Cliente";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCadCliente_Load);
            this.pnlCadCliente.ResumeLayout(false);
            this.pnlCadCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).EndInit();
            this.pnlTelefone.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoneCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSair)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCadCliente;
        private System.Windows.Forms.Button btnFoto;
        private System.Windows.Forms.Label lblFoto;
        private System.Windows.Forms.PictureBox picFoto;
        private System.Windows.Forms.Panel pnlTelefone;
        private System.Windows.Forms.DataGridView dgvFoneCliente;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.PictureBox picSair;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.MaskedTextBox mkdDataCad;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblDataCad;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblNomeCliente;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblCadCliente;
    }
}