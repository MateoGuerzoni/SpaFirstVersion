using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.InterfacesRepositorios
{
    public interface IRepositorioNegocio : IRepositorio<Negocio>
    {
        public Negocio GetPorUsuario(string usr);
        public Negocio GetPorUsrConListas(string usr);

    }
}
