using Bogus;

namespace gerador.Model
{
    public class headerLote
    {
        public string banco;
        public string lote;
        public string tipoRegistro;
        public string tipoOperacao;
        public string tipoServico;
        public string formaLancamento;
        public string layoutLote;
        public string usoExclusivo1;
        public string tipoInscricaoEmpresa;
        public string numeroInscricaoEmpresa;
        public string codigoConvenioBanco;
        public string agencia;
        public string dvAgencia;
        public string contaCorrente;
        public string dvConta;
        public string dvAgenciaConta;
        public string nomeEmpresa;
        public string mensagem;
        public string logradouro;
        public string numero;
        public string complemento;
        public string cidade;
        public string cep;
        public string complementoCep;
        public string siglaEstado;
        public string indicativoFormaPagamento;
        public string usoExclusivo2;
        public string ocorrencias;
        public lote objetoPai { get; }
        public headerLote(lote lote)
        {
            this.objetoPai = lote;
        }
        public void geraValores()
        {
            Faker faker = new Faker("pt_BR");
            this.banco = "243";//ok
            this.lote = (this.objetoPai.objetoPai.lotes.FindIndex(x => x.tipoPagamento == this.objetoPai.tipoPagamento) + 1).ToString().PadLeft(4, '0');//ok
            this.tipoRegistro = "1";//ok
            this.tipoOperacao = "C";//ok
            this.tipoServico = (new string[16] {"03", "10", "20", "22", "30", "32", "33", "34", "50", "60", "70", "75", "77", "80", "90", "98"})[faker.Random.Int(0, 15)];//ok
            this.formaLancamento = "99";
            this.layoutLote = "046";//ok
            this.usoExclusivo1 = "".PadRight(1, ' ');//ok
            this.tipoInscricaoEmpresa = this.objetoPai.objetoPai.header.tipoInscricaoEmpresa;//ok
            this.numeroInscricaoEmpresa = this.objetoPai.objetoPai.header.numeroInscricaoEmpresa;//ok
            this.codigoConvenioBanco = this.objetoPai.objetoPai.header.convenio;//ok
            this.agencia = this.objetoPai.objetoPai.header.codigoAgenciaEmpresa;//ok
            this.dvAgencia = this.objetoPai.objetoPai.header.dvAgenciaEmpresa;//ok
            this.contaCorrente = this.objetoPai.objetoPai.header.numeroContaEmpresa;//ok
            this.dvConta = this.objetoPai.objetoPai.header.dvContaEmpresa;//ok
            this.dvAgenciaConta = this.objetoPai.objetoPai.header.dvAgenciaConta;//ok
            this.nomeEmpresa = this.objetoPai.objetoPai.header.nomeEmpresa;//ok
            this.mensagem = "MENSAGEM".PadRight(40, ' ');//ok
            this.logradouro = "LOGRADOURO".PadRight(30, ' ');//ok
            this.numero = faker.Random.String2(5, "0123456789");//ok
            this.complemento = "COMPLEMENTO".PadRight(15, ' ');//ok
            this.cidade = "CIDADE".PadRight(20, ' ');//ok
            this.cep = faker.Random.String2(5, "0123456789");//ok
            this.complementoCep = faker.Random.String2(3);//ok
            this.siglaEstado = faker.Random.String2(2);//ok
            this.indicativoFormaPagamento = (new string[3] {"01", "02", "03"})[faker.Random.Int(0, 2)];//ok
            this.usoExclusivo2 = "".PadRight(6, ' ');//ok
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
            this.tipoOperacao +
            this.tipoServico +
            this.formaLancamento +
            this.layoutLote +
            this.usoExclusivo1 +
            this.tipoInscricaoEmpresa +
            this.numeroInscricaoEmpresa +
            this.codigoConvenioBanco +
            this.agencia +
            this.dvAgencia +
            this.contaCorrente +
            this.dvConta +
            this.dvAgenciaConta +
            this.nomeEmpresa +
            this.mensagem +
            this.logradouro +
            this.numero +
            this.complemento +
            this.cidade +
            this.cep +
            this.complementoCep +
            this.siglaEstado +
            this.indicativoFormaPagamento +
            this.usoExclusivo2 +
            this.ocorrencias;
        }
    }
}