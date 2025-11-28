using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicaNegocio;
using LogicaNegocio.InterfacesRepositorios;


namespace LogicaDatos.EF
{
    public class RepositorioUsuario : IRepositorioUsuario
    {
        private LibreriaContext _context;
        public RepositorioUsuario(LibreriaContext context)
        {
            _context = context;
        }

        public void Add(Usuario obj)
        {
            try
            {
                if (obj == null) { throw new Exception("No se recibio el usuario"); }
                obj.Validar();
             

                obj.Id = 0;
                _context.Usuarios.Add(obj);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public TipoUsuario Login(string usuario, string contrasenia)
        {
            try
            {
                TipoUsuario tipoUsuario = TipoUsuario.Cliente;
                bool Vmail = false;
                bool Vcontra = false;
                IEnumerable<Usuario> usuarios = _context.Usuarios.ToList();
                foreach (Usuario u in usuarios)
                {
                    if (u.Usr == usuario || u.Mail == usuario)
                    {
                        Vmail = true;
                        if (u.Password == contrasenia)
                        {
                            tipoUsuario = u.Tipo;
                            Vcontra = true;
                        }

                    }
                }
                if (Vcontra == false && Vmail)
                {
                    throw new Exception("Contraseña Incorrecta");
                }
                else if (Vmail == false)
                {
                    throw new Exception("Usuario Incorrecto");
                }
                return tipoUsuario;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void AddAdministrador(Admin admin) {

            try
            {
                if (admin == null) { throw new Exception("No se recibio el usuario"); }
                admin.Validar();


                admin.Id = 0;
                _context.Administradores.Add(admin);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

       
        public void Delete(int id)
        {
            try
            {

                var usuario = GetPorId(id);
                _context.Usuarios.Remove(usuario);
                _context.SaveChanges();

            }
            catch (Exception) { throw; }
        }

        public IEnumerable<Usuario> GetAll()
        {
            try
            {
                IEnumerable<Usuario> usuarios = new List<Usuario>();
                usuarios = _context.Usuarios.ToList();
                return usuarios;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Usuario GetPorId(int id)
        {
            try
            {
                if (id == 0)
                {
                    throw new Exception("No se recibio id");
                }
                var usuario = _context.Usuarios.FirstOrDefault(usr => usr.Id == id);
                if (usuario == null)
                {
                    throw new Exception("No se encontro ningun usuario con ese id");
                }
                return usuario;

            }
            catch (Exception)
            {
                throw;
            }
        }

        public Usuario GetPorUsuario(string usr)
        {

            try
            {
                if (String.IsNullOrEmpty(usr))
                {
                    throw new Exception("No se recibio usuario");
                }
                var usuario = _context.Usuarios.FirstOrDefault(u => u.Usr == usr);
                if (usuario == null)
                {
                    usuario = _context.Usuarios.FirstOrDefault(u => u.Mail == usr);
                    if (usuario == null)
                    {
                        throw new Exception("No se encontro ningun usuario con ese nombre");
                    }
                }
                return usuario;

            }
            catch (Exception)
            {
                throw;
            }

        }


        public void Update(Usuario obj)
        {
            try
            {
                if (obj == null) { throw new Exception("No se recibio usuario para editar"); }
                obj.Validar();
                _context.Usuarios.Update(obj);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
