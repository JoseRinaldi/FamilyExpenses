using FamilyExpenses.Interfaces;
using FamilyExpenses.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyExpenses.Services
{
    public class GastoService : IGastoService
    {
        private readonly IGastoRepository _gastoRepository;

        public GastoService(IGastoRepository gastoRepository)
        {
            _gastoRepository = gastoRepository;
        }

        public IEnumerable<Gasto> ObtenerGastosPorPeriodo(int usuarioId, DateTime inicio, DateTime fin)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Gasto> ObtenerGastosPorUsuario(int usuarioId)
        {
            throw new NotImplementedException();
        }

        public decimal ObtenerTotalGastosPorPeriodo(int usuarioId, DateTime inicio, DateTime fin)
        {
            throw new NotImplementedException();
        }

        public void RegistrarGasto(Gasto gasto)
        {
            if (gasto == null) throw new ArgumentNullException(nameof(gasto));
            if (gasto.Monto <= 0) throw new ArgumentException("El monto debe ser mayor a cero");

            _gastoRepository.Add(gasto);
        }

        // Otros métodos...
    }
}
