using FamilyExpenses.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyExpenses.Interfaces
{
    public interface IGastoRepository
    {
        void Add(Gasto gasto);
        void Update(Gasto gasto);
        void Delete(int id);
        Gasto GetById(int id);
        IEnumerable<Gasto> GetByUsuario(int usuarioId);
        IEnumerable<Gasto> GetByUsuarioAndDateRange(int usuarioId, DateTime start, DateTime end);
    }
}
