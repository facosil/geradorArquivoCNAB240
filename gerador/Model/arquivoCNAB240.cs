using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using gerador.Helpers;
using Bogus;
using gerador.Enum;
using System.Linq;

namespace gerador.Model
{
    public class arquivoCNAB240
    {
        public headerArquivo header;
        public List<lote> lotes;
        public trailerArquivo trailer;
        public string caminho;
        public arquivoCNAB240(List<pagamentoInfo> pagamentos)
        {
            this.header = new headerArquivo(this);

            this.lotes = new List<lote>();
            foreach(var pagamento in pagamentos)
            {
                lote lote = new lote(this);
                lote.header = new headerLote(lote);
                lote.pagamentos = new List<detalhe>();
                lote.trailer = new trailerLote(lote);
                lote.tipoPagamento = pagamento.tipoPagamento;

                for(var i = 0; i < pagamento.quantidade; i++)
                {
                    detalhe detalhe = new detalhe(lote);
                    detalhe.segmentoA = new segmentoA(detalhe);
                    detalhe.segmentoB = new segmentoB(detalhe);
                    detalhe.segmentoC = new segmentoC(detalhe);
                    detalhe.id = i;
                    lote.pagamentos.Add(detalhe);
                }

                this.lotes.Add(lote);
            }

            this.trailer = new trailerArquivo(this);

            this.caminho = Environment.CurrentDirectory + "\\ArquivosCNABGerados\\CNAB240_" + gerador.Helpers.Utils.timeStamp() + ".txt";
        }
        public void gerarArquivo()
        {
            this.geraValores();
            this.gravaArquivo(this.retornaTexto());
        }
        private void geraValores()
        {
            this.header.geraValores();

            foreach(var lote in this.lotes)
            {
                lote.geraValores();
            }

            this.trailer.geraValores();
        }
        private string retornaTexto()
        {
            string textoArquivo = "";

            textoArquivo += this.header.retornaTexto() + "\n";
            foreach(var lote in this.lotes)
            {
                textoArquivo += lote.retornaTexto() + "\n";
            }
            textoArquivo += this.trailer.retornaTexto();

            return textoArquivo;
        }
        private void gravaArquivo(string texto)
        {
            StreamWriter valor = new StreamWriter(this.caminho, true, Encoding.ASCII);
            valor.WriteLine(texto);
            valor.Close();
        }
    }
}