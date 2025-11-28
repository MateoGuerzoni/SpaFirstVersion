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
    public class RepositorioServicio : IRepositorioServicio
    {

        private LibreriaContext _context;
        public RepositorioServicio(LibreriaContext context)
        {
            _context = context;
        }

        public void Add(Servicio obj)
        {
            try
            {
                if (obj == null) { throw new Exception("No se recibio el servicio"); }
                obj.Validar();


                obj.Id = 0;
                _context.Servicios.Add(obj);
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

                var servicio = GetPorId(id);
                _context.Servicios.Remove(servicio);
                _context.SaveChanges();

            }
            catch (Exception) { throw; }
        }

        public IEnumerable<Servicio> GetAll()
        {
            try
            {
                IEnumerable<Servicio> servicios = new List<Servicio>();
                servicios = _context.Servicios.ToList();
                return servicios;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Servicio GetPorId(int id)
        {
            try
            {
                if (id == 0)
                {
                    throw new Exception("No se recibio id");
                }
                var servicio = _context.Servicios.Include(s => s.Tipo).FirstOrDefault(usr => usr.Id == id);
                if (servicio == null)
                {
                    throw new Exception("No se encontro ningun servicio con ese id");
                }
                return servicio;

            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Update(Servicio obj)
        {
            try
            {
                if (obj == null) { throw new Exception("No se recibio servicio para editar"); }
                obj.Validar();
                _context.Servicios.Update(obj);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void AddTipo(TipoServicio obj)
        {
            try
            {
                if (obj == null) { throw new Exception("No se recibio el tipo de servicio"); }
                obj.Validar();
                obj.Id = 0;
                _context.TipoServicios.Add(obj);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void UpdateTipo(TipoServicio obj)
        {
            try
            {
                if (obj == null) { throw new Exception("No se recibio el tipo de servicio"); }
                obj.Validar();
                _context.TipoServicios.Update(obj);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IEnumerable<TipoServicio> GetTipos()
        {
            try
            {
                IEnumerable<TipoServicio> tipos = new List<TipoServicio>();
                tipos = _context.TipoServicios.ToList();
                return tipos;
            }
            catch (Exception)
            {

                throw;
            }


        }


        public TipoServicio GetTipoServicioPorId(int id)
        {
            try
            {
                if (id == 0)
                {
                    throw new Exception("No se recibio id");
                }
                var tipo = _context.TipoServicios.FirstOrDefault(usr => usr.Id == id);
                if (tipo == null)
                {
                    throw new Exception("No se encontro ningun TipoServicio con ese id");
                }
                return tipo;

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
