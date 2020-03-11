using Bogus;
using System;

namespace gerador.Model
{
    public class segmentoC
    {
        public string banco;
        public string lote;
        public string tipoRegistro;
        public string numeroSequencialRegistro;
        public string segmento;
        public string usoExclusivo1;
        public string valorIR;
        public string valorISS;
        public string valorIOF;
        public string outrasDeducoes;
        public string outrosAcrescimos;
        public string agencia;
        public string dvAgencia;
        public string numeroContaCorrente;
        public string dvContaCorrente;
        public string dvAgenciaConta;
        public string valorINSS;
        public string numeroContaPagamentoCreditada;
        public string usoExclusivo2;
        public detalhe objetoPai { get; }
        public segmentoC(detalhe detalhe)
        {
            this.objetoPai = detalhe;
        }
        public void geraValores()
        {
            Faker faker = new Faker("pt_BR");
            this.banco = "243";//ok
            this.lote = this.objetoPai.objetoPai.header.lote;//ok
            this.tipoRegistro = "3";//ok
            this.numeroSequencialRegistro = (this.objetoPai.id*3 + 3).ToString().PadLeft(5, '0');//ok
            this.segmento = "C";//ok
            this.usoExclusivo1 = "".PadRight(3, ' ');//ok
            this.valorIR = ((((double)Int32.Parse(this.objetoPai.segmentoB.valorDocumento))/100)*0.15).ToString("0.00").Replace(",", "").PadLeft(15, '0');//ok
            this.valorISS = ((((double)Int32.Parse(this.objetoPai.segmentoB.valorDocumento))/100)*0.05).ToString("0.00").Replace(",", "").PadLeft(15, '0');//ok
            this.valorIOF = ((((double)Int32.Parse(this.objetoPai.segmentoB.valorDocumento))/100)*0.10).ToString("0.00").Replace(",", "").PadLeft(15, '0');//ok
            this.outrasDeducoes = "000000000000000";//ok
            this.outrosAcrescimos = "000000000000000";//ok
            this.agencia = faker.Random.String2(5, "0123456789");//ok
            this.dvAgencia = faker.Random.String2(1, "0123456789");//ok
            this.numeroContaCorrente = faker.Random.String2(12, "0123456789");//ok
            this.dvContaCorrente = faker.Random.String2(1, "0123456789");//ok
            this.dvAgenciaConta = faker.Random.String2(1, "0123456789");//ok
            this.valorINSS = ((((double)Int32.Parse(this.objetoPai.segmentoB.valorDocumento))/100)*0.18).ToString("0.00").Replace(",", "").PadLeft(15, '0');//ok
            this.numeroContaPagamentoCreditada = faker.Random.String2(20, "0123456789");//ok
            this.usoExclusivo2 = "".PadRight(93, ' ');//ok
        }
        public string retornaTexto()
        {
            return this.banco +
            this.lote +
            this.tipoRegistro +
            this.numeroSequencialRegistro +
            this.segmento +
            this.usoExclusivo1 +
            this.valorIR +
            this.valorISS +
            this.valorIOF +
            this.outrasDeducoes +
            this.outrosAcrescimos +
            this.agencia +
            this.dvAgencia +
            this.numeroContaCorrente +
            this.dvContaCorrente +
            this.dvAgenciaConta +
            this.valorINSS +
            this.numeroContaPagamentoCreditada +
            this.usoExclusivo2;
        }
    }
}