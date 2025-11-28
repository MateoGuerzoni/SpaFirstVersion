using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.SignalR
{
    public class ConexionSignalR
    {
        public string idConexion { get; set; }
        public string nombreUsuario { get; set; }

        public ConexionSignalR() { }
        public ConexionSignalR(string idConexion, string nombreUsuario)
        {
            this.idConexion = idConexion;
            this.nombreUsuario = nombreUsuario;
        }

    }
}
