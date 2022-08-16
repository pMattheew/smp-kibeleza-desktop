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
    }
}
