using Bogus;
using System;
using System.Globalization;

namespace gerador.Model
{
    public class segmentoB
    {
        public string banco;
        public string lote;
        public string tipoRegistro;
        public string numeroSequencialRegistro;
        public string segmento;
        public string usoExclusivo;
        public string tipoInscricaoFavorecido;
        public string numeroInscricaoFavorecido;
        public string logradouro;
        public string numero;
        public string complemento;
        public string bairro;
        public string cidade;
        public string cep;
        public string complementoCep;
        public string estado;
        public string dataVencimento;
        public string valorDocumento;
        public string valorAbatimento;
        public string valorDesconto;
        public string valorMora;
        public string valorMulta;
        public string codigoDocumentoFavorecido;
        public string aviso;
        public string codigoUGCentralizadora;
        public string codigoISPB;
        public detalhe objetoPai { get; }
        public segmentoB(detalhe detalhe)
        {
            this.objetoPai = detalhe;
        }
        public void geraValores()
        {
            Faker faker = new Faker("pt_BR");
            this.banco = "243";//ok
            this.lote = this.objetoPai.objetoPai.header.lote;//ok
            this.tipoRegistro = "3";//ok
            this.numeroSequencialRegistro = (this.objetoPai.id*3 + 2).ToString().PadLeft(5, '0');//ok
            this.segmento = "B";//ok
            this.usoExclusivo = "".PadRight(3, ' ');//ok
            this.tipoInscricaoFavorecido = this.objetoPai.objetoPai.objetoPai.header.tipoInscricaoEmpresa;//ok
            this.numeroInscricaoFavorecido = this.objetoPai.objetoPai.objetoPai.header.numeroInscricaoEmpresa;//ok
            this.logradouro = "LOGRADOURO".PadRight(30, ' ');//ok
            this.numero = faker.Random.String2(5, "0123456789");//ok
            this.complemento = "COMPLEMENTO".PadRight(15, ' ');//ok
            this.bairro = "BAIRRO".PadRight(15, ' ');//ok
            this.cidade = "CIDADE".PadRight(20, ' ');//ok
            this.cep = faker.Random.String2(5, "0123456789");//ok
            this.complementoCep = faker.Random.String2(3, "0123456789");//ok
            this.estado = gerador.Helpers.Utils.estados[faker.Random.Int(0, 26)];//ok
            this.dataVencimento = DateTime.ParseExact(gerador.Helpers.Utils.geraRandomDDMMAAA(), "ddMMyyyy", CultureInfo.InvariantCulture).AddDays(30).ToString("ddMMyyyy");//ok
            this.valorDocumento = faker.Random.Int(1, 1000000).ToString().PadLeft(15, '0');//ok
            this.valorAbatimento = (((double)faker.Random.Int(0, Int32.Parse(this.valorDocumento)))/100).ToString("0.00").Replace(",", "").PadLeft(15, '0');//ok
            this.valorDesconto = (((double)faker.Random.Int(0, Int32.Parse(this.valorDocumento) - Int32.Parse(this.valorAbatimento)))/100).ToString("0.00").Replace(",", "").PadLeft(15, '0');//ok
            this.valorMora = faker.Random.Int(0, 1000).ToString().PadLeft(15, '0');//ok
            this.valorMulta = faker.Random.Int(0, 1000).ToString().PadLeft(15, '0');//ok
            this.codigoDocumentoFavorecido = faker.Random.String2(15, "0123456789");//ok
            this.aviso = gerador.Helpers.Utils.codigoAvisoFavorecido[faker.Random.Int(0, 4)];//ok
            this.codigoUGCentralizadora  = "000000";//ok
            this.codigoISPB = faker.Random.String2(8, "0123456789");//ok
        }
        public string retornaTexto()
        {
            return this.banco +
            this.lote +
            this.tipoRegistro +
            this.numeroSequencialRegistro +
            this.segmento +
            this.usoExclusivo +
            this.tipoInscricaoFavorecido +
            this.numeroInscricaoFavorecido +
            this.logradouro +
            this.numero +
            this.complemento +
            this.bairro +
            this.cidade +
            this.cep +
            this.complementoCep +
            this.estado +
            this.dataVencimento +
            this.valorDocumento +
            this.valorAbatimento +
            this.valorDesconto +
            this.valorMora +
            this.valorMulta +
            this.codigoDocumentoFavorecido +
            this.aviso +
            this.codigoUGCentralizadora +
            this.codigoISPB;
        }
    }
}