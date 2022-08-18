using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kibelezaPMS
{
    public static class Variaveis
    {
        // geral
        public static string funcao;
        public static int linhaSelecionada;

        // login 
        public static string usuario, senha, nivel;

        // empresa
        public static int codEmpresa;
        public static string nomeEmpresa, cnpjCpf, razaoSocial, emailEmpresa, statusEmpresa;
        public static DateTime dataCadEmpresa, horarioAtendEmpresa;

        // cliente
        public static int codCliente;
        public static string nomeCliente, emailCliente, senhaCliente, statusCliente, fotoCliente, atFotoCliente;
        public static DateTime dataCadCliente;

        // funcionario
        public static int codFuncionario;
        public static string nomeFuncionario, emailFuncionario, senhaFuncionario, statusFuncionario, nivelFuncionario, empresaFuncionario;
        public static DateTime dataCadFuncionario, horarioAtendFuncionario;

        // reserva
        public static string obsReserva, statusReserva, funcionarioReserva, clienteReserva, servicoReserva;
        public static DateTime horarioReserva;

        // reserva
        public static string nomeServico;
    }
}
