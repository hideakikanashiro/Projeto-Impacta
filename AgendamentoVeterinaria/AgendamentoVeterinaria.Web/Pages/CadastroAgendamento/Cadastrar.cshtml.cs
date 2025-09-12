using AgendamentoVeterinaria.Domain.Entities;
using AgendamentoVeterinaria.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AgendamentoVeterinaria.Web.Pages.CadastroAgendamento
{
    public class CadastrarModel : PageModel
    {
        private readonly IAgendamentoService _agendamentoService;
        public CadastrarModel(IAgendamentoService agendamentoService)
        {
            _agendamentoService = agendamentoService;
        }

        [BindProperty]
        public AgendamentoConsulta Agendamento { get; set; }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            await _agendamentoService.CadastrarAgendamento(Agendamento);
            return RedirectToPage("./Index");
        }
    }
}
