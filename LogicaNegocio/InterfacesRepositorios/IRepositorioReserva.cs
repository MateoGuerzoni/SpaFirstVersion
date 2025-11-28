using LogicaNegocio.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.InterfacesRepositorios
{
    public interface IRepositorioReserva : IRepositorio<Reserva>
    {
        public List<ReservaDTO> ObtenerReservasDtoFiltrado(int idSucursal, int idServicio, string usrNegocio, int idEmpleado);
        Reserva GetPorIdConServicios(int id);
    }
}
