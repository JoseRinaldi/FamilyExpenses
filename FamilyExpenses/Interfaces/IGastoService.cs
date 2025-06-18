using FamilyExpenses.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyExpenses.Interfaces
{
    public interface IGastoService
    {
        void RegistrarGasto(Gasto gasto);
        IEnumerable<Gasto> ObtenerGastosPorUsuario(int usuarioId);
        IEnumerable<Gasto> ObtenerGastosPorPeriodo(int usuarioId, DateTime inicio, DateTime fin);
        decimal ObtenerTotalGastosPorPeriodo(int usuarioId, DateTime inicio, DateTime fin);
    }
}
