using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class HorarioDia
    {
        public DiaSemana Dia { get; set; } 
        public TimeOnly HoraInicio { get; set; }
        public TimeOnly HoraFin { get; set; }

        public HorarioDia() { }

        public HorarioDia(DiaSemana dia) {
            Dia = dia;
            HoraInicio = new TimeOnly();    
            HoraFin = new TimeOnly();   
        }
    }
}
