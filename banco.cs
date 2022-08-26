using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
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
        public static void CarregarDados(string tabelaView, DataGridView dgv)
        {   
            try
            {
                Conectar();

                string query = "SELECT * FROM " + tabelaView;
                
                MySqlCommand cmd = new MySqlCommand(query, conexao);  // gera a query

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);  // adapta os dados da query

                DataTable dt = new DataTable(); // cria uma nova instância de tabela de dados

                da.Fill(dt); // enche a DataTable com os dados adaptados do banco de dados


                dgv.DataSource = dt;
                dgv.ClearSelection();

                Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao fazer consulta: \n\n" + ex);
            }
        }

        public static void ExcluirLinha(string tabela, string coluna, int linha) 
        {   // recebe a tabela que será feita o delete, a coluna (geralmente idAlgumaCoisa) e a linha (alvo da deleção).
            // deverá receber a coluna correspondente do banco, e a variável correspondente do sistema (ex idEmpresa=@codEmpresa)
            // OBS: por conta do sistema já estar montado, o nome da tabela deve ser o mesmo da DataGridView APÓS "dgv"; as linhas que terminam com # podem ser excluidas para tirar esta feature, ver linha 95.
            try
            {
                Conectar();
                                            //  empresa............idEmpresa........codEmpresa
                string query = "DELETE FROM " + tabela + " WHERE " + coluna + "=@" + linha.ToString();

                MySqlCommand cmd = new MySqlCommand(query, conexao);

                cmd.Parameters.AddWithValue("@"+linha.ToString(), linha); // declara a variável do SQL com o valor armazenado no objeto Variaveis do sistema (codEmpresa).
                
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable(); 
                da.Fill(dt);

                // concatena a inicial maiúscula com o resto da string (dgv + E + mpresa = dgvEmpresa) #
                string nomeDgv = "dgv" + char.ToUpper(tabela[0]) + tabela.Substring(1); //#

                DataGridView dataGridView = new DataGridView(); 

                dataGridView.Name = nomeDgv; 

                dataGridView.DataSource = dt;
                dataGridView.ClearSelection();

                Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir campo: \n\n" + ex.Message);
            }
        }

    /*
        banco.ExcluirLinha("empresa", "idEmpresa", Variaveis.codEmpresa)
    */
        public static void InserirLinha(string tabela /*recebera objeto inteligente com campo: valor*/)
        {
            try
            {
                Conectar();

                string query = "INSERT INTO " + tabela;

                Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar nova linha: \n\n" + ex.Message);
            }
        }

    }
}
