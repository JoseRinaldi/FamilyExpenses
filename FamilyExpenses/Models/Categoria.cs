using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyExpenses.Models
{
    // Categoria.cs
    public class Categoria
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public int? UsuarioId { get; set; }
        public Usuario Usuario { get; set; }

        public ICollection<Gasto> Gastos { get; set; }
    }
}
