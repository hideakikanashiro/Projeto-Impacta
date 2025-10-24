using AgendamentoVeterinaria.Domain.Entities;
using AgendamentoVeterinaria.Domain.Interfaces;
using AgendamentoVeterinaria.Infra.AppDbContext;
using Microsoft.EntityFrameworkCore;

namespace AgendamentoVeterinaria.Infra.Repositories
{
    public class AgendamentoRepository : IAgendamentoRepository
    {
        private readonly MyAppDbContext _context;

        public AgendamentoRepository(MyAppDbContext context)
        {
            _context = context;
        }

        public async Task<List<AgendamentoConsulta>> ListarTodosAsync()
        {
            return await _context.AgendamentoVet
                .OrderBy(x => x.DataAgendamento)
                .ToListAsync();
        }

        public async Task<AgendamentoConsulta?> BuscarAgendamentoPorId(int id)
        {
            return await _context.AgendamentoVet
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task CadastrarAgendamentoAsync(AgendamentoConsulta agendamento)
        {
            await _context.AgendamentoVet.AddAsync(agendamento);
            await _context.SaveChangesAsync();
        }

        public async Task AtualizarAgendamentoAsync(AgendamentoConsulta agendamento)
        {
            agendamento.DataEntrada = DateTime.Now;
            _context.AgendamentoVet.Update(agendamento);
            await _context.SaveChangesAsync();
        }

        public async Task ExcluirAgendamentoAsync(int id)
        {
            var agendamentoId = await _context.AgendamentoVet.FindAsync(id);
            if (agendamentoId != null)
            {
                _context.AgendamentoVet.Remove(agendamentoId);
                await _context.SaveChangesAsync();
            }
        }
    }
}
