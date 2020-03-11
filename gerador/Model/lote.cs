using System.Collections.Generic;
using gerador.Enum;

namespace gerador.Model
{
    public class lote
    {
        public headerLote header;
        public List<detalhe> pagamentos;
        public trailerLote trailer;
        public formaLancamento tipoPagamento;
        public arquivoCNAB240 objetoPai { get; }
        public lote(arquivoCNAB240 arquivo)
        {
            this.objetoPai = arquivo;
        }
        public void geraValores()
        {
            this.header.geraValores();

            foreach(detalhe detalhe in pagamentos)
            {
                detalhe.geraValores();
            }
            
            this.trailer.geraValores();
        }
        public string retornaTexto()
        {
            string textoLote = "";

            textoLote += this.header.retornaTexto() + "\n";
            foreach(var detalhe in this.pagamentos)
            {
                textoLote += detalhe.retornaTexto() + "\n";
            }
            textoLote += this.trailer.retornaTexto();

            return textoLote;
        }
    }
}