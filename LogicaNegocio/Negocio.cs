using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class Negocio : Usuario
    {
        public string RUT;
        public List<TipoServicio> TipoServicios { get; set; } = new List<TipoServicio>();
        public List<Servicio> Servicios { get; set; } = new List<Servicio>();
        public List<Sucursal> Sucursales { get; set; } = new List<Sucursal>();
        public List<Empleado> Empleados { get; set; } = new List<Empleado>();


        public Negocio() { }
        public Negocio( string name, string mail, string password, string usr, TipoUsuario tipo) : base(name, mail, password,  usr,  tipo)
        {

        }
        public Negocio(string name, string mail, string password, string rut, string usr, TipoUsuario tipo) : base( name, mail, password,  usr,  tipo)
        {
            RUT = rut;
        }

     
    }
}
