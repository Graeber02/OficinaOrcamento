using Microsoft.AspNetCore.Mvc;
using oficina.Api.Application.DTOs;
using Oficina.Api.Domain.Interfaces;

namespace Oficina.Api.Controllers;

[ApiController]
[Route("api/orcamentos")]
public class OrcamentosController : ControllerBase
{
    private readonly IOrcamentoService _service;
    private readonly IOrcamentoRepository _repository;

    public OrcamentosController(IOrcamentoService service, IOrcamentoRepository repository)
    {
        _service = service;
        _repository = repository;
    }

    [HttpPost]
    public IActionResult Criar([FromBody] CriarOrcamentoDto dto)
    {
        try
        {
            var orcamento = _service.CriarOrcamento(dto);

            _repository.Adicionar(orcamento);

            return Ok(new
            {
                orcamento.Id,
                orcamento.ClienteId,
                orcamento.VeiculoId,
                Total = orcamento.Total,
                Itens = orcamento.Itens
            });
        }
        catch (Exception ex)
        {
            return BadRequest(new
            {
                erro = ex.Message
            });
        }
    }
}