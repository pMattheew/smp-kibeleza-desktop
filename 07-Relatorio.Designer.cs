namespace kibelezaPMS
{
    partial class frmRelatorio
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
            this.pnlRelatorio = new System.Windows.Forms.Panel();
            this.dgvRelatorio = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radFuncionario = new System.Windows.Forms.RadioButton();
            this.radEmpresa = new System.Windows.Forms.RadioButton();
            this.radCliente = new System.Windows.Forms.RadioButton();
            this.lblNome = new System.Windows.Forms.Label();
            this.picSair = new System.Windows.Forms.PictureBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.picAtualizar = new System.Windows.Forms.PictureBox();
            this.pnlRelatorio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelatorio)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAtualizar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlRelatorio
            // 
            this.pnlRelatorio.BackgroundImage = global::kibelezaPMS.Properties.Resources.relatorio;
            this.pnlRelatorio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlRelatorio.Controls.Add(this.btnEntrar);
            this.pnlRelatorio.Controls.Add(this.dgvRelatorio);
            this.pnlRelatorio.Controls.Add(this.picAtualizar);
            this.pnlRelatorio.Controls.Add(this.picSair);
            this.pnlRelatorio.Controls.Add(this.panel2);
            this.pnlRelatorio.Controls.Add(this.panel1);
            this.pnlRelatorio.Location = new System.Drawing.Point(180, 84);
            this.pnlRelatorio.Name = "pnlRelatorio";
            this.pnlRelatorio.Size = new System.Drawing.Size(1000, 600);
            this.pnlRelatorio.TabIndex = 3;
            // 
            // dgvRelatorio
            // 
            this.dgvRelatorio.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.dgvRelatorio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRelatorio.Location = new System.Drawing.Point(187, 109);
            this.dgvRelatorio.Name = "dgvRelatorio";
            this.dgvRelatorio.Size = new System.Drawing.Size(798, 474);
            this.dgvRelatorio.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(52)))), ((int)(((byte)(96)))));
            this.panel2.Controls.Add(this.radioButton1);
            this.panel2.Controls.Add(this.radioButton2);
            this.panel2.Controls.Add(this.radioButton3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(539, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(314, 70);
            this.panel2.TabIndex = 5;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.radioButton1.ForeColor = System.Drawing.Color.White;
            this.radioButton1.Location = new System.Drawing.Point(203, 37);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(97, 21);
            this.radioButton1.TabIndex = 10;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "TELEFONE";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.radioButton2.ForeColor = System.Drawing.Color.White;
            this.radioButton2.Location = new System.Drawing.Point(103, 37);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(82, 21);
            this.radioButton2.TabIndex = 10;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "INATIVO";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.radioButton3.ForeColor = System.Drawing.Color.White;
            this.radioButton3.Location = new System.Drawing.Point(18, 37);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(67, 21);
            this.radioButton3.TabIndex = 10;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "ATIVO";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(131, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "FILTRO";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(52)))), ((int)(((byte)(96)))));
            this.panel1.Controls.Add(this.radFuncionario);
            this.panel1.Controls.Add(this.radEmpresa);
            this.panel1.Controls.Add(this.radCliente);
            this.panel1.Controls.Add(this.lblNome);
            this.panel1.Location = new System.Drawing.Point(187, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(336, 70);
            this.panel1.TabIndex = 5;
            // 
            // radFuncionario
            // 
            this.radFuncionario.AutoSize = true;
            this.radFuncionario.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.radFuncionario.ForeColor = System.Drawing.Color.White;
            this.radFuncionario.Location = new System.Drawing.Point(203, 37);
            this.radFuncionario.Name = "radFuncionario";
            this.radFuncionario.Size = new System.Drawing.Size(123, 21);
            this.radFuncionario.TabIndex = 10;
            this.radFuncionario.TabStop = true;
            this.radFuncionario.Text = "FUNCIONÁRIO";
            this.radFuncionario.UseVisualStyleBackColor = true;
            // 
            // radEmpresa
            // 
            this.radEmpresa.AutoSize = true;
            this.radEmpresa.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.radEmpresa.ForeColor = System.Drawing.Color.White;
            this.radEmpresa.Location = new System.Drawing.Point(106, 37);
            this.radEmpresa.Name = "radEmpresa";
            this.radEmpresa.Size = new System.Drawing.Size(94, 21);
            this.radEmpresa.TabIndex = 10;
            this.radEmpresa.TabStop = true;
            this.radEmpresa.Text = "EMPRESA";
            this.radEmpresa.UseVisualStyleBackColor = true;
            // 
            // radCliente
            // 
            this.radCliente.AutoSize = true;
            this.radCliente.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.radCliente.ForeColor = System.Drawing.Color.White;
            this.radCliente.Location = new System.Drawing.Point(18, 37);
            this.radCliente.Name = "radCliente";
            this.radCliente.Size = new System.Drawing.Size(85, 21);
            this.radCliente.TabIndex = 10;
            this.radCliente.TabStop = true;
            this.radCliente.Text = "CLIENTE";
            this.radCliente.UseVisualStyleBackColor = true;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.lblNome.ForeColor = System.Drawing.Color.White;
            this.lblNome.Location = new System.Drawing.Point(142, 11);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(61, 17);
            this.lblNome.TabIndex = 9;
            this.lblNome.Text = "TABELA";
            // 
            // picSair
            // 
            this.picSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picSair.BackColor = System.Drawing.Color.Transparent;
            this.picSair.Image = global::kibelezaPMS.Properties.Resources.fechar;
            this.picSair.Location = new System.Drawing.Point(952, 21);
            this.picSair.Name = "picSair";
            this.picSair.Size = new System.Drawing.Size(33, 31);
            this.picSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSair.TabIndex = 4;
            this.picSair.TabStop = false;
            this.picSair.Click += new System.EventHandler(this.picSair_Click);
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(52)))), ((int)(((byte)(96)))));
            this.btnEntrar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEntrar.FlatAppearance.BorderSize = 2;
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrar.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.btnEntrar.ForeColor = System.Drawing.Color.White;
            this.btnEntrar.Location = new System.Drawing.Point(859, 58);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(126, 33);
            this.btnEntrar.TabIndex = 7;
            this.btnEntrar.Text = "SALVAR";
            this.btnEntrar.UseVisualStyleBackColor = false;
            // 
            // picAtualizar
            // 
            this.picAtualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picAtualizar.BackColor = System.Drawing.Color.Transparent;
            this.picAtualizar.Image = global::kibelezaPMS.Properties.Resources.refresh;
            this.picAtualizar.Location = new System.Drawing.Point(913, 21);
            this.picAtualizar.Name = "picAtualizar";
            this.picAtualizar.Size = new System.Drawing.Size(33, 31);
            this.picAtualizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAtualizar.TabIndex = 4;
            this.picAtualizar.TabStop = false;
            // 
            // frmRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::kibelezaPMS.Properties.Resources.fundo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1360, 768);
            this.Controls.Add(this.pnlRelatorio);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRelatorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatorio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmRelatorio_Load);
            this.pnlRelatorio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelatorio)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAtualizar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlRelatorio;
        private System.Windows.Forms.PictureBox picSair;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.RadioButton radFuncionario;
        private System.Windows.Forms.RadioButton radEmpresa;
        private System.Windows.Forms.RadioButton radCliente;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvRelatorio;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.PictureBox picAtualizar;
    }
}