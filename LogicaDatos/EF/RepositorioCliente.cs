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
    public class RepositorioCliente : IRepositorioCliente
    {
        private LibreriaContext _context;
        public RepositorioCliente(LibreriaContext context)
        {
            _context = context;
        }
        public void Add(Cliente obj)
        {
           try
            {
                if (obj == null) { throw new Exception("No se recibio el cliente"); }
                obj.Validar();
             

                obj.Id = 0;
                _context.Clientes.Add(obj);
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

                var cliente = GetPorId(id);
                _context.Clientes.Remove(cliente);
                _context.SaveChanges();

            }
            catch (Exception) { throw; }
        }

        public IEnumerable<Cliente> GetAll()
        {
            try
            {
                IEnumerable<Cliente> clientes = new List<Cliente>();
                clientes = _context.Clientes.ToList();
                return clientes;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Cliente GetPorId(int id)
        {
            try
            {
                if (id == 0)
                {
                    throw new Exception("No se recibio id");
                }
                var cliente = _context.Clientes.FirstOrDefault(usr => usr.Id == id);
                if (cliente == null)
                {
                    throw new Exception("No se encontro ningun cliente con ese id");
                }
                return cliente;

            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Update(Cliente obj)
        {
            try
            {
                if (obj == null) { throw new Exception("No se recibio cliente para editar"); }
                obj.Validar();
                _context.Clientes.Update(obj);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
