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
    public partial class RClientes : Form
    {
        byte ce = 0, re = 0, ipm = 0;
        

        CN_Clientes objetoCNCliente = new CN_Clientes();

        private CD_Conexion conexion1 = new CD_Conexion();

        SqlDataReader leer; //LEER FILAS DE LA TABLA
        DataTable tabla = new DataTable(); //Para almacenar las filas de la consulta
        SqlCommand comando = new SqlCommand();//Para ejecutar instrucciones o procedimientos almacenados

        public RClientes()
        {
            InitializeComponent();
            
        }

        private void BtnRProvee_Click(object sender, EventArgs e)
        {
            RProveedor PantallaRProveerdor = new RProveedor();
            this.Close();
            PantallaRProveerdor.ShowDialog();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            Ventas PantallaVentas = new Ventas();
            this.Close();
            PantallaVentas.ShowDialog();
        }

        private void BtnCompras_Click(object sender, EventArgs e)
        {
            Compras PantallaCompras = new Compras();
            this.Close();
            PantallaCompras.ShowDialog();
        }
        public void Desaparecer()
        {
           
        }

     
       

        private void BtnCorte_Click(object sender, EventArgs e)
        {
            Corte PantallaCorte = new Corte();
            this.Close();
            PantallaCorte.ShowDialog();
        }

        private void BtnFactura_Click(object sender, EventArgs e)
        {
            Factura PantallaFactura = new Factura();
            this.Close();
            PantallaFactura.ShowDialog();
        }

      

        private void BtnRUsuar_Click(object sender, EventArgs e)
        {
            RUsuario PantallaRUsuario = new RUsuario();
            this.Close();
            PantallaRUsuario.ShowDialog();
        }

        private void BtnRClie_Click(object sender, EventArgs e)
        {
            Desaparecer();
        }

        private void BtnRMateria_Click(object sender, EventArgs e)
        {
            RMateriales RMateria = new RMateriales();
            this.Close();
            RMateria.ShowDialog();
        }

        private void BtnCProvee_Click(object sender, EventArgs e)
        {
            CProveedores PantallaCProveedores = new CProveedores();
            this.Close();
            PantallaCProveedores.ShowDialog();
        }

        private void BtnCUsuari_Click(object sender, EventArgs e)
        {
            CUsuarios PantallaCUsuari = new CUsuarios();
            this.Close();
            PantallaCUsuari.ShowDialog();
        }

        private void BtnCClie_Click(object sender, EventArgs e)
        {
            CClientes PantallaCClie = new CClientes();
            this.Close();
            PantallaCClie.ShowDialog();
        }

        private void BtnCCompras_Click(object sender, EventArgs e)
        {
            CCompras PantallasCCompra = new CCompras();
            this.Close();
            PantallasCCompra.ShowDialog();
        }

      

        private void BtnCBalance_Click(object sender, EventArgs e)
        {
            CBalance PantallaCBalance = new CBalance();
            this.Close();
            PantallaCBalance.ShowDialog();
        }

        private void BtnCCorte_Click(object sender, EventArgs e)
        {
            CCorte PantallaCCorte = new CCorte();
            this.Close();
            PantallaCCorte.ShowDialog();
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

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                objetoCNCliente.InsertarRegistro(txtRFC.Text, txtNombre.Text, txtDireccion.Text, txtCorreo.Text, txtCodigoPostal.Text, txtTelefono.Text);
                MessageBox.Show("Se inserto correctamente");

            }
            catch (Exception Ex)
            {

                MessageBox.Show("Hubo un error por: "+ Ex);
            }
        }

        private void RClientes_Load(object sender, EventArgs e)
        {

        }
        
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {

                objetoCNCliente.ActualizarCliente(txtRFC.Text, txtNombre.Text, txtDireccion.Text, txtCorreo.Text, txtCodigoPostal.Text, txtTelefono.Text);
                MessageBox.Show("Se actualizo el cliente:" + txtRFC.Text);
                txtRFC.Focus();

            }
            catch (Exception Ex)
            {

                MessageBox.Show("Hubo un error por: " + Ex);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                
                objetoCNCliente.EliminarCliente(txtRFC.Text);
                MessageBox.Show("Se elimino el cliente:" + txtRFC.Text);
                txtRFC.Focus();

            }
            catch (Exception Ex)
            {

                MessageBox.Show("Hubo un error por: " + Ex);
            }
          
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                conexion1.AbrirConexion();
                comando.Connection = conexion1.AbrirConexion();
                comando.CommandText = "SELECT * FROM CLIENTES Where CLIRFC = " + txtRFC.Text + "";
                leer = comando.ExecuteReader();


                if (leer.Read())
                {
                    txtRFC.Text = leer["CLIRFC"].ToString();
                    txtNombre.Text = leer["NOMBRE_C"].ToString();
                    txtDireccion.Text = leer["DIRECCION_C"].ToString();
                    txtCorreo.Text = leer["CORREOELECTRONICO_C"].ToString();
                    txtCodigoPostal.Text = leer["CODIGOPOSTAL_C"].ToString();
                    txtTelefono.Text = leer["TELEFONO_C"].ToString();
                }
                conexion1.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error por: " + ex);
            }
           

        }

        private void panel15_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnRPintura_Click(object sender, EventArgs e)
        {
            RPintura PantallaRPintura = new RPintura();
            this.Close();
            PantallaRPintura.ShowDialog();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
