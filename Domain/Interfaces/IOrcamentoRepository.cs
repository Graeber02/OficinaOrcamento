using oficina.Api.Domain.Entities;
namespace Oficina.Api.Domain.Interfaces;

public interface IOrcamentoRepository
{
    void Adicionar(Orcamento orcamento);
}