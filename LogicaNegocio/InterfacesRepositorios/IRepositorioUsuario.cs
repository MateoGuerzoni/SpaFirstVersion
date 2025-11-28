using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.InterfacesRepositorios
{
    public interface IRepositorioUsuario : IRepositorio<Usuario>
    {
        public TipoUsuario Login(string usuario, string contrasenia);

        public Usuario GetPorUsuario(string usr);
    }
}
