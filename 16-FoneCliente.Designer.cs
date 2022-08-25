namespace kibelezaPMS
{
    partial class frmFoneCliente
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
            this.pnlFoneCliente = new System.Windows.Forms.Panel();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbOperadora = new System.Windows.Forms.ComboBox();
            this.lblOperadora = new System.Windows.Forms.Label();
            this.mkdTelefone = new System.Windows.Forms.MaskedTextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.cmbNomeCliente = new System.Windows.Forms.ComboBox();
            this.lblNomeCliente = new System.Windows.Forms.Label();
            this.picSair = new System.Windows.Forms.PictureBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.pnlFoneCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSair)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFoneCliente
            // 
            this.pnlFoneCliente.BackgroundImage = global::kibelezaPMS.Properties.Resources.fonecliente;
            this.pnlFoneCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlFoneCliente.Controls.Add(this.txtDescricao);
            this.pnlFoneCliente.Controls.Add(this.label1);
            this.pnlFoneCliente.Controls.Add(this.cmbOperadora);
            this.pnlFoneCliente.Controls.Add(this.lblOperadora);
            this.pnlFoneCliente.Controls.Add(this.mkdTelefone);
            this.pnlFoneCliente.Controls.Add(this.lblTelefone);
            this.pnlFoneCliente.Controls.Add(this.cmbNomeCliente);
            this.pnlFoneCliente.Controls.Add(this.lblNomeCliente);
            this.pnlFoneCliente.Controls.Add(this.picSair);
            this.pnlFoneCliente.Controls.Add(this.txtCodigo);
            this.pnlFoneCliente.Controls.Add(this.lblCodigo);
            this.pnlFoneCliente.Controls.Add(this.btnLimpar);
            this.pnlFoneCliente.Controls.Add(this.btnSalvar);
            this.pnlFoneCliente.Location = new System.Drawing.Point(347, 164);
            this.pnlFoneCliente.Name = "pnlFoneCliente";
            this.pnlFoneCliente.Size = new System.Drawing.Size(650, 400);
            this.pnlFoneCliente.TabIndex = 4;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtDescricao.Location = new System.Drawing.Point(222, 240);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(305, 23);
            this.txtDescricao.TabIndex = 4;
            this.txtDescricao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescricao_KeyPress);
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
            this.cmbOperadora.Items.AddRange(new object[] {
            "OI",
            "TIM",
            "VIVO",
            "CLARO",
            "NEXTEL"});
            this.cmbOperadora.Location = new System.Drawing.Point(222, 191);
            this.cmbOperadora.Name = "cmbOperadora";
            this.cmbOperadora.Size = new System.Drawing.Size(305, 21);
            this.cmbOperadora.TabIndex = 3;
            this.cmbOperadora.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbOperadora_KeyPress);
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
            this.mkdTelefone.TabIndex = 2;
            this.mkdTelefone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mkdTelefone_KeyPress);
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
            // cmbNomeCliente
            // 
            this.cmbNomeCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNomeCliente.FormattingEnabled = true;
            this.cmbNomeCliente.Location = new System.Drawing.Point(222, 91);
            this.cmbNomeCliente.Name = "cmbNomeCliente";
            this.cmbNomeCliente.Size = new System.Drawing.Size(305, 21);
            this.cmbNomeCliente.TabIndex = 1;
            this.cmbNomeCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbNomeCliente_KeyPress);
            // 
            // lblNomeCliente
            // 
            this.lblNomeCliente.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblNomeCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblNomeCliente.Font = new System.Drawing.Font("Britannic Bold", 14F);
            this.lblNomeCliente.Location = new System.Drawing.Point(222, 66);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(165, 22);
            this.lblNomeCliente.TabIndex = 19;
            this.lblNomeCliente.Text = "Nome do Cliente:";
            this.lblNomeCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.btnSalvar.TabIndex = 5;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // frmFoneCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::kibelezaPMS.Properties.Resources.fundo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1344, 729);
            this.Controls.Add(this.pnlFoneCliente);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFoneCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Telefone do cliente";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmFoneCliente_Load);
            this.pnlFoneCliente.ResumeLayout(false);
            this.pnlFoneCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSair)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFoneCliente;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbOperadora;
        private System.Windows.Forms.Label lblOperadora;
        private System.Windows.Forms.MaskedTextBox mkdTelefone;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.ComboBox cmbNomeCliente;
        private System.Windows.Forms.Label lblNomeCliente;
        private System.Windows.Forms.PictureBox picSair;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSalvar;
    }
}