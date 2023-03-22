using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PEscritorio
{
    public partial class ReprtesVentas : Form
    {
        byte ve = 0, ma = 0, pi = 0, cl = 0;
        public ReprtesVentas()
        {
            InitializeComponent();
            PVen.Visible = false;
            PMat.Visible = false;
            PPint.Visible = false;
            PCli.Visible = false;
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void ReporteSemanal()
        {
            //DATOS A MOSTRAR
            string[] semana = { "lunes", "martes", "miercoles", "jueves", "viernes" };
            int[] puntos = { 23, 10, 70, 34, 52 };

            //TITULO
            chart1.Titles.Add("REPORTE SEMANAL");

            //COLORES
            chart1.Palette = ChartColorPalette.SeaGreen;

            for (int i = 0; i < semana.Length; i++)
            {
                //titulos
                Series serie = chart1.Series.Add(semana[i]);

                //cantidades
                serie.Label = puntos[i].ToString();

                serie.Points.Add(puntos[i]);
            }
        }
        //REPORTE SEMANAL
        public void ReportePorAño()
        {
            //DATOS A MOSTRAR
            string[] semana = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio" };
            int[] puntos = { 23, 10, 70, 34, 52,36 };

            //TITULO
            chart1.Titles.Add("REPORTE ANUAL");

            //COLORES
            chart1.Palette = ChartColorPalette.Pastel;

            for (int i = 0; i < semana.Length; i++)
            {
                //titulos
                Series serie = chart1.Series.Add(semana[i]);

                //cantidades
                serie.Label = puntos[i].ToString();

                serie.Points.Add(puntos[i]);
            }
        }

        //REPORTE DE VENTAS-MATERIALES
        public void ReporteVentasMateriales()
        {
            //DATOS A MOSTRAR
            string[] semana = { "Lijas de agua", "Tape 3/4", "Thiner Galon", "Fibras", "Cataliador" };
            int[] puntos = { 23, 10, 70, 34, 52 };

            //TITULO
            chart1.Titles.Add("REPORTE DE VENTAS POR MATERIALES");

            //COLORES
            chart1.Palette = ChartColorPalette.Pastel;

            for (int i = 0; i < semana.Length; i++)
            {
                //titulos
                Series serie = chart1.Series.Add(semana[i]);

                //cantidades
                serie.Label = puntos[i].ToString();

                serie.Points.Add(puntos[i]);
            }
        }

        //REPORTE DE VENTAS POR PINTURAS
        public void ReporteVentasPinturas()
        {
            //DATOS A MOSTRAR
            string[] semana = { "Azul", "Negro", "Verde", "Blanco", "Gris" };
            int[] puntos = { 23, 10, 70, 34, 52 };

            //TITULO
            chart1.Titles.Add("REPORTE DE VENTAS POR PINTURAS");

            //COLORES
            chart1.Palette = ChartColorPalette.Pastel;

            for (int i = 0; i < semana.Length; i++)
            {
                //titulos
                Series serie = chart1.Series.Add(semana[i]);

                //cantidades
                serie.Label = puntos[i].ToString();

                serie.Points.Add(puntos[i]);
            }
        }
        //REPORTE DE VENTAS POR PINTURAS
        public void ReporteVentasPinturasMarca()
        {
            //DATOS A MOSTRAR
            string[] semana = { "Standox", "Glasurit", "R-M", "Sikkens", "Lecher" };
            int[] puntos = { 23, 10, 70, 34, 52 };

            //TITULO
            chart1.Titles.Add("REPORTE DE VENTAS POR MARCA DE PINTURAS");

            //COLORES
            chart1.Palette = ChartColorPalette.Pastel;

            for (int i = 0; i < semana.Length; i++)
            {
                //titulos
                Series serie = chart1.Series.Add(semana[i]);

                //cantidades
                serie.Label = puntos[i].ToString();

                serie.Points.Add(puntos[i]);
            }
        }

        //REPORTE DE VENTAS POR CLIENTE EL MEJOR
        public void ReporteVentasPinturasClienteElMejor()
        {
            //DATOS A MOSTRAR
            string[] semana = { "Josue", "Max", "Yisus", "Cesar", "Brayan" };
            int[] puntos = { 23, 10, 70, 34, 52 };

            //TITULO
            chart1.Titles.Add("REPORTE DE MAS VENTAS TENIDAS POR CLIENTE");

            //COLORES
            chart1.Palette = ChartColorPalette.Pastel;

            for (int i = 0; i < semana.Length; i++)
            {
                //titulos
                Series serie = chart1.Series.Add(semana[i]);

                //cantidades
                serie.Label = puntos[i].ToString();

                serie.Points.Add(puntos[i]);
            }
        }

        //REPORTE DE VENTAS TIPO DE PINTURA
        public void ReporteVentasTipoPintura()
        {
            //DATOS A MOSTRAR
            string[] semana = { "Esmalte secado rápido", "Esmalte acrílico", "Esmalte poliuretano", "Bicapa" };
            int[] puntos = { 23, 10, 70, 34 };

            //TITULO
            chart1.Titles.Add("REPORTE DE VENTAS POR TIPO DE PINTURA");

            //COLORES
            chart1.Palette = ChartColorPalette.Pastel;

            for (int i = 0; i < semana.Length; i++)
            {
                //titulos
                Series serie = chart1.Series.Add(semana[i]);

                //cantidades
                serie.Label = puntos[i].ToString();

                serie.Points.Add(puntos[i]);
            }
        }
        public void Desaparacer()
        {
            PVen.Visible = false;
            PMat.Visible = false;
            PPint.Visible = false;
            PCli.Visible = false;
            ve = 0;ma = 0;pi = 0;cl = 0;
            chart1.Titles.Clear();
            chart1.Series.Clear();
        }

        private void BtnVDi_Click(object sender, EventArgs e)
        {
            Desaparacer();
        }

        private void BtnVSe_Click_1(object sender, EventArgs e)
        {
            Desaparacer();
            ReporteSemanal();
        }

        private void BtnVAn_Click(object sender, EventArgs e)
        {
            Desaparacer();
            ReportePorAño();
        }

        private void BtnMMas_Click(object sender, EventArgs e)
        {
            Desaparacer();
            ReporteVentasMateriales();
        }

        private void BtnMThi_Click(object sender, EventArgs e)
        {
            Desaparacer();
            ReporteThiner();
        }
        public void ReporteThiner()
        {
            //DATOS A MOSTRAR
            string[] Materiales = { "Thiner 90 Lt", "Thiner galón 360" };
            int[] puntos = { 23, 10 };

            //TITULO
            chart1.Titles.Add("PRESENTACIÓN DE THINER MÁS VENDIDA");

            //COLORES
            chart1.Palette = ChartColorPalette.SeaGreen;

            for (int i = 0; i < Materiales.Length; i++)
            {
                //titulos
                Series serie = chart1.Series.Add(Materiales[i]);

                //cantidades
                serie.Label = puntos[i].ToString();

                serie.Points.Add(puntos[i]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Desaparacer();
            ReporteTape();
        }
        public void ReporteTape()
        {
            //DATOS A MOSTRAR
            string[] Materiales = { "Tapes 3/4 203 45", "Tapes 3/4 233 90" };
            int[] puntos = { 70, 52 };

            //TITULO
            chart1.Titles.Add("REPORTE TAPE MÁS VENDIDO ESTE MES");

            //COLORES
            chart1.Palette = ChartColorPalette.SeaGreen;

            for (int i = 0; i < Materiales.Length; i++)
            {
                //titulos
                Series serie = chart1.Series.Add(Materiales[i]);

                //cantidades
                serie.Label = puntos[i].ToString();

                serie.Points.Add(puntos[i]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Desaparacer();
            ReporteLija();
        }
        public void ReporteLija()
        {
            //DATOS A MOSTRAR
            string[] Materiales = { "Lijas de agua 15", "Lijas disco 35", "Lijas tira 60" };
            int[] puntos = { 23, 10, 34 };

            //TITULO
            chart1.Titles.Add("REPORTE LIJA MÁS VENDIDA ESTE MES");

            //COLORES
            chart1.Palette = ChartColorPalette.SeaGreen;

            for (int i = 0; i < Materiales.Length; i++)
            {
                //titulos
                Series serie = chart1.Series.Add(Materiales[i]);

                //cantidades
                serie.Label = puntos[i].ToString();

                serie.Points.Add(puntos[i]);
            }
        }

        private void BtnPMas_Click(object sender, EventArgs e)
        {
            Desaparacer();
            ReporteVentasPinturas();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            if (ve == 0)
            {
                Desaparacer();
                PVen.Visible = true;
                ve = 1;
            }
            else
            {
                Desaparacer();
            }
        }

        private void BtnCompras_Click(object sender, EventArgs e)
        {
            if (ma == 0)
            {
                Desaparacer();
                PMat.Visible = true;
                ma = 1;
            }
            else
            {
                Desaparacer();
            }
        }

        private void BtnCatalogo_Click(object sender, EventArgs e)
        {
            if (pi == 0)
            {
                Desaparacer();
                PPint.Visible = true;
                pi = 1;
            }
            else
            {
                Desaparacer();
            }
        }

        private void BtnCorte_Click(object sender, EventArgs e)
        {
            if (cl == 0)
            {
                Desaparacer();
                PCli.Visible = true;
                cl = 1;
            }
            else
            {
                Desaparacer();
            }
        }

        private void BtnVMe_Click(object sender, EventArgs e)
        {
            Desaparacer();
        }

        private void BtnPMar_Click(object sender, EventArgs e)
        {
            Desaparacer();
            ReporteVentasPinturasMarca();
        }

        private void BtnPTipo_Click(object sender, EventArgs e)
        {
            Desaparacer();
            ReporteVentasTipoPintura();
        }

        private void BtnCMej_Click(object sender, EventArgs e)
        {
            Desaparacer();
            ReporteVentasPinturasClienteElMejor();
        }
    }
}
