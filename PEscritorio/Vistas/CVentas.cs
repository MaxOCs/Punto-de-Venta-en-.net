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
    public partial class CVentas : Form
    {
        

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

        private void BtnCatalogo_Click(object sender, EventArgs e)
        {
           
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

        private void BtnRegistro_Click(object sender, EventArgs e)
        {
           
        }

        private void BtnRProvee_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnRUsuar_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnRClie_Click(object sender, EventArgs e)
        {
           
        }

        private void BtnRPintura_Click(object sender, EventArgs e)
        {
           
        }

        private void BtnRMateria_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnCProvee_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnCUsuari_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnCClie_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnCCompras_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnInventario_Click(object sender, EventArgs e)
        {
           
        }

        private void BtnCPintura_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnCMaterias_Click(object sender, EventArgs e)
        {
           
        }

        private void BtnCBalance_Click(object sender, EventArgs e)
        {
           
        }

        private void BtnCCorte_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnCVenta_Click(object sender, EventArgs e)
        {
            Desaparecer();
        }

        private void BtnReportes_Click(object sender, EventArgs e)
        {
           
        }

        private void CVentas_Load(object sender, EventArgs e)
        {

        }

        public CVentas()
        {
            InitializeComponent();
           
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
