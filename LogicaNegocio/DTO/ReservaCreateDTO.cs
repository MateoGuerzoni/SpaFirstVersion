using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.DTO
{
    public class ReservaCreateDTO
    {
        public List<TurnoCreateDTO> turnos { get; set; }
        public string cliente { get; set; }
        public int sucursal { get; set; }
        public string negocioUsr { get; set; }
    }
}
