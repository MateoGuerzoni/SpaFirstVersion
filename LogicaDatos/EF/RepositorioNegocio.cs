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
    public class RepositorioNegocio : IRepositorioNegocio
    {
        private LibreriaContext _context;
        public RepositorioNegocio(LibreriaContext context)
        {
            _context = context;
        }
        public void Add(Negocio obj)
        {
            try
            {
                if (obj == null) { throw new Exception("No se recibio el negocio"); }
                obj.Validar();


                obj.Id = 0;
                _context.Negocios.Add(obj);
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

                var negocio = GetPorId(id);
                _context.Negocios.Remove(negocio);
                _context.SaveChanges();

            }
            catch (Exception) { throw; }
        }

        public IEnumerable<Negocio> GetAll()
        {
            try
            {
                IEnumerable<Negocio> negocios = new List<Negocio>();
                negocios = _context.Negocios.ToList();
                return negocios;
            }
            catch (Exception)
            {

                throw;
            }
        }
        //Basicamente este es como el get por usuario, pero hace todos los selects para retornar ademas todas las listas que contiene negocio(La operacion es mas costosa a nivel de BD por lo que no se tiene que usar siempre)
        public Negocio GetPorUsrConListas(string usr) {

            try
            {

                if (String.IsNullOrEmpty(usr))
                {
                    throw new Exception("No se recibio usuario");
                }
                Negocio usuario = _context.Negocios.Include(n => n.Empleados).Include(n => n.Sucursales).Include(n => n.Servicios).Include(n => n.TipoServicios).FirstOrDefault(u => u.Usr == usr);
                if (usuario == null)
                {
                    usuario = _context.Negocios.Include(n => n.Empleados).Include(n => n.Sucursales).Include(n => n.Servicios).Include(n => n.TipoServicios).FirstOrDefault(u => u.Mail == usr);
                    if (usuario == null)
                    {
                        throw new Exception("No se encontro ningun negocio con ese nombre");
                    }
                }
                return usuario;


            }
            catch (Exception)
            {
                throw;
            }




        }

        public Negocio GetPorId(int id)
        {
            try
            {
                if (id == 0)
                {
                    throw new Exception("No se recibio id");
                }
                var negocios = _context.Negocios.FirstOrDefault(usr => usr.Id == id);
                if (negocios == null)
                {
                    throw new Exception("No se encontro ningun negocios con ese id");
                }
                return negocios;

            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Update(Negocio obj)
        {
            try
            {
                if (obj == null) { throw new Exception("No se recibio negocio para editar"); }
                obj.Validar();
                _context.Negocios.Update(obj);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Negocio GetPorUsuario(string usr)
        {

            try
            {
                if (String.IsNullOrEmpty(usr))
                {
                    throw new Exception("No se recibio usuario");
                }
                Negocio usuario = _context.Negocios.FirstOrDefault(u => u.Usr == usr);
                if (usuario == null)
                {
                    usuario = _context.Negocios.FirstOrDefault(u => u.Mail == usr);
                    if (usuario == null)
                    {
                        throw new Exception("No se encontro ningun negocio con ese nombre");
                    }
                }
                return usuario;

            }
            catch (Exception)
            {
                throw;
            }

        }

    }
}
