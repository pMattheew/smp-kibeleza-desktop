using iTextSharp.text;
using iTextSharp.text.pdf;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kibelezaPMS
{
    public partial class frmRelatorio : Form
    {
        public frmRelatorio()
        {
            InitializeComponent();
        }
        private void CarregarDados(string select)
        {
            try
            {
                banco.Conectar();
                string selecionar = select;
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvRelatorio.DataSource = dt;
                   
                dgvRelatorio.ClearSelection();

                banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao selecionar o relatório. \n\n", erro.Message);
            }
        }

        private void picSair_Click(object sender, EventArgs e)
        {
            new frmMenu().Show();
            Close();
        }

        private void frmRelatorio_Load(object sender, EventArgs e)
        {
            pnlRelatorio.Location = new Point(this.Width / 2 - pnlRelatorio.Width / 2, this.Height / 2 - pnlRelatorio.Height / 2);
        }

        private void picAtualizar_Click(object sender, EventArgs e)
        {
            if (radCliente.Checked)
            {
                if (radAtivo.Checked)
                {
                    CarregarDados("SELECT * FROM `clienteativo`");
                }
                else if (radInativo.Checked)
                {
                    // CarregarClienteInativo();
                    CarregarDados("SELECT * FROM `clienteinativo`");
                }
                else if (radTelefone.Checked)
                {
                    // CarregarClienteTelefone();
                    CarregarDados("SELECT * FROM `clientetelefone`");
                }
            }
            else if (radFuncionario.Checked)
            {
                if (radAtivo.Checked)
                {
                    // CarregarFuncionarioAtivo();
                    CarregarDados("SELECT * FROM `funcionarioativo`");
                }
                else if (radInativo.Checked)
                {
                    // CarregarFuncionarioInativo();
                    CarregarDados("SELECT * FROM `funcionarioinativo`");
                }
                else if (radTelefone.Checked)
                {
                    // CarregarFuncionarioTelefone();
                    CarregarDados("SELECT * FROM `funcionariotelefone`");
                }
            }
            else if (radEmpresa.Checked)
            {
                if (radAtivo.Checked)
                {
                    // CarregarEmpresaAtivo();
                    CarregarDados("SELECT * FROM `empresaativa`");
                }
                else if (radInativo.Checked)
                {
                    // CarregarEmpresaInativo();
                    CarregarDados("SELECT * FROM `empresainativo`");
                }
                else if (radTelefone.Checked)
                {
                    // CarregarEmpresa.Telefone();
                    CarregarDados("SELECT * FROM `empresatelefone`");
                }
            }

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (dgvRelatorio.Rows.Count > 0)
            {
                SaveFileDialog salvar = new SaveFileDialog();
                salvar.Filter = "PDF (*.pdf)|*.pdf";
                salvar.FileName = "relatorio.pdf";
                bool fileError = false;

                if (salvar.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(salvar.FileName))
                    {
                        try
                        {
                            File.Delete(salvar.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("Não foi possível gravar os dados. \n" + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            PdfPTable pdfTable = new PdfPTable(dgvRelatorio.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn column in dgvRelatorio.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                pdfTable.AddCell(cell);
                            }

                            foreach (DataGridViewRow row in dgvRelatorio.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    pdfTable.AddCell(cell.Value.ToString());
                                }
                            }

                            using (FileStream stream = new FileStream(salvar.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                            }

                            MessageBox.Show("Dados exportados com sucesso!", "INFO");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Erro: \n" + ex.Message);

                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Exportação não salva!", "INFO");
            }
        }
    }
}
