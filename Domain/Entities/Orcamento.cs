namespace oficina.Api.Domain.Entities;

public class Orcamento
{
    public int Id { get; set; }
    public int ClienteId { get; set; }
    public int VeiculoId { get; set; }
    public List<OrcamentoItem> Itens { get; set; } = new();

    public decimal Total => Itens.Sum(x => x.Total);
}