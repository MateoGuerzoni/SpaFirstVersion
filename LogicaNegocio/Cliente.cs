using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class Cliente : Usuario
    {
        public string CI { get; set; }
        public string Telefono { get; set; }
        public DateOnly FechaNacimiento { get; set; }
        public Cliente() {}
        public Cliente(string name, string mail, string password, string usr, TipoUsuario tipo) :base(name, mail, password, usr, tipo){
            
        }
        public Cliente( string name, string mail, string password,string ci, string usr, TipoUsuario tipo, string telefono, DateOnly fechaNacimiento) : base( name, mail, password, usr,  tipo)
        {
            CI = ci;
            Telefono = telefono;
            FechaNacimiento = fechaNacimiento;
        }
    }
}
