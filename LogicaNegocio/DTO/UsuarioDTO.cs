using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.DTO
{
    public class UsuarioDTO
    {

        public TipoUsuario Tipo { get; set; }
        //PROPIEDADES DE USUARIO

        public string Usr { get; set; }
        public string Nombre { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }

        //PROPIEDADES DE NEGOCIO
        public string? RUT;

        //PROPIEDADES DE EMPLEADO

        //PROPIEDADES DE CLIENTE
        public string? Telefono { get; set; }
        public DateOnly? FechaNacimiento { get; set; }


        public UsuarioDTO() { }


        public Usuario CrearUsuario() { 
        
        Usuario usr = new Usuario();
            usr.Usr = Usr;
            usr.Nombre = Nombre;
            usr.Mail = Mail;
            usr.Password = Password;
            usr.Tipo = Tipo;
          

            return usr;
        
        }   

        
    }
}
