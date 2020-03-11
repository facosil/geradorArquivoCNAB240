namespace gerador.Enum
{
    public enum formaLancamento
    {
        CreditoEmConta,
        Cheque,
        OP,
        DOC,
        TED,
        PagamentoComAutenticacao
    }
}

/*
    Crédito em Conta:
        '01' = Crédito em Conta Corrente/Salário
        '05' = Crédito em Conta Poupança

    Cheque:
        '02' = Cheque Pagamento / Administrativo

    OP:
        '10' = OP à Disposição

    DOC:
        '03' = DOC/TED

    TED:
        '41' = TED – Outra Titularidade
        '43' = TED – Mesma Titularidade
        ‘44’ = TED para Transferência de Conta Investimento
    
    Pagamento com Autenticação:
        '20' = Pagamento com Autenticação
*/
