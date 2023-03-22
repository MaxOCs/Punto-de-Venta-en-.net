using CapaDatos;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PEscritorio
{
    public partial class CClientes : Form
    {
      
        CN_Clientes objetoCNCliente = new CN_Clientes();


        private CD_Conexion conexion1 = new CD_Conexion();

        SqlDataReader leer; //LEER FILAS DE LA TABLA
        DataTable tabla = new DataTable(); //Para almacenar las filas de la consulta
        SqlCommand comando = new SqlCommand();//Para ejecutar instrucciones o procedimientos almacenados


        public void Desaparecer()
        {
          
        }
        private void MostrarClientes()
        {
            dgvClientes.DataSource = objetoCNCliente.MostrarCliente();
        }


       

        private void BtnCClie_Click(object sender, EventArgs e)
        {
            Desaparecer();
        }

       

        private void BtnRClie_Click(object sender, EventArgs e)
        {
            RClientes PantallaRClie = new RClientes();
            this.Close();
            PantallaRClie.ShowDialog();
        }

        private void BtnCPintura_Click(object sender, EventArgs e)
        {
            CPintura CPintura = new CPintura();
            this.Close();
            CPintura.ShowDialog();
        }

        private void BtnCMaterias_Click(object sender, EventArgs e)
        {
            CMateriales CMateriales = new CMateriales();
            this.Close();
            CMateriales.ShowDialog();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     
        private void BtnCCompras_Click_1(object sender, EventArgs e)
        {
            CCompras PantallasCCompra = new CCompras();
            this.Close();
            PantallasCCompra.ShowDialog();
        }

        private void BtnCVenta_Click(object sender, EventArgs e)
        {
            CVentas CVentas = new CVentas();
            this.Close();
            CVentas.ShowDialog();
        }

        private void BtnReportes_Click(object sender, EventArgs e)
        {
            ReprtesVentas PantallaReprtesVentas = new ReprtesVentas();
            this.Close();
            PantallaReprtesVentas.ShowDialog();
        }

        public CClientes()
        {
            InitializeComponent();
            
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            Ventas PantallaVentas = new Ventas();
            this.Close();
            PantallaVentas.ShowDialog();
        }

       
        private void CClientes_Load(object sender, EventArgs e)
        {
            MostrarClientes();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //PENDIENTE
            if (dgvClientes.SelectedRows.Count > 0)
            {
                RClientes pantallaClientesRegistro = new RClientes();
                pantallaClientesRegistro.Show();

            }
        }
        private void MostrarNombre()
        {
            dgvClientes.DataSource = BuscarClienteNombre(txtBuscar.Text);
            dgvClientes.Refresh();

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbOpc.SelectedIndex == 0)
                {


                }
                if (cbOpc.SelectedIndex == 1)
                {
                  
                        MostrarNombre();

                   

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
          
        }

        public DataTable BuscarClienteNombre(string NOMBRE_C)
        {
            comando.Connection = conexion1.AbrirConexion();
            comando.CommandText = "BuscarNombreCliente";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@NOMBRE_C", NOMBRE_C);
            leer = comando.ExecuteReader();

            tabla.Load(leer);
            conexion1.CerrarConexion();

            return tabla;
        }


        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                MostrarClientes();

            }
        }
    }
}
