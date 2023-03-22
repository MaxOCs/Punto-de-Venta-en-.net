using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Clientes
    {
        private CD_Clientes objetoCD = new CD_Clientes();

        public DataTable MostrarCliente()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
            return tabla;
        }

        public void InsertarRegistro(string CLIRFC, string NOMBRE_U, string DIRECCCION_U, string CORREOELECTRONICO_C, string CODIGOPOSTAL_U, string TELEFONO_C)
        {
            objetoCD.InsertarRegistro(Convert.ToInt32(CLIRFC), NOMBRE_U, DIRECCCION_U, CORREOELECTRONICO_C, Convert.ToDecimal(CODIGOPOSTAL_U), Convert.ToDecimal(TELEFONO_C));
        }

        public void EditarCliente(string DIRECCCION_U, string CORREOELECTRONICO_C, string CODIGOPOSTAL_U, string TELEFONO_C, string CLIRFC)
        {
            objetoCD.EditarRegistro(DIRECCCION_U, CORREOELECTRONICO_C, Convert.ToDecimal(CODIGOPOSTAL_U), Convert.ToDecimal(TELEFONO_C), Convert.ToInt32(CLIRFC));
        }

        public void EliminarCliente(string CLIRFC)
        {
            objetoCD.EliminarRegistro(Convert.ToInt32(CLIRFC));
        }

        public void ActualizarCliente(string CLIRFC, string NOMBRE_U, string DIRECCCION_U, string CORREOELECTRONICO_C, string CODIGOPOSTAL_U, string TELEFONO_C)
        {
            objetoCD.ActualizarCliente(Convert.ToInt32(CLIRFC), NOMBRE_U, DIRECCCION_U, CORREOELECTRONICO_C, Convert.ToDecimal(CODIGOPOSTAL_U), Convert.ToDecimal(TELEFONO_C));

        }


    }
}
