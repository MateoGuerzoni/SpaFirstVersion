using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.SignalR
{
    public class UsuariosConectados
    {

        public static List<ConexionSignalR> usuariosConectados = new List<ConexionSignalR>(); //Listado de los usuarios conectados a las vistas de SignalR

        public static string GetIdConexionDeUsuario(string nombreUsuario)
        {
            foreach (ConexionSignalR c in usuariosConectados)
            {

                if (c.nombreUsuario.Equals(nombreUsuario))
                {
                    return c.idConexion;

                }
            }

            return "";
        }

        public static void BorrarConexionPorId(string idConexion)
        {

            for (int i = 0; i < usuariosConectados.Count(); i++)
            {

                if (usuariosConectados[i].idConexion.Equals(idConexion))
                {

                    usuariosConectados.RemoveAt(i);

                }


            }


        }
    }
}
