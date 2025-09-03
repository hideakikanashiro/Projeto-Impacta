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
            return await _context.AgendamentoVet.ToListAsync();
        }
    }
}