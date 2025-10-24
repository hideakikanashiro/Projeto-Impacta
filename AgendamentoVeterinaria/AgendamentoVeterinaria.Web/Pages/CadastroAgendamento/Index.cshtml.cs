using AgendamentoVeterinaria.Domain.Entities;
using AgendamentoVeterinaria.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AgendamentoVeterinaria.Web.Pages.CadastroAgendamento
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public AgendamentoConsulta AgendamentoParaSalvar { get; set; } = new();

        public bool ShowModal { get; set; }
        public List<AgendamentoConsulta> AgendamentoConsultas { get; set; } = new();
        public AgendamentoConsulta? AgendamentoParaEditar { get; set; }

        private readonly IAgendamentoService _agendamentoService;

        public IndexModel(IAgendamentoService agendamentoService)
        {
            _agendamentoService = agendamentoService;
        }

        public async Task OnGet()
        {
            AgendamentoConsultas = await _agendamentoService.ListarTodos();
        }

        // ABRIR MODAL DE EDIÇÃO
        public async Task<IActionResult> OnPostAbrirEditModalAsync(int id)
        {
            AgendamentoConsultas = await _agendamentoService.ListarTodos(); // mantém a tabela
            AgendamentoParaEditar = await _agendamentoService.BuscarPorId(id);

            if (AgendamentoParaEditar == null)
                return Page();

            ShowModal = true;
            return Page();
        }

        // FECHAR MODAL
        public async Task<IActionResult> OnPostCloseEditModalAsync()
        {
            AgendamentoConsultas = await _agendamentoService.ListarTodos();
            ShowModal = false;
            return Page();
        }

        // SALVAR EDIÇÃO
        public async Task<IActionResult> OnPostSalvarEdicaoAsync(AgendamentoConsulta agendamento)
        {
            if (AgendamentoParaSalvar == null)
            {
                return Page();
            }

            await _agendamentoService.Atualizar(AgendamentoParaSalvar);

            AgendamentoConsultas = await _agendamentoService.ListarTodos();
            ShowModal = false;
            return Page();
        }
    }
}
