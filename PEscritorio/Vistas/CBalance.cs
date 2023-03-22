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
    public partial class CBalance : Form
    {
        byte ce = 0, re = 0, ipm = 0;

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCompras_Click(object sender, EventArgs e)
        {
            Compras PantallaCompras = new Compras();
            this.Close();
            PantallaCompras.ShowDialog();
        }

        private void BtnCatalogo_Click(object sender, EventArgs e)
        {
            if (ce == 0)
            {
                Desaparecer();
                PanelSubMenuCatalogo.Visible = true;
                ce = 1;
            }
            else
            {
                Desaparecer();
            }
        }
        public void Desaparecer()
        {
            PanelSubMenuCatalogo.Visible = false;
            PanelSubmenuRegistro.Visible = false;
            BtnCPintura.Visible = false;
            BtnCMaterias.Visible = false;
            ce = 0; re = 0; ipm = 0;
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
            if (re == 0)
            {
                Desaparecer();
                PanelSubmenuRegistro.Visible = true;
                re = 1;
            }
            else
            {
                Desaparecer();
            }
        }

        private void BtnRProvee_Click(object sender, EventArgs e)
        {
            RProveedor PantallaRProveerdor = new RProveedor();
            this.Close();
            PantallaRProveerdor.ShowDialog();
        }

        private void BtnRUsuar_Click(object sender, EventArgs e)
        {
            RUsuario PantallaRUsuario = new RUsuario();
            this.Close();
            PantallaRUsuario.ShowDialog();
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

        private void BtnInventario_Click(object sender, EventArgs e)
        {
            if (ipm == 0)
            {
                BtnCPintura.Visible = true;
                BtnCMaterias.Visible = true;
                ipm = 1;
            }
            else
            {
                BtnCPintura.Visible = false;
                BtnCMaterias.Visible = false;
                ipm = 0;
            }
        }

        private void BtnCCorte_Click(object sender, EventArgs e)
        {
            CCorte PantallaCCorte = new CCorte();
            this.Close();
            PantallaCCorte.ShowDialog();
        }

        private void BtnCBalance_Click(object sender, EventArgs e)
        {
            Desaparecer();
        }

        private void BtnRPintura_Click(object sender, EventArgs e)
        {
            RPintura PantallaRPintura = new RPintura();
            this.Close();
            PantallaRPintura.ShowDialog();
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

        public CBalance()
        {
            InitializeComponent();
            PanelSubMenuCatalogo.Visible = false;
            PanelSubmenuRegistro.Visible = false;
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            Ventas PantallaVentas = new Ventas();
            this.Close();
            PantallaVentas.ShowDialog();
        }
    }
}
