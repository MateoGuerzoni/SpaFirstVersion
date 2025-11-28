using LogicaNegocio.InterfacesDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class Reserva : IValidar
    {
        public int Id { get; set; }
        public Negocio Negocio { get; set; }
        public int NegocioId { get; set; }

        public Cliente? Cliente { get; set; }
        public int? ClienteId { get; set; }
        public string NombreCliente { get; set; }

        public List<EmpleadoTurnoServicio> EmpleadosTurnos { get; set; }

        public Sucursal Sucursal { get; set; }

        public int SucursalId { get; set; }
        public string? Comentarios {  get; set; }

        public Reserva() { }

        public void Validar()
        {
           
        }
    }
}
