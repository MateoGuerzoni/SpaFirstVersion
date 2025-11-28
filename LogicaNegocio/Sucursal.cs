using LogicaNegocio.InterfacesDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class Sucursal:IValidar
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public Negocio Negocio { get; set; }
        public int NegocioId { get; set; }

        public List<HorarioDia> HorariosAtencion { get; set; } = new List<HorarioDia>();
        public Sucursal() { }
        public Sucursal(int id, string nombre, string direccion)
        {
            Id = id;
            Nombre = nombre;
            Direccion = direccion;
        }

        public void Validar()
        {
        
        }
    }
}
