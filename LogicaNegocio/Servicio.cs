using LogicaNegocio.InterfacesDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class Servicio:IValidar
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int DuracionMinutos { get; set; }
        public bool Multitask { get; set; } = true;
        public TipoServicio Tipo { get; set; }
        public int TipoId { get; set; }
        public Negocio Negocio { get; set; }
        public int NegocioId { get; set; }
        public double? Precio { get; set; }

        public Servicio() { }
        public Servicio(int id, string nombre)
        {
            Id = id;
            Nombre = nombre;
        }

        public void Validar()
        {
          
        }
    }
}
