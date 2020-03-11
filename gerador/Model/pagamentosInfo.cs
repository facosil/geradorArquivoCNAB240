using gerador.Enum;

namespace gerador.Model
{
    public class pagamentoInfo
    {
        public formaLancamento tipoPagamento;
        public int quantidade;

        public pagamentoInfo(formaLancamento tipoPagamento, int quantidade)
        {
            this.tipoPagamento = tipoPagamento;
            this.quantidade = quantidade;
        }
    }
}