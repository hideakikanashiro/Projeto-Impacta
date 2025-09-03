using AgendamentoVeterinaria.Domain.Entities;
using AgendamentoVeterinaria.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AgendamentoVeterinaria.Web.Pages.CadastroAgendamento
{
    public class IndexModel : PageModel
    {
        private readonly IAgendamentoService _agendamentoService;
        public List<AgendamentoConsulta> AgendamentoConsultas { get; set; }
        
        
        public IndexModel(IAgendamentoService agendamentoService)
        {
            _agendamentoService = agendamentoService;
        }
        
        public async Task OnGet()
        {
            AgendamentoConsultas = await _agendamentoService.ListarTodos();
        }
    }
}
