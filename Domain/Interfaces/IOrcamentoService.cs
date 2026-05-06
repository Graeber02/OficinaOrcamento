using oficina.Api.Application.DTOs;
using oficina.Api.Domain.Entities;

namespace Oficina.Api.Domain.Interfaces;

public interface IOrcamentoService
{
    Orcamento CriarOrcamento(CriarOrcamentoDto dto);
}