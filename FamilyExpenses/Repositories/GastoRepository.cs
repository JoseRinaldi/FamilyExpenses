using FamilyExpenses.Interfaces;
using FamilyExpenses.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyExpenses.Repositories
{
    public class GastoRepository : IGastoRepository
    {
        private readonly FamilyExpensesDbContext _context;

        public GastoRepository(FamilyExpensesDbContext context)
        {
            _context = context;
        }

        // Implementación de los métodos
        public void Add(Gasto gasto)
        {
            _context.Gastos.Add(gasto);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Gasto GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Gasto> GetByUsuario(int usuarioId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Gasto> GetByUsuarioAndDateRange(int usuarioId, DateTime start, DateTime end)
        {
            throw new NotImplementedException();
        }

        public void Update(Gasto gasto)
        {
            throw new NotImplementedException();
        }

        // Otros métodos...
    }
}
