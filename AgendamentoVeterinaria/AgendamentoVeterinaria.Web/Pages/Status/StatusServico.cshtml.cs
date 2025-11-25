using AgendamentoVeterinaria.Domain.Entities;
using AgendamentoVeterinaria.Domain.Interfaces;
using AgendamentoVeterinaria.Domain.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AgendamentoVeterinaria.Web.Pages.Status;

public class StatusServicoModel : PageModel
{
    public List<AgendamentoConsulta> AgendamentoConsultas { get; set; } = new();

    private readonly IAgendamentoService _agendamentoService;

    public StatusServicoModel(IAgendamentoService agendamentoService)
    {
        _agendamentoService = agendamentoService;
    }

    public async Task OnGet()
    {
        AgendamentoConsultas = await _agendamentoService.ListarTodos();
    }

    public async Task<IActionResult> OnPostAvancarStatusAsync(int id)
    {
        var agendamento = await _agendamentoService.BuscarPorId(id);
        if (agendamento != null && agendamento.Status != "Finalizado")
        {
            agendamento.AvancarStatus();
            await _agendamentoService.AtualizarStatus(agendamento);
        }

        return RedirectToPage();
    }


}

