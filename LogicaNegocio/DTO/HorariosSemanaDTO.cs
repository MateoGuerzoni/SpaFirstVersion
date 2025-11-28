using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.DTO
{
    public class HorariosSemanaDTO
    {

        public string dia { get; set; }
        public TimeOnly horaInicio { get; set; }
        public TimeOnly horaFin { get; set; }

        public HorariosSemanaDTO() { }
        public HorariosSemanaDTO(string dia, TimeOnly hi, TimeOnly hf) {
            this.dia = dia; 
            this.horaInicio = hi;   
            this.horaFin = hf;
        
        }
    }
}
