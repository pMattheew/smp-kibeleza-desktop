namespace kibelezaPMS
{
    partial class frmFoneEmpresa
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
            this.pnlFoneEmpresa = new System.Windows.Forms.Panel();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbOperadora = new System.Windows.Forms.ComboBox();
            this.lblOperadora = new System.Windows.Forms.Label();
            this.mkdTelefone = new System.Windows.Forms.MaskedTextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.cmbNomeEmpresa = new System.Windows.Forms.ComboBox();
            this.lblNomeEmpresa = new System.Windows.Forms.Label();
            this.picSair = new System.Windows.Forms.PictureBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.pnlFoneEmpresa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSair)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFoneEmpresa
            // 
            this.pnlFoneEmpresa.BackgroundImage = global::kibelezaPMS.Properties.Resources.fonemepresa;
            this.pnlFoneEmpresa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlFoneEmpresa.Controls.Add(this.txtDescricao);
            this.pnlFoneEmpresa.Controls.Add(this.label1);
            this.pnlFoneEmpresa.Controls.Add(this.cmbOperadora);
            this.pnlFoneEmpresa.Controls.Add(this.lblOperadora);
            this.pnlFoneEmpresa.Controls.Add(this.mkdTelefone);
            this.pnlFoneEmpresa.Controls.Add(this.lblTelefone);
            this.pnlFoneEmpresa.Controls.Add(this.cmbNomeEmpresa);
            this.pnlFoneEmpresa.Controls.Add(this.lblNomeEmpresa);
            this.pnlFoneEmpresa.Controls.Add(this.picSair);
            this.pnlFoneEmpresa.Controls.Add(this.txtCodigo);
            this.pnlFoneEmpresa.Controls.Add(this.lblCodigo);
            this.pnlFoneEmpresa.Controls.Add(this.btnLimpar);
            this.pnlFoneEmpresa.Controls.Add(this.btnSalvar);
            this.pnlFoneEmpresa.Location = new System.Drawing.Point(172, 64);
            this.pnlFoneEmpresa.Name = "pnlFoneEmpresa";
            this.pnlFoneEmpresa.Size = new System.Drawing.Size(650, 400);
            this.pnlFoneEmpresa.TabIndex = 3;
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
            // cmbNomeEmpresa
            // 
            this.cmbNomeEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNomeEmpresa.FormattingEnabled = true;
            this.cmbNomeEmpresa.Location = new System.Drawing.Point(222, 91);
            this.cmbNomeEmpresa.Name = "cmbNomeEmpresa";
            this.cmbNomeEmpresa.Size = new System.Drawing.Size(305, 21);
            this.cmbNomeEmpresa.TabIndex = 21;
            // 
            // lblNomeEmpresa
            // 
            this.lblNomeEmpresa.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblNomeEmpresa.BackColor = System.Drawing.Color.Transparent;
            this.lblNomeEmpresa.Font = new System.Drawing.Font("Britannic Bold", 14F);
            this.lblNomeEmpresa.Location = new System.Drawing.Point(222, 66);
            this.lblNomeEmpresa.Name = "lblNomeEmpresa";
            this.lblNomeEmpresa.Size = new System.Drawing.Size(165, 22);
            this.lblNomeEmpresa.TabIndex = 19;
            this.lblNomeEmpresa.Text = "Nome da Empresa:";
            this.lblNomeEmpresa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // frmFoneEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::kibelezaPMS.Properties.Resources.fundo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1344, 729);
            this.Controls.Add(this.pnlFoneEmpresa);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFoneEmpresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Telefone da empresa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmFoneEmpresa_Load);
            this.pnlFoneEmpresa.ResumeLayout(false);
            this.pnlFoneEmpresa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSair)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFoneEmpresa;
        private System.Windows.Forms.PictureBox picSair;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblNomeEmpresa;
        private System.Windows.Forms.ComboBox cmbNomeEmpresa;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbOperadora;
        private System.Windows.Forms.Label lblOperadora;
        private System.Windows.Forms.MaskedTextBox mkdTelefone;
        private System.Windows.Forms.Label lblTelefone;
    }
}