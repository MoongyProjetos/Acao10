namespace PagamentosApi
{
    public class Pagamento
    {
        public int? Id { get; set; }
        public string? IBANOrigem { get; set; }
        public string? IBANDestino { get; set; }
        public decimal? Valor { get; set; }
        public DateTime? DataDaOperacao { get; set; }
    }
}
