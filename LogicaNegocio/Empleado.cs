using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class Empleado:Usuario
    {
        public List<HorarioDia> HorariosJornada { get; set; } = new List<HorarioDia>();
        public Negocio Negocio { get; set; }
        public int NegocioId { get; set; }

        public Empleado() { }

        public Empleado(string name, string mail, string password, string usr, TipoUsuario tipo) : base(name, mail, password,  usr,  tipo)
        {
           
        }
    }
}
