using LogicaNegocio;
using LogicaNegocio.InterfacesRepositorios;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDatos.EF
{
    public class RepositorioEmpleado : IRepositorioEmpleado
    {
        private LibreriaContext _context;
        public RepositorioEmpleado(LibreriaContext context)
        {
            _context = context;
        }
        public void Add(Empleado obj)
        {
            try
            {
                if (obj == null) { throw new Exception("No se recibio el empleado"); }
                obj.Validar();


                obj.Id = 0;
                _context.Empleados.Add(obj);
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

                var empleado = GetPorId(id);
                _context.Empleados.Remove(empleado);
                _context.SaveChanges();

            }
            catch (Exception) { throw; }
        }

        public IEnumerable<Empleado> GetAll()
        {
            try
            {
                IEnumerable<Empleado> empleados = new List<Empleado>();
                empleados = _context.Empleados.ToList();
                return empleados;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Empleado GetPorId(int id)
        {
            try
            {
                if (id == 0)
                {
                    throw new Exception("No se recibio id");
                }
                var empleado = _context.Empleados.Include(e=>e.HorariosJornada).FirstOrDefault(usr => usr.Id == id);
                if (empleado == null)
                {
                    throw new Exception("No se encontro ningun empleado con ese id");
                }
                return empleado;

            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Update(Empleado obj)
        {
            try
            {
                if (obj == null) { throw new Exception("No se recibio empleado para editar"); }
                obj.Validar();
                _context.Empleados.Update(obj);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
