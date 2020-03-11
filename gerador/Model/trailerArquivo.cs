namespace gerador.Model
{
    public class trailerArquivo
    {
        public string banco;
        public string lote;
        public string tipoRegistro;
        public string usoExclusivo1;
        public string quantidadeLotes;
        public string quantidadeRegistros;
        public string quantidadeContasConcil;
        public string usoExclusivo2;
        public arquivoCNAB240 objetoPai { get; }
        public trailerArquivo(arquivoCNAB240 arquivo)
        {
            this.objetoPai = arquivo;
        }
        public void geraValores()
        {
            this.banco = "243";//ok
            this.lote = "9999";//ok
            this.tipoRegistro = "9";//ok
            this.usoExclusivo1 = "".PadRight(9, ' ');
            this.quantidadeLotes = this.objetoPai.lotes.Count.ToString().PadLeft(6, '0');//ok
            int quantidadeRegistros = 2;
            foreach(lote lote in this.objetoPai.lotes)
            {
                quantidadeRegistros += (2 + lote.pagamentos.Count*3);
            }
            this.quantidadeRegistros = quantidadeRegistros.ToString().PadLeft(6, '0');//ok
            this.quantidadeContasConcil = "000000";//ok
            this.usoExclusivo2 = "".PadRight(205, ' ');//ok
        }
        public string retornaTexto()
        {
            return this.banco +
            this.lote +
            this.tipoRegistro +
            this.usoExclusivo1 +
            this.quantidadeLotes +
            this.quantidadeRegistros +
            this.quantidadeContasConcil +
            this.usoExclusivo2;
        }
    }
}