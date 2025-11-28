using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public  class EmpleadoTurnoServicio
    {
  
        public int Id { get; set; }
        public Empleado Empleado { get; set; }
        public int EmpleadoId { get; set; }
        public DateOnly Fecha { get; set; }
        public TimeOnly HoraInicio { get; set; }
        public TimeOnly HoraFin { get; set; }
        public Servicio Servicio { get; set; }
        public int ServicioId { get; set; }
        public int ReservaId { get; set; }
        public Reserva Reserva { get; set; }
        public EmpleadoTurnoServicio() { }
    }
}
