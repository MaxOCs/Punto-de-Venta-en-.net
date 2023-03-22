using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace CapaDatos
{
    public class CD_Usuario
    {
        private CD_Conexion conexion = new CD_Conexion();

        SqlDataReader leer; //LEER FILAS DE LA TABLA
        DataTable tabla = new DataTable(); //Para almacenar las filas de la consulta
        SqlCommand comando = new SqlCommand();//Para ejecutar instrucciones o procedimientos almacenados

        public DataTable Mostrar()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarUsuarios";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();

            return tabla;
        }

        public void InsertarRegistro(string URFC, string NOMBRE_U, string DIRECCCION_U, string CURP_U, string CODIGOPOSTAL_U, string CIUDAD_U, DateTime FECHANACI_U, decimal TELEFONO_U, string PREGUNTA_U, string RESPUESTA_U, string USUARIO_U, string CONTRASEÑA_U, string TIPO_U)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "insert into USUARIOS values("+URFC+", "+NOMBRE_U+","+DIRECCCION_U+", "+CURP_U + ", " + CODIGOPOSTAL_U + ", "+CIUDAD_U + ", " + FECHANACI_U + ", " + TELEFONO_U + ", " + PREGUNTA_U + "," + RESPUESTA_U + ", " + USUARIO_U + ", " + CONTRASEÑA_U + ", " + TIPO_U + ")";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
        }

    }
}
