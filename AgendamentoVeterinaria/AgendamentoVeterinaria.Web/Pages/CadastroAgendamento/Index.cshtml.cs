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
        public bool ShowModalDetalhes { get; set; }
        public List<AgendamentoConsulta> AgendamentoConsultas { get; set; } = new();
        public AgendamentoConsulta? Agendamentos { get; set; }

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
            Agendamentos = await _agendamentoService.BuscarPorId(id);

            if (Agendamentos == null)
                return Page();

            ShowModal = true;
            return Page();
        }

        public async Task<IActionResult> OnPostAbrirDetalhesModalAsync(int id)
        {
            Agendamentos = await _agendamentoService.BuscarPorId(id);

            ShowModalDetalhes = true;
            return Page();
        }

        // FECHAR MODAL
        public async Task<IActionResult> OnPostCloseEditModalAsync()
        {
            AgendamentoConsultas = await _agendamentoService.ListarTodos();
            ShowModal = false;
            return Page();
        }

        public async Task<IActionResult> OnPostCloseDetalhesModalAsync()
        {
            AgendamentoConsultas = await _agendamentoService.ListarTodos();
            ShowModalDetalhes = false;
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
