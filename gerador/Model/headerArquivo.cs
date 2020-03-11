using Bogus;
using System.Linq;
using gerador.Enum;

namespace gerador.Model
{
    public class headerArquivo
    {
        public string banco;
        public string lote;
        public string tipoRegistro;
        public string usoExclusivo1;
        public string tipoInscricaoEmpresa;
        public string numeroInscricaoEmpresa;
        public string convenio;
        public string codigoAgenciaEmpresa;
        public string dvAgenciaEmpresa;
        public string numeroContaEmpresa;
        public string dvContaEmpresa;
        public string dvAgenciaConta;
        public string nomeEmpresa;
        public string nomeBanco;
        public string usoExclusivo2;
        public string codigoRemessaRetorno;
        public string dataGeracaoArquivo;
        public string horaGeracaoArquivo;
        public string numeroSequencialArquivo;
        public string versaoLayoutArquivo;
        public string densidadeGravacao;
        public string usoReservadoBanco;
        public string usoReservadoEmpresa;
        public string usoExclusivoFebraban;
        public arquivoCNAB240 objetoPai { get; }
        public headerArquivo(arquivoCNAB240 arquivo)
        {
            this.objetoPai = arquivo;
        }
        public void geraValores()
        {
            Faker faker = new Faker("pt_BR");
            this.banco = "243";//ok
            this.lote = "0000";//ok
            this.tipoRegistro = "0";//ok
            this.usoExclusivo1 = "".PadRight(9, ' ');//ok
            if(this.objetoPai.lotes.Where(
                x => x.tipoPagamento == formaLancamento.DOC || 
                x.tipoPagamento == formaLancamento.TED
            ).Count() > 0)
            {
                this.tipoInscricaoEmpresa = faker.Random.String2(1, "1239");
            }
            else
            {
                this.tipoInscricaoEmpresa = faker.Random.String2(1, "01239");
            }//ok
            this.numeroInscricaoEmpresa = (this.tipoInscricaoEmpresa == "0" ? "".PadRight(14, ' ') : faker.Random.String2(14, "0123456789"));//ok
            this.convenio = faker.Random.String2(20);//ok            
            this.codigoAgenciaEmpresa = faker.Random.String2(5, "0123456789");//ok
            this.dvAgenciaEmpresa = faker.Random.String2(1, "0123456789");//ok
            this.numeroContaEmpresa = faker.Random.String2(12, "0123456789");//ok
            this.dvContaEmpresa = faker.Random.String2(1, "0123456789");//ok
            this.dvAgenciaConta = faker.Random.String2(1, "0123456789");//ok
            this.nomeEmpresa = faker.Random.String2(30);//ok
            this.nomeBanco = faker.Random.String2(30);//ok
            this.usoExclusivo2 = "".PadRight(10, ' ');//ok
            this.codigoRemessaRetorno = "1";//ok
            this.dataGeracaoArquivo = gerador.Helpers.Utils.geraRandomDDMMAAA();//ok
            this.horaGeracaoArquivo = gerador.Helpers.Utils.geraRandomHHMMSS();//ok
            this.numeroSequencialArquivo = faker.Random.String2(6, "0123456789");//ok
            this.versaoLayoutArquivo = "103";//ok
            this.densidadeGravacao = (new string[2] {"01600", "06250"})[faker.Random.Int(0, 1)];//ok
            this.usoReservadoBanco = "RESERVADO BANCO".PadRight(20, ' ');//ok
            this.usoReservadoEmpresa = "RESERVADO EMPRESA".PadRight(20, ' ');//ok
            this.usoExclusivoFebraban = "".PadRight(29, ' ');//ok
        }
        public string retornaTexto()
        {
            return this.banco +
            this.lote +
            this.tipoRegistro +
            this.usoExclusivo1 +
            this.tipoInscricaoEmpresa +
            this.numeroInscricaoEmpresa +
            this.convenio +
            this.codigoAgenciaEmpresa +
            this.dvAgenciaEmpresa +
            this.numeroContaEmpresa +
            this.dvContaEmpresa +
            this.dvAgenciaConta +
            this.nomeEmpresa +
            this.nomeBanco +
            this.usoExclusivo2 +
            this.codigoRemessaRetorno +
            this.dataGeracaoArquivo +
            this.horaGeracaoArquivo +
            this.numeroSequencialArquivo +
            this.versaoLayoutArquivo +
            this.densidadeGravacao +
            this.usoReservadoBanco +
            this.usoReservadoEmpresa +
            this.usoExclusivoFebraban;
        }
    }
}