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
    public class RepositorioSucursal : IRepositorioSucursal
    {
        private LibreriaContext _context;
        public RepositorioSucursal(LibreriaContext context)
        {
            _context = context;
        }
        public void Add(Sucursal obj)
        {
            try
            {
                if (obj == null) { throw new Exception("No se recibio la sucursal"); }
                obj.Validar();


                obj.Id = 0;
                _context.Sucursales.Add(obj);
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

                var sucursal = GetPorId(id);
                _context.Sucursales.Remove(sucursal);
                _context.SaveChanges();

            }
            catch (Exception) { throw; }
        }

        public IEnumerable<Sucursal> GetAll()
        {
            try
            {
                IEnumerable<Sucursal> sucursales = new List<Sucursal>();
                sucursales = _context.Sucursales.ToList();
                return sucursales;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Sucursal GetPorId(int id)
        {
            try
            {
                if (id == 0)
                {
                    throw new Exception("No se recibio id");
                }
                var sucursal = _context.Sucursales.Include(s => s.HorariosAtencion).FirstOrDefault(usr => usr.Id == id);
                if (sucursal == null)
                {
                    throw new Exception("No se encontro ninguna sucursal con ese id");
                }
                return sucursal;

            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Update(Sucursal obj)
        {
            try
            {
                if (obj == null) { throw new Exception("No se recibio sucursal para editar"); }
                obj.Validar();
                _context.Sucursales.Update(obj);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
