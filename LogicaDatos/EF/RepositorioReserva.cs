using LogicaNegocio;
using LogicaNegocio.DTO;
using LogicaNegocio.InterfacesRepositorios;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDatos.EF
{
    public class RepositorioReserva : IRepositorioReserva
    {
        private LibreriaContext _context;
        public RepositorioReserva(LibreriaContext context)
        {
            _context = context;
        }
        public void Add(Reserva obj)
        {
            try
            {
                if (obj == null) { throw new Exception("No se recibio la reserva"); }
                obj.Validar();


                obj.Id = 0;
                _context.Reservas.Add(obj);
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

                var reserva = GetPorId(id);
                _context.Reservas.Remove(reserva);
                _context.SaveChanges();

            }
            catch (Exception) { throw; }
        }

        public IEnumerable<Reserva> GetAll()
        {
            try
            {
                IEnumerable<Reserva> reservas = new List<Reserva>();
                reservas = _context.Reservas.ToList();
                return reservas;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Reserva GetPorIdConServicios(int id)
        {
            try
            {
                if (id == 0)
                {
                    throw new Exception("No se recibio id");
                }
                var reserva = _context.Reservas
    .Include(r => r.EmpleadosTurnos)
        .ThenInclude(ets => ets.Empleado)
    .Include(r => r.EmpleadosTurnos)
        .ThenInclude(ets => ets.Servicio)
    .Include(r => r.Sucursal)
    .Include(r => r.Cliente)
    .FirstOrDefault(r => r.Id == id);
                if (reserva == null)
                {
                    throw new Exception("No se encontro ninguna reserva con ese id");
                }
                return reserva;

            }
            catch (Exception)
            {
                throw;
            }
        }

        public Reserva GetPorId(int id)
        {
            try
            {
                if (id == 0)
                {
                    throw new Exception("No se recibio id");
                }
                var reserva = _context.Reservas.FirstOrDefault(usr => usr.Id == id);
                if (reserva == null)
                {
                    throw new Exception("No se encontro ninguna reserva con ese id");
                }
                return reserva;

            }
            catch (Exception)
            {
                throw;
            }
        }



        public void Update(Reserva obj)
        {
            try
            {
                if (obj == null) { throw new Exception("No se recibio reserva para editar"); }
                obj.Validar();
                _context.Reservas.Update(obj);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }



        //PRE: si recibe un id 0 filtra por "todos", si recibe id filtra por ese id
        public List<ReservaDTO> ObtenerReservasDtoFiltrado(int idSucursal, int idServicio, string usrNegocio, int idEmpleado)
        {
            try
            {
                var reservas = _context.Reservas
                    .Include(r => r.EmpleadosTurnos)
                        .ThenInclude(ets => ets.Empleado)
                    .Include(r => r.EmpleadosTurnos)
                        .ThenInclude(ets => ets.Servicio) 
                    .Include(r => r.Negocio)
                    .Where(r =>
                        (idSucursal == 0 || r.SucursalId == idSucursal) &&
                        r.Negocio.Usr == usrNegocio &&
                        r.EmpleadosTurnos.Any(ets =>
                            (idServicio == 0 || ets.ServicioId == idServicio) &&
                            (idEmpleado == 0 || ets.EmpleadoId == idEmpleado)
                        )
                    )
                    .SelectMany(r => r.EmpleadosTurnos
                        .Where(ets =>
                            (idServicio == 0 || ets.ServicioId == idServicio) &&
                            (idEmpleado == 0 || ets.EmpleadoId == idEmpleado)
                        )
                        .Select(ets => new ReservaDTO
                        {
                            Fecha = ets.Fecha,
                            HoraInicio = ets.HoraInicio,
                            HoraFin = ets.HoraFin,
                            Empleado = ets.Empleado.Nombre,
                            Servicio = ets.Servicio.Nombre,
                            idReserva = r.Id
                        })
                    )
                    .ToList();

                return reservas;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
