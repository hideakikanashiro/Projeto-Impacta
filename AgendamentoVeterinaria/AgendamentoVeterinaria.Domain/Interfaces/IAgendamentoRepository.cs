using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgendamentoVeterinaria.Domain.Entities;

namespace AgendamentoVeterinaria.Domain.Interfaces
{
    public interface IAgendamentoRepository
    {
        Task<List<AgendamentoConsulta>> ListarTodosAsync();
        Task<AgendamentoConsulta?> BuscarAgendamentoPorId(int id);
        Task CadastrarAgendamentoAsync(AgendamentoConsulta agendamento);
        Task AtualizarAgendamentoAsync(AgendamentoConsulta agendamento);
        Task ExcluirAgendamentoAsync(int id);
    }
}
