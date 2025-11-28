using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.DTO
{
    public class CalendarioDTO
    {

        public List<ReservaDTO> Reservas { get; set; }

        public string TipoServicio { get; set; }

        public string Servicio { get; set; }

        public int DuracionMinutosTurno { get; set; }
        public List<HorariosSemanaDTO> HorariosSemana { get; set; } = new List<HorariosSemanaDTO>();

    }
}
