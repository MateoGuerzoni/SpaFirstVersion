using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.InterfacesRepositorios
{
    public interface IRepositorioServicio : IRepositorio<Servicio>
    {

        public IEnumerable<TipoServicio> GetTipos();
        public TipoServicio GetTipoServicioPorId(int id);
        public void AddTipo(TipoServicio obj);
        public void UpdateTipo(TipoServicio obj);
    }
}
