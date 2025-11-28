using LogicaNegocio.InterfacesDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class TipoServicio : IValidar
    {
        public int Id { get; set;}
        public string Nombre { get; set;}
        public Negocio Negocio { get; set; }
        public int NegocioId { get; set; }

        public TipoServicio() { }

        public void Validar()
        {
        
        }
    }
}
