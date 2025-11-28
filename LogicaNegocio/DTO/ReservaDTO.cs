using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.DTO
{
    public class ReservaDTO
    {
        public DateOnly Fecha { get; set; } // "2025-04-01"
        public TimeOnly HoraInicio { get; set; } // "08:00"
        public TimeOnly HoraFin { get; set; } // "09:00"
        public string Empleado { get; set; }

        public string Servicio { get; set; }
        public int idReserva { get; set; }

    }
}
