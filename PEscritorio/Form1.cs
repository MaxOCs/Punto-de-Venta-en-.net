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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            rjDropdownMenu1.IsMainMenu = true;
            DMregistros.IsMainMenu = true;
        }
        private Form active = null;
        private void opening(Form child)
        {
            if (active != null)
                active.Close();
            active = child;
            child.TopLevel = false;
            child.FormBorderStyle = FormBorderStyle.None;
            child.Dock = DockStyle.Fill;
            panel11.Controls.Add(child);
            panel11.Tag = child;
            child.BringToFront();
            child.Show();

        }
        public void Desaparecer()
        {

        }

        private void BtnCatalogo_Click(object sender, EventArgs e)
        {
            rjDropdownMenu1.Show(BtnCatalogo, BtnCatalogo.Width, 0);
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            opening(new Ventas());
            LBubicacion.Text = "VENTAS";
            panel12.BackgroundImage = Properties.Resources.VENTAS;
        }

        private void BtnCompras_Click(object sender, EventArgs e)
        {
            opening(new Compras());
            LBubicacion.Text = "COMPRAS";
            panel12.BackgroundImage = Properties.Resources.COMPRAS;
        }

        private void BtnCorte_Click(object sender, EventArgs e)
        {
            opening(new Corte());
            LBubicacion.Text = "CORTE";
            panel12.BackgroundImage = Properties.Resources.CORTE;
        }

        private void BtnFactura_Click(object sender, EventArgs e)
        {
            opening(new Factura());
            LBubicacion.Text = "FACTURA";
            panel12.BackgroundImage = Properties.Resources.icons8_factura_pagada_40;
        }

        private void BtnRegistro_Click(object sender, EventArgs e)
        {
            DMregistros.Show(BtnRegistro,BtnRegistro.Width, 0);
        }

        private void BtnCProvee_Click(object sender, EventArgs e)
        {
            CProveedores PantallaCProveedores = new CProveedores();
            PantallaCProveedores.ShowDialog();
        }

        private void BtnRProvee_Click(object sender, EventArgs e)
        {
            RProveedor PantallaRProveerdor = new RProveedor();
            PantallaRProveerdor.ShowDialog();
        }

        private void BtnCCompras_Click(object sender, EventArgs e)
        {
            CCompras PantallasCCompra = new CCompras();
            PantallasCCompra.ShowDialog();
        }

        private void BtnCCorte_Click(object sender, EventArgs e)
        {
            CCorte PantallaCCorte = new CCorte();
            PantallaCCorte.ShowDialog();
        }

        private void BtnCClie_Click(object sender, EventArgs e)
        {
            CClientes PantallaCClie = new CClientes();
            PantallaCClie.ShowDialog();
        }

        private void BtnCUsuari_Click(object sender, EventArgs e)
        {
            CUsuarios PantallaCUsuari = new CUsuarios();
            PantallaCUsuari.ShowDialog();
        }

        private void BtnRMateria_Click(object sender, EventArgs e)
        {
            RMateriales RMateria = new RMateriales();
            RMateria.ShowDialog();
        }

        private void BtnRUsuar_Click(object sender, EventArgs e)
        {
            RUsuario PantallaRUsuario = new RUsuario();
            PantallaRUsuario.ShowDialog();
        }

        private void BtnCBalance_Click(object sender, EventArgs e)
        {
            CBalance PantallaCBalance = new CBalance();
            PantallaCBalance.ShowDialog();
        }

        private void BtnRPintura_Click(object sender, EventArgs e)
        {
            RPintura PantallaRPintura = new RPintura();
            PantallaRPintura.ShowDialog();
        }

        private void BtnRClie_Click(object sender, EventArgs e)
        {
            RClientes PantallaRClie = new RClientes();
            PantallaRClie.ShowDialog();
        }

        private void BtnCPintura_Click(object sender, EventArgs e)
        {
            CPintura CPintura = new CPintura();
            CPintura.ShowDialog();
        }

        private void BtnCMaterias_Click(object sender, EventArgs e)
        {
            CMateriales CMateriales = new CMateriales();
            CMateriales.ShowDialog();
        }

        private void BtnCVenta_Click(object sender, EventArgs e)
        {
            CVentas CVentas = new CVentas();
            CVentas.ShowDialog();
        }

        private void BtnReportes_Click(object sender, EventArgs e)
        {
            ReprtesVentas PantallaReprtesVentas = new ReprtesVentas();
            PantallaReprtesVentas.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rjDropdownMenu1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void pROVEEDORToolStripMenuItem_Click(object sender, EventArgs e)
        {
            opening(new CProveedores());
            LBubicacion.Text= "CATALOGO PROVEEDORES";
        }

        private void uSUARIOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            opening(new CUsuarios ());
            LBubicacion.Text = "CATALOGO USUARIOS";
            panel12.BackgroundImage = Properties.Resources.icons8_encuentra_hombre_usuario_40;
        }

        private void cLIENTESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            opening(new CClientes());
            LBubicacion.Text = "CATALOGO CLIENTES";
            panel12.BackgroundImage = Properties.Resources.icons8_cola_40;
        }

        private void vENTASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            opening(new CVentas());
            LBubicacion.Text = "CATALOGO VENTAS";
            panel12.BackgroundImage=Properties.Resources.icons8_agregar_a_carrito_de_compras_50;    
        }

        private void cOMPRASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            opening(new CCompras());
            LBubicacion.Text = "CATALOGO COMPRAS";
        }

        private void iNVENTARIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
             
        }

        private void pINTURASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            opening(new CPintura());
            LBubicacion.Text = "CATALOGO Pintura";
            panel12.BackgroundImage = Properties.Resources.icons8_color_de_relleno_50;
        }

        private void mATERIALESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            opening(new CMateriales());
            LBubicacion.Text = "CATALOGO MATERIALES";
            panel12.BackgroundImage = Properties.Resources.icons8_grocery_shelf_100;
        }

        private void pROVEEDORToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            opening(new RProveedor());
            LBubicacion.Text = "REGISTRO PROVEEDOR";
        }

        private void usuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            opening(new RUsuario());
            LBubicacion.Text = "REGISTRO USUARIO";
        }

        private void cLIENTESToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            opening(new RClientes());
            LBubicacion.Text = "REGISTRO CLIENTES";
        }

        private void pINTURAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            opening(new RPintura());
            LBubicacion.Text = "REGISTRO PINTURAS";
        }

        private void mATERIALESToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            opening(new RMateriales());
            LBubicacion.Text = "REGISTRO MATERIALES";
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void BtnInventario_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cORTESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            opening(new CCorte());
            LBubicacion.Text = "CATALOGO CORTE";
            panel12.BackgroundImage = Properties.Resources.icons8_cortar_50;
        }
    }
}
    

