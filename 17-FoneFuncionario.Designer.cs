namespace kibelezaPMS
{
    partial class frmFoneFuncionario
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
            this.pnlFoneFuncionario = new System.Windows.Forms.Panel();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbOperadora = new System.Windows.Forms.ComboBox();
            this.lblOperadora = new System.Windows.Forms.Label();
            this.mkdTelefone = new System.Windows.Forms.MaskedTextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.cmbNomeFuncionario = new System.Windows.Forms.ComboBox();
            this.lblNomeFuncionario = new System.Windows.Forms.Label();
            this.picSair = new System.Windows.Forms.PictureBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.pnlFoneFuncionario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSair)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFoneFuncionario
            // 
            this.pnlFoneFuncionario.BackgroundImage = global::kibelezaPMS.Properties.Resources.fonefuncionario;
            this.pnlFoneFuncionario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlFoneFuncionario.Controls.Add(this.txtDescricao);
            this.pnlFoneFuncionario.Controls.Add(this.label1);
            this.pnlFoneFuncionario.Controls.Add(this.cmbOperadora);
            this.pnlFoneFuncionario.Controls.Add(this.lblOperadora);
            this.pnlFoneFuncionario.Controls.Add(this.mkdTelefone);
            this.pnlFoneFuncionario.Controls.Add(this.lblTelefone);
            this.pnlFoneFuncionario.Controls.Add(this.cmbNomeFuncionario);
            this.pnlFoneFuncionario.Controls.Add(this.lblNomeFuncionario);
            this.pnlFoneFuncionario.Controls.Add(this.picSair);
            this.pnlFoneFuncionario.Controls.Add(this.txtCodigo);
            this.pnlFoneFuncionario.Controls.Add(this.lblCodigo);
            this.pnlFoneFuncionario.Controls.Add(this.btnLimpar);
            this.pnlFoneFuncionario.Controls.Add(this.btnSalvar);
            this.pnlFoneFuncionario.Location = new System.Drawing.Point(355, 184);
            this.pnlFoneFuncionario.Name = "pnlFoneFuncionario";
            this.pnlFoneFuncionario.Size = new System.Drawing.Size(650, 400);
            this.pnlFoneFuncionario.TabIndex = 5;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtDescricao.Location = new System.Drawing.Point(222, 240);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(305, 23);
            this.txtDescricao.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 14F);
            this.label1.Location = new System.Drawing.Point(222, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 22);
            this.label1.TabIndex = 26;
            this.label1.Text = "Descrição:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbOperadora
            // 
            this.cmbOperadora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOperadora.FormattingEnabled = true;
            this.cmbOperadora.Location = new System.Drawing.Point(222, 191);
            this.cmbOperadora.Name = "cmbOperadora";
            this.cmbOperadora.Size = new System.Drawing.Size(305, 21);
            this.cmbOperadora.TabIndex = 25;
            // 
            // lblOperadora
            // 
            this.lblOperadora.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblOperadora.BackColor = System.Drawing.Color.Transparent;
            this.lblOperadora.Font = new System.Drawing.Font("Britannic Bold", 14F);
            this.lblOperadora.Location = new System.Drawing.Point(222, 166);
            this.lblOperadora.Name = "lblOperadora";
            this.lblOperadora.Size = new System.Drawing.Size(165, 22);
            this.lblOperadora.TabIndex = 24;
            this.lblOperadora.Text = "Operadora:";
            this.lblOperadora.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mkdTelefone
            // 
            this.mkdTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.mkdTelefone.Location = new System.Drawing.Point(222, 140);
            this.mkdTelefone.Mask = "(00)00000-0000";
            this.mkdTelefone.Name = "mkdTelefone";
            this.mkdTelefone.Size = new System.Drawing.Size(305, 23);
            this.mkdTelefone.TabIndex = 23;
            // 
            // lblTelefone
            // 
            this.lblTelefone.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTelefone.BackColor = System.Drawing.Color.Transparent;
            this.lblTelefone.Font = new System.Drawing.Font("Britannic Bold", 14F);
            this.lblTelefone.Location = new System.Drawing.Point(222, 115);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(165, 22);
            this.lblTelefone.TabIndex = 22;
            this.lblTelefone.Text = "Telefone:";
            this.lblTelefone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbNomeFuncionario
            // 
            this.cmbNomeFuncionario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNomeFuncionario.FormattingEnabled = true;
            this.cmbNomeFuncionario.Location = new System.Drawing.Point(222, 91);
            this.cmbNomeFuncionario.Name = "cmbNomeFuncionario";
            this.cmbNomeFuncionario.Size = new System.Drawing.Size(305, 21);
            this.cmbNomeFuncionario.TabIndex = 21;
            // 
            // lblNomeFuncionario
            // 
            this.lblNomeFuncionario.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblNomeFuncionario.BackColor = System.Drawing.Color.Transparent;
            this.lblNomeFuncionario.Font = new System.Drawing.Font("Britannic Bold", 14F);
            this.lblNomeFuncionario.Location = new System.Drawing.Point(222, 66);
            this.lblNomeFuncionario.Name = "lblNomeFuncionario";
            this.lblNomeFuncionario.Size = new System.Drawing.Size(196, 22);
            this.lblNomeFuncionario.TabIndex = 19;
            this.lblNomeFuncionario.Text = "Nome do Funcionário:";
            this.lblNomeFuncionario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picSair
            // 
            this.picSair.BackColor = System.Drawing.Color.Transparent;
            this.picSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picSair.Image = global::kibelezaPMS.Properties.Resources.fechar;
            this.picSair.Location = new System.Drawing.Point(587, 3);
            this.picSair.Name = "picSair";
            this.picSair.Size = new System.Drawing.Size(60, 60);
            this.picSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSair.TabIndex = 18;
            this.picSair.TabStop = false;
            this.picSair.Click += new System.EventHandler(this.picSair_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtCodigo.Location = new System.Drawing.Point(222, 40);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 23);
            this.txtCodigo.TabIndex = 14;
            // 
            // lblCodigo
            // 
            this.lblCodigo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCodigo.BackColor = System.Drawing.Color.Transparent;
            this.lblCodigo.Font = new System.Drawing.Font("Britannic Bold", 14F);
            this.lblCodigo.Location = new System.Drawing.Point(222, 15);
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
            this.btnLimpar.Location = new System.Drawing.Point(382, 350);
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
            this.btnSalvar.Location = new System.Drawing.Point(170, 350);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(193, 35);
            this.btnSalvar.TabIndex = 11;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = false;
            // 
            // frmFoneFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::kibelezaPMS.Properties.Resources.fundo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1360, 768);
            this.Controls.Add(this.pnlFoneFuncionario);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFoneFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Telefone do funcionario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmFoneFuncionario_Load);
            this.pnlFoneFuncionario.ResumeLayout(false);
            this.pnlFoneFuncionario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSair)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFoneFuncionario;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbOperadora;
        private System.Windows.Forms.Label lblOperadora;
        private System.Windows.Forms.MaskedTextBox mkdTelefone;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.ComboBox cmbNomeFuncionario;
        private System.Windows.Forms.Label lblNomeFuncionario;
        private System.Windows.Forms.PictureBox picSair;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSalvar;
    }
}