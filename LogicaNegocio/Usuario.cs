using LogicaNegocio.InterfacesDominio;

namespace LogicaNegocio
{
    public class Usuario : IValidar
    {
        public int Id { get; set; }
        public string Nombre { get; set; }    
        public string Usr { get; set; }
        public string Mail { get; set; } 
        public string Password { get; set; }
        public TipoUsuario Tipo { get; set; }  
        public Usuario() { }
        public Usuario (string name, string mail, string password, string usr, TipoUsuario tipo)
        {
        
            Nombre = name;
            Mail = mail;
            Password = password;
            Usr = usr;
            Tipo = tipo;    
        }

        public void Validar()
        {
            
        }
    }
}
