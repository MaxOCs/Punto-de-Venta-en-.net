using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_Usuario
    {
        private CD_Usuario objetoCD = new CD_Usuario();

        public DataTable MostrarUsuario()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
            return tabla;
        }

        public void InsertarRegistro(string URFC, string NOMBRE_U, string DIRECCCION_U, string CURP_U, string CODIGOPOSTAL_U, string CIUDAD_U, string FECHANACI_U, string TELEFONO_U, string PREGUNTA_U, string RESPUESTA_U, string USUARIO_U, string CONTRASEÑA_U, string TIPO_U)
        {
            objetoCD.InsertarRegistro(URFC, NOMBRE_U, DIRECCCION_U, CURP_U, CODIGOPOSTAL_U, CIUDAD_U, Convert.ToDateTime(FECHANACI_U), Convert.ToDecimal(TELEFONO_U), PREGUNTA_U, RESPUESTA_U, USUARIO_U, CONTRASEÑA_U, TIPO_U);
           
        }

   
    }
}
