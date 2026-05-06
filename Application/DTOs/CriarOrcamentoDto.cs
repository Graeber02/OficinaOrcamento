namespace oficina.Api.Application.DTOs
{
    public class CriarOrcamentoDto
    {
        public int ClienteId { get; set; }
        public int VeiculoId { get; set; }
        public List<CriarOrcamentoItemDto> Itens { get; set; } = new();
    }

    public class CriarOrcamentoItemDto
    {
        public string Descricao { get; set; } = string.Empty;
        public int Quantidade { get; set; }
        public decimal ValorUnitario { get; set; }
    }
}
