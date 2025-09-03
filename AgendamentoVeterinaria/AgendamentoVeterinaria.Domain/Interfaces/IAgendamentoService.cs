using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgendamentoVeterinaria.Domain.Entities;

namespace AgendamentoVeterinaria.Domain.Interfaces
{
    public interface IAgendamentoService
    {
        Task<List<AgendamentoConsulta>> ListarTodos();
    }
}
