using System;
using Bogus;

namespace gerador.Model
{
    public class trailerLote
    {
        public string banco;
        public string lote;
        public string tipoRegistro;
        public string usoExclusivo1;
        public string quantidadeRegistrosLote;
        public string valor;
        public string quantidadeMoeda;
        public string numeroAvisoDebito;
        public string usoExclusivo2;
        public string ocorrencias;
        public lote objetoPai { get; }
        public trailerLote(lote lote)
        {
            this.objetoPai = lote;
        }
        public void geraValores()
        {
            Faker faker = new Faker("pt_BR");
            this.banco = "243";//ok
            this.lote = this.objetoPai.header.lote;//ok
            this.tipoRegistro = "5";//ok
            this.usoExclusivo1 = "".PadRight(9, ' ');//ok
            this.quantidadeRegistrosLote = (this.objetoPai.pagamentos.Count*3 + 2).ToString().PadLeft(6, '0');//ok
            double somatoriaValores = 0.00;
            foreach(detalhe detalhe in this.objetoPai.pagamentos)
            {
                somatoriaValores += ((double)Int32.Parse(detalhe.segmentoA.valorPagamento))/100;
            }
            this.valor = somatoriaValores.ToString("0.00").Replace(",", "").PadLeft(18, '0');//ok
            double somatoriaMoedas = 0.00;
            foreach(detalhe detalhe in this.objetoPai.pagamentos)
            {
                somatoriaMoedas += ((double)Int32.Parse(detalhe.segmentoA.quantidadeMoeda))/100000;
            }
            this.quantidadeMoeda = somatoriaMoedas.ToString("0.00000").Replace(",", "").PadLeft(18, '0');//ok
            this.numeroAvisoDebito = faker.Random.String2(6, "0123456789");//ok
            this.usoExclusivo2 = "".PadRight(165, ' ');//ok
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
            this.usoExclusivo1 +
            this.quantidadeRegistrosLote +
            this.valor +
            this.quantidadeMoeda +
            this.numeroAvisoDebito +
            this.usoExclusivo2 +
            this.ocorrencias;
        }
    }
}