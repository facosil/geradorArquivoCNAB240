using Bogus;
using System;
using System.Globalization;

namespace gerador.Model
{
    public class segmentoA
    {
        public string banco;
        public string lote;
        public string tipoRegistro;
        public string numeroSequencialRegistro;
        public string segmento;
        public string tipoMovimento;
        public string codigoInstrucaoMovimento;
        public string codigoCamaraCentralizadora;
        public string codigoBancoFavorecido;
        public string agenciaFavorecido;
        public string dvAgenciaFavorecido;
        public string contaFavorecido;
        public string dvContaFavorecido;
        public string dvAgenciaContaFavorecido;
        public string nomeFavorecido;
        public string seuNumero;
        public string dataPagamento;
        public string tipoMoeda;
        public string quantidadeMoeda;
        public string valorPagamento;
        public string nossoNumero;
        public string dataRealEfetivacaoPgto;
        public string valorRealEfetivacaoPgto;
        public string informacao2;
        public string codigoFinalidadeDoc;
        public string codigoFinalidadeTED;
        public string codigoFinalidadeCompl;
        public string usoExclusivo;
        public string aviso;
        public string ocorrencias;
        public detalhe objetoPai { get; }
        public segmentoA(detalhe detalhe)
        {
            this.objetoPai = detalhe;
        }
        public void geraValores()
        {
            Faker faker = new Faker("pt_BR");
            this.banco = "243";//ok
            this.lote = this.objetoPai.objetoPai.header.lote;//ok
            this.tipoRegistro = "3";//ok
            this.numeroSequencialRegistro = (this.objetoPai.id*3 + 1).ToString().PadLeft(5, '0');//ok
            this.segmento = "A";//ok
            this.tipoMovimento = new string[7] {"0", "1", "2", "4", "5", "7", "9"}[faker.Random.Int(0, 6)];//ok
            this.codigoInstrucaoMovimento = new string[11] {"00", "09", "10", "11", "17", "19", "23", "25", "27", "40", "99"}[faker.Random.Int(0, 10)];//ok
            this.codigoCamaraCentralizadora = new string[3] {"018", "700", "988"}[faker.Random.Int(0, 2)];//ok
            this.codigoBancoFavorecido = faker.Random.String2(3, "0123456789");
            this.agenciaFavorecido = faker.Random.String2(5, "0123456789");//ok
            this.dvAgenciaFavorecido = faker.Random.String2(1, "0123456789");//ok
            this.contaFavorecido = faker.Random.String2(12, "0123456789");//ok
            this.dvContaFavorecido = faker.Random.String2(1, "0123456789");
            this.dvAgenciaContaFavorecido = faker.Random.String2(1, "0123456789");//ok
            this.nomeFavorecido = "NOME FAVORECIDO".PadRight(30, ' ');//ok
            this.seuNumero = faker.Random.String2(20, "0123456789");//ok
            this.dataPagamento = gerador.Helpers.Utils.geraRandomDDMMAAA();//ok
            this.tipoMoeda = gerador.Helpers.Utils.tiposMoeda[faker.Random.Int(0, 16)];//ok
            this.quantidadeMoeda = faker.Random.Int(0, 1000000000).ToString().PadLeft(15, '0');//ok
            this.valorPagamento = (((double)faker.Random.Int(1, Int32.Parse(this.quantidadeMoeda)))/100000).ToString("0.00").Replace(",", "").PadLeft(15, '0');//ok
            this.nossoNumero = faker.Random.String2(20, "0123456789");//ok
            this.dataRealEfetivacaoPgto = DateTime.ParseExact(this.dataPagamento, "ddMMyyyy", CultureInfo.InvariantCulture).AddDays(1).ToString("ddMMyyyy");//ok
            this.valorRealEfetivacaoPgto = this.valorPagamento;//ok
            this.informacao2 = "INFORMACAO".PadRight(40, ' ');//ok
            this.codigoFinalidadeDoc = gerador.Helpers.Utils.complementoTipoServico[faker.Random.Int(0, 16)];//ok
            this.codigoFinalidadeTED = faker.Random.String2(5);
            this.codigoFinalidadeCompl = faker.Random.String2(2);//ok
            this.usoExclusivo = "".PadRight(3, ' ');//ok
            this.aviso = gerador.Helpers.Utils.codigoAvisoFavorecido[faker.Random.Int(0, 4)];//ok
            this.ocorrencias = gerador.Helpers.Utils.codigoOcorrencias[faker.Random.Int(0, gerador.Helpers.Utils.codigoOcorrencias.Length - 1)] +
            gerador.Helpers.Utils.codigoOcorrencias[faker.Random.Int(0, gerador.Helpers.Utils.codigoOcorrencias.Length - 1)] +
            gerador.Helpers.Utils.codigoOcorrencias[faker.Random.Int(0, gerador.Helpers.Utils.codigoOcorrencias.Length - 1)] +
            gerador.Helpers.Utils.codigoOcorrencias[faker.Random.Int(0, gerador.Helpers.Utils.codigoOcorrencias.Length - 1)] +
            gerador.Helpers.Utils.codigoOcorrencias[faker.Random.Int(0, gerador.Helpers.Utils.codigoOcorrencias.Length - 1)];//ok
        }
        public string retornaTexto()
        {
            return this.banco +
            this.lote +
            this.tipoRegistro +
            this.numeroSequencialRegistro +
            this.segmento +
            this.tipoMovimento +
            this.codigoInstrucaoMovimento +
            this.codigoCamaraCentralizadora +
            this.codigoBancoFavorecido +
            this.agenciaFavorecido +
            this.dvAgenciaFavorecido +
            this.contaFavorecido +
            this.dvContaFavorecido +
            this.dvAgenciaContaFavorecido +
            this.nomeFavorecido +
            this.seuNumero +
            this.dataPagamento +
            this.tipoMoeda +
            this.quantidadeMoeda +
            this.valorPagamento +
            this.nossoNumero +
            this.dataRealEfetivacaoPgto +
            this.valorRealEfetivacaoPgto +
            this.informacao2 +
            this.codigoFinalidadeDoc +
            this.codigoFinalidadeTED +
            this.codigoFinalidadeCompl +
            this.usoExclusivo +
            this.aviso +
            this.ocorrencias;
        }
    }
}