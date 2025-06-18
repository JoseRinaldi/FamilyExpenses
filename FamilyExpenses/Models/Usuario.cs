using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyExpenses.Models
{
    // Usuario.cs
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Contrasena { get; set; }
        public DateTime FechaCreacion { get; set; }
        public bool Activo { get; set; }

        public ICollection<Categoria> Categorias { get; set; }
        public ICollection<Gasto> Gastos { get; set; }
    }
}
