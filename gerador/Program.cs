using System;
using System.Collections.Generic;
using Bogus;
using gerador.Enum;
using gerador.Model;

namespace gerador
{
    class Program
    {
        static void Main(string[] args)
        {
            List<pagamentoInfo> pagamentosInfo = new List<pagamentoInfo>();
            int qtdPagamentos;

            Console.WriteLine("Insira a quantidade de pagamentos do tipo:");

            Console.WriteLine("Crédito em Conta: ");
            qtdPagamentos = Int32.Parse(Console.ReadLine());
            if(qtdPagamentos != 0) pagamentosInfo.Add(new pagamentoInfo(formaLancamento.CreditoEmConta, qtdPagamentos));

            Console.WriteLine("Cheque: ");
            qtdPagamentos = Int32.Parse(Console.ReadLine());
            if(qtdPagamentos != 0) pagamentosInfo.Add(new pagamentoInfo(formaLancamento.Cheque, qtdPagamentos));

            Console.WriteLine("OP: ");
            qtdPagamentos = Int32.Parse(Console.ReadLine());
            if(qtdPagamentos != 0) pagamentosInfo.Add(new pagamentoInfo(formaLancamento.OP, qtdPagamentos));

            Console.WriteLine("DOC: ");
            qtdPagamentos = Int32.Parse(Console.ReadLine());
            if(qtdPagamentos != 0) pagamentosInfo.Add(new pagamentoInfo(formaLancamento.DOC, qtdPagamentos));

            Console.WriteLine("TED: ");
            qtdPagamentos = Int32.Parse(Console.ReadLine());
            if(qtdPagamentos != 0) pagamentosInfo.Add(new pagamentoInfo(formaLancamento.TED, qtdPagamentos));

            Console.WriteLine("Pagamento com autenticação: ");
            qtdPagamentos = Int32.Parse(Console.ReadLine());
            if(qtdPagamentos != 0) pagamentosInfo.Add(new pagamentoInfo(formaLancamento.PagamentoComAutenticacao, qtdPagamentos));

            try
            {
                arquivoCNAB240 arquivoCNAB = new arquivoCNAB240(pagamentosInfo);
                arquivoCNAB.gerarArquivo();
                Console.WriteLine("Arquivo gerado em " + arquivoCNAB.caminho);
                Console.ReadLine();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Erro ao processar arquivo.");
                Console.WriteLine("Mensagem: " + ex.Message);
                Console.ReadLine();
            }
            

        }
    }
}
