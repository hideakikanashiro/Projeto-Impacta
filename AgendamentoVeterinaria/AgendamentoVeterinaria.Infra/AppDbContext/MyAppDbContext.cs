using Microsoft.EntityFrameworkCore;
using AgendamentoVeterinaria.Domain.Entities;

namespace AgendamentoVeterinaria.Infra.AppDbContext
{
    public class MyAppDbContext:DbContext
    {
        public MyAppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<AgendamentoConsulta> AgendamentoVet { get; set; }
    }
}
