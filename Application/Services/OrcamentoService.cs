using oficina.Api.Application.DTOs;
using oficina.Api.Domain.Entities;
using Oficina.Api.Domain.Interfaces;

namespace Oficina.Api.Application.Services;

public class OrcamentoService : IOrcamentoService
{
    public Orcamento CriarOrcamento(CriarOrcamentoDto dto)
    {
        var erros = Validar(dto);
        if (erros.Any())
            throw new Exception(string.Join(" | ", erros));

        var orcamento = new Orcamento
        {
            ClienteId = dto.ClienteId,
            VeiculoId = dto.VeiculoId,
            Itens = dto.Itens.Select(i => new OrcamentoItem
            {
                Descricao = i.Descricao,
                Quantidade = i.Quantidade,
                ValorUnitario = i.ValorUnitario
            }).ToList()
        };

        return orcamento;
    }

    private List<string> Validar(CriarOrcamentoDto dto)
    {
        var erros = new List<string>();

        if (dto.ClienteId <= 0)
            erros.Add("ClienteId é obrigatório.");

        if (dto.VeiculoId <= 0)
            erros.Add("VeiculoId é obrigatório.");

        if (dto.Itens == null || !dto.Itens.Any())
            erros.Add("Deve existir pelo menos 1 item.");

        if (dto.Itens != null)
        {
            foreach (var item in dto.Itens)
            {
                if (string.IsNullOrWhiteSpace(item.Descricao))
                    erros.Add("Descrição do item é obrigatória.");

                if (item.Quantidade <= 0)
                    erros.Add("Quantidade deve ser maior que zero.");

                if (item.ValorUnitario <= 0)
                    erros.Add("Valor unitário deve ser maior que zero.");
            }
        }

        return erros;
    }
}