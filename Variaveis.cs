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
        public static int linhaSelecionada, linhaFoneSelecionada;
        public static DateTime dataCad, horario;

        // login 
        public static string usuario, senha, nivel;

        // empresa
        public static int codEmpresa;
        public static string nomeEmpresa, cnpjCpf, razaoSocial, emailEmpresa, statusEmpresa;

        // cliente
        public static int codCliente;
        public static string nomeCliente, emailCliente, senhaCliente, statusCliente, fotoCliente, caminhoFotoCliente, atFotoCliente;

        // funcionario
        public static int codFuncionario;
        public static string nomeFuncionario, emailFuncionario, senhaFuncionario, statusFuncionario, nivelFuncionario, empresaFuncionario;

        // serviço
        public static int codServico;
        public static string nomeServico, statusServico, descricaoServico, textoServico, fotoServico1, fotoServico2, fotoServico3, fotoServico4, caminhoFotoServico1, caminhoFotoServico2, caminhoFotoServico3, caminhoFotoServico4, atFotoServico1, atFotoServico2, atFotoServico3, atFotoServico4;

        // reserva
        public static int codReserva;
        public static string obs, statusReserva;

        // fone empresa
        public static int codFoneEmpresa;
        public static string foneEmpresa, operFoneEmpresa, descFoneEmpresa;

        // fone cliente
        public static int codFoneCliente;
        public static string foneCliente, operFoneCliente, descFoneCliente;

        // fone funcionario
        public static int codFoneFuncionario;
        public static string foneFuncionario, operFoneFuncionario, descFoneFuncionario;

        // fotos ftp
        public static string enderecoServidorFtp = "ftp://127.0.0.1/admin/";
        public static string usuarioFtp = "ti14";
        public static string senhaFtp = "123";
    }
}
