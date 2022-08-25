using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kibelezaPMS
{
    public static class banco
    {
    //  public static string db = "SERVER=ipServidor;USER=nome_usuario;PASSWORD=senha;DATABASE=kibelezati14;SSL MODE=None";
        public static string db = "SERVER=localhost;USER=root;DATABASE=kibelezati14;";

    //  variável usada para controlar o db via a biblioteca MySql
        public static MySqlConnection conexao;

    //  método para abrir a conexão
        public static void Conectar()
        {
            try
            {
                conexao = new MySqlConnection(db);
                conexao.Open();
            }
            catch
            {
                MessageBox.Show("Erro ao conectar com o banco", "ERRO");
            }
        }

    //  método para fechar a conexão
        public static void Desconectar()
        {
            try
            {
            conexao = new MySqlConnection();
            conexao.Close();
            }
            catch
            {
                MessageBox.Show("Erro ao desconectar com o banco", "ERRO");
            }
        }

        // método para puxar dados do banco via comandos
        private void CarregarDados(string query, string DataGridReceptor)
        {   
            try
            {
                banco.Conectar();
                
                MySqlCommand cmd = new MySqlCommand(query, banco.conexao);  // gera a query

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);  // adapta os dados da query

                DataTable dt = new DataTable(); // cria uma nova instância de tabela de dados

                da.Fill(dt); // enche a DataTable com os dados adaptados do banco de dados


                [DataGridReceptor].DataSource = dt;
                [DataGridReceptor].ClearSelection();

                banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao fazer consulta: \n\n" + ex.Message);
            }
        }

        private void ExcluirLinha(string tabela, string coluna, string linha) 
        {   // recebe a tabela que será feita o delete, a coluna (geralmente idAlgumaCoisa) e a linha (alvo da deleção).
            // deverá receber a coluna correspondente do banco, e a variável correspondente do sistema (ex idEmpresa=@codEmpresa)
            // OBS: por conta do sistema já estar montado, o nome da tabela deve ser o mesmo da DataGridView APÓS "dgv", ver linha 92.
            try
            {
                banco.Conectar();
                                            //  empresa............idEmpresa........codEmpresa
                string query = "DELETE FROM " + tabela + " WHERE " + coluna + "=@" + linha;

                MySqlCommand cmd = new MySqlCommand(query, banco.conexao);

                cmd.Parameters.AddWithValue("@"+linha, Variaveis.[linha]); // declara a variável do SQL com o valor armazenado no objeto Variaveis do sistema (codEmpresa).
                
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable(); 
                da.Fill(dt);

                // concatena a inicial maiúscula com o resto da string (dgv + E + mpresa = dgvEmpresa)
                dataGridView = ["dgv" + char.ToUpper(tabela[0]) + tabela.Substring(1)];

                dataGridView.DataSource = dt;
                dataGridView.ClearSelection()

                banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir campo: \n\n" + ex.Message)
            }
        }

    /*
        banco.ExcluirLinha("empresa", "idEmpresa", "codEmpresa")
    */
        private void InserirLinha(string tabela /*recebera objeto inteligente com campo: valor*/)
        {
            try
            {
                banco.Conectar();

                string query = "INSERT INTO " + tabela;

                banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar nova linha: \n\n" + ex.Message)
            }
        }

    }
}
