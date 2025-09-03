using AgendamentoVeterinaria.Domain.Entities;
using AgendamentoVeterinaria.Domain.Interfaces;

namespace AgendamentoVeterinaria.Domain.Services
{
    public class AgendamentoService : IAgendamentoService
    {
        // 1. Crie uma variável para guardar a referência do repositório
        private readonly IAgendamentoRepository _agendamentoRepository;

        // 2. Injete o repositório no construtor
        public AgendamentoService(IAgendamentoRepository agendamentoRepository)
        {
            _agendamentoRepository = agendamentoRepository;
        }

        // 3. Implemente o método da interface
        public async Task<List<AgendamentoConsulta>> ListarTodos()
        {
            // 4. Chame o método do repositório para buscar os dados
            return await _agendamentoRepository.ListarTodosAsync();
        }
    }
}