using oficina.Api.Domain.Entities;
using Oficina.Api.Domain.Interfaces;

namespace Oficina.Api.Infrastructure.Repositories;

public class OrcamentoRepository : IOrcamentoRepository
{
    private readonly List<Orcamento> _db = new();

    public void Adicionar(Orcamento orcamento)
    {
        orcamento.Id = _db.Count + 1;
        _db.Add(orcamento);
    }
}