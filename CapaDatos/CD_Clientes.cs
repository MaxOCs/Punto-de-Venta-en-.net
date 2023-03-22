using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class CD_Clientes
    {
        private CD_Conexion conexion = new CD_Conexion();

        SqlDataReader leer; //LEER FILAS DE LA TABLA
        DataTable tabla = new DataTable(); //Para almacenar las filas de la consulta
        SqlCommand comando = new SqlCommand();//Para ejecutar instrucciones o procedimientos almacenados


        //METODO PARA MOSTRAR CLIENTES
        public DataTable Mostrar()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarClientes";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();

            return tabla;
        }

        //METODO PARA INSERTAR CLIENTES
        public void InsertarRegistro(int CLIRFC, string NOMBRE_U, string DIRECCCION_U, string CORREOELECTRONICO_C, decimal CODIGOPOSTAL_U, decimal TELEFONO_C)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertarClientes";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@CLIRFC", CLIRFC);
            comando.Parameters.AddWithValue("@NOMBRE_C", NOMBRE_U);
            comando.Parameters.AddWithValue("@DIRECCION_C", DIRECCCION_U);
            comando.Parameters.AddWithValue("@CORREOELECTRONICO_C", CORREOELECTRONICO_C);
            comando.Parameters.AddWithValue("@CODIGOPOSTAL_C", CODIGOPOSTAL_U);
            comando.Parameters.AddWithValue("@TELEFONO_C", TELEFONO_C);
            comando.ExecuteNonQuery();
        }

        //METODO PARA EDITAR REGISTROS
        public void EditarRegistro(string DIRECCCION_U, string CORREOELECTRONICO_C, decimal CODIGOPOSTAL_U, decimal TELEFONO_C, int CLIRFC)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EditarCliente";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@DIRECCION_C", DIRECCCION_U);
            comando.Parameters.AddWithValue("@CORREOELECTRONICO_C", CORREOELECTRONICO_C);
            comando.Parameters.AddWithValue("@CODIGOPOSTAL_C", CODIGOPOSTAL_U);
            comando.Parameters.AddWithValue("@TELEFONO_C", TELEFONO_C);
            comando.Parameters.AddWithValue("@CLIRFC", CLIRFC);
            comando.ExecuteNonQuery();
        }

        //METODO PARA ELIMINAR REGISTRO
        public void EliminarRegistro(int CLIRFC)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarCliente";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@CLIRFC", CLIRFC);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        //METODO PARA ACTUALIZAR REGISTRO
        public void ActualizarCliente(int CLIRFC, string NOMBRE_U, string DIRECCCION_U, string CORREOELECTRONICO_C, decimal CODIGOPOSTAL_U, decimal TELEFONO_C)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ActualizarCliente";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@CLIRFC", CLIRFC);
            comando.Parameters.AddWithValue("@NOMBRE_C", NOMBRE_U);
            comando.Parameters.AddWithValue("@DIRECCION_C", DIRECCCION_U);
            comando.Parameters.AddWithValue("@CORREOELECTRONICO_C", CORREOELECTRONICO_C);
            comando.Parameters.AddWithValue("@CODIGOPOSTAL_C", CODIGOPOSTAL_U);
            comando.Parameters.AddWithValue("@TELEFONO_C", TELEFONO_C);
            comando.ExecuteNonQuery();

        }





    }
}
