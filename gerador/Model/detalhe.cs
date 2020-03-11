namespace gerador.Model
{
    public class detalhe
    {
        public segmentoA segmentoA;
        public segmentoB segmentoB;
        public segmentoC segmentoC;
        public int id;
        public lote objetoPai { get; }
        public detalhe(lote lote)
        {
            this.objetoPai = lote;
        }
        public void geraValores()
        {
            this.segmentoA.geraValores();
            this.segmentoB.geraValores();
            this.segmentoC.geraValores();
        }
        public string retornaTexto()
        {
            return 
                this.segmentoA.retornaTexto() + "\n" +
                this.segmentoB.retornaTexto() + "\n" +
                this.segmentoC.retornaTexto();
        }
    }
}