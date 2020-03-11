using System;
using Bogus;

namespace gerador.Helpers
{
    public static class Utils
    {
        public static string[] codigoOcorrencias = new string[]{
            "00", "01", "02", "03", "AA", "AB", "AC", "AD", "AE", "AF", "AG", "AH", "AI", "AJ", "AK", "AL", "AM", "AN", "AO", "AP", "AQ", "AR", "AS", "AT", "AU", 
            "AV", "AW", "AX", "AY", "AZ", "BA", "BB", "BC", "BD", "BE", "BF", "BG", "BH", "BI", "BJ", "BK", "BL", "BM", "BN", "BO", "BP", "BQ", "BR", "BS", "CA", 
            "CB", "CC", "CD", "CE", "CF", "CG", "CH", "CI", "CJ", "CK", "CL", "CM", "CN", "CO", "CP", "HA", "HB", "HC", "HD", "HE", "HF", "HG", "HH", "HI", "HJ", 
            "HK", "HL", "HM", "HN", "HO", "HP", "HQ", "HR", "HS", "HT", "HU", "HV", "HW", "HX", "HY", "HZ", "H1", "H2", "H3", "H4", "H5", "H6", "H7", "H8", "H9", 
            "IA", "IB", "IC", "ID", "IE", "IF", "IG", "IH", "II", "IJ", "IK", "IL", "IM", "IN", "IO", "IP", "IQ", "IR", "TA", "YA", "YB", "YC", "YD", "YE", "YF", 
            "ZA", "ZB", "ZC", "ZD", "ZE", "ZF", "ZG", "ZH", "ZI", "ZJ", "ZK"
        };
        public static string[] tiposMoeda = new string[]{
            "BTN", "BRL", "USD", "PTE", "FRF", "CHF", "JPY", "IGP", "IGM", 
            "GBP", "ITL", "DEM", "TRD", "UPC", "UPF", "UFR", "XEU"
        };
        public static string[] complementoTipoServico = new string[]{
            "01", "02", "03", "04", "05", "06", "07", "08", "09", 
            "10", "11", "12", "13", "16", "17", "18", "19"
        };
        public static string[] codigoAvisoFavorecido = new string[]{
            "0", "2", "5", "6", "7"
        };
        public static string[] estados = new string[] {
            "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", 
            "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", 
            "RR", "SC", "SP", "SE", "TO"
        };
        public static string geraRandomDDMMAAA()
        {
            Faker faker = new Faker("pt_BR");

            var data = DateTime.Now.AddDays(faker.Random.Double(-30, 0));

            return data.ToString("ddMMyyyy");
        }

        public static string geraRandomHHMMSS()
        {
            Faker faker = new Faker("pt_BR");

            string hora = faker.Random.Int(0, 23).ToString().PadLeft(2, '0');
            string minuto = faker.Random.Int(0, 59).ToString().PadLeft(2, '0');
            string segundo = faker.Random.Int(0, 59).ToString().PadLeft(2, '0');

            return hora + minuto + segundo;
        }

        public static string timeStamp()
        {
            return DateTime.Now.ToString("yyyyMMddHHmmssffff");
        }
    }
}