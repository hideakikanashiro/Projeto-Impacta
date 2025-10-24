using AgendamentoVeterinaria.Domain.Entities;
using AgendamentoVeterinaria.Domain.Interfaces;

namespace AgendamentoVeterinaria.Domain.Services
{
    public class AgendamentoService : IAgendamentoService
    {
        private readonly IAgendamentoRepository _agendamentoRepository;

        public AgendamentoService(IAgendamentoRepository agendamentoRepository)
        {
            _agendamentoRepository = agendamentoRepository;
        }

        public async Task<List<AgendamentoConsulta>> ListarTodos()
        {
            return await _agendamentoRepository.ListarTodosAsync();
        }

        public async Task<AgendamentoConsulta?> BuscarPorId(int id)
        {
            return await _agendamentoRepository.BuscarAgendamentoPorId(id);
        }

        public async Task CadastrarAgendamento(AgendamentoConsulta agendamento)
        {
            agendamento.DataEntrada = DateTime.Now;
            await _agendamentoRepository.CadastrarAgendamentoAsync(agendamento);
        }

        public async Task Atualizar(AgendamentoConsulta agendamento)
        {            
            await _agendamentoRepository.AtualizarAgendamentoAsync(agendamento);
        }

        public async Task Excluir(int id)
        {
            await _agendamentoRepository.ExcluirAgendamentoAsync(id);
        }
    }
}
