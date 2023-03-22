using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
