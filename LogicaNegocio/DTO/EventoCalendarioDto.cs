using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.DTO
{
    public class EventoCalendarioDto
    {
        public int sucursalId { get; set; }
        public int servicioId { get; set; } 
        public string negocioUsr {  get; set; }    
        public int empleadoId { get; set; }
    }
}
