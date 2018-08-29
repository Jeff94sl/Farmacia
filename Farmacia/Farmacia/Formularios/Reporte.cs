using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Windows.Forms.DataVisualization.Charting;

namespace Farmacia
{
    public partial class Reporte : Form
    {
        public Reporte()
        {
            InitializeComponent();
        }

        private void Filtrar_Click(object sender, EventArgs e)
        {
            Datos D = new Datos();

            Chart_Inventario();
            GridInventario.DataSource = D.TablaInventario(String.Format("{0:d}", FI.Value.Date), String.Format("{0:d}", FF.Value.Date));
            Chart_Ventas();
            GridVentas.DataSource = D.TablaVentas(String.Format("{0:d}", FI.Value.Date), String.Format("{0:d}", FF.Value.Date));
            Chart_Total();
            GridTotal.DataSource = D.TablaVentasMonedarias(String.Format("{0:d}", FI.Value.Date), String.Format("{0:d}", FF.Value.Date));
            Chart_Costo();
            GridCosto.DataSource = D.TablaCosto(String.Format("{0:d}", FI.Value.Date), String.Format("{0:d}", FF.Value.Date));
        }

        public void Chart_Ventas()
        {
            List<string> P = new List<string>();
            List<string> C = new List<string>();

            Datos Dt = new Datos();

            Dt.GraficoVentas(P, C, String.Format("{0:d}", FI.Value.Date), String.Format("{0:d}", FF.Value.Date));

            Ventas.Series.Clear();
            Ventas.Titles.Clear();
            Ventas.Palette = ChartColorPalette.Excel;
           
            Ventas.Titles.Add("Ventas");

            int I = 0;
            foreach (string i in P)
            {
                Series Serie = Ventas.Series.Add(i.ToString());
                Serie.Label = i.ToString();
                Serie.Points.Add(double.Parse(C[I].ToString()));
                I++;
            }
        }

        public void Chart_Inventario()
        {
            List<string> P = new List<string>();
            List<string> C = new List<string>();

            Datos Dt = new Datos();

            Dt.GraficoInventario(P, C, String.Format("{0:d}",FI.Value.Date), String.Format("{0:d}",FF.Value.Date));
            Existencias.Series.Clear();
            Existencias.Titles.Clear();
            Existencias.Palette = ChartColorPalette.BrightPastel;
            Existencias.Titles.Add("Inventario");

            int I = 0;
            foreach (string i in P)
            {
                Series Serie = Existencias.Series.Add(i.ToString());
                Serie.Label = i.ToString();
                Serie.Points.Add(double.Parse(C[I].ToString()));
                I++;
            }
        }

        public void Chart_Total()
        {
            List<string> P = new List<string>();
            List<string> C = new List<string>();

            Datos Dt = new Datos();

            Dt.GraficoVentasMonedarias(P, C, String.Format("{0:d}", FI.Value.Date), String.Format("{0:d}", FF.Value.Date));
            Total.Series.Clear();
            Total.Titles.Clear();
            Total.Palette = ChartColorPalette.BrightPastel;
            Total.Titles.Add("Total Vendido");

            int I = 0;
            foreach (string i in P)
            {
                Series Serie = Total.Series.Add(i.ToString());
                Serie.Label = i.ToString();
                Serie.Points.Add(double.Parse(C[I].ToString()));
                I++;
            }
        }

        public void Chart_Costo()
        {
            List<string> P = new List<string>();
            List<string> C = new List<string>();

            Datos Dt = new Datos();

            Dt.GraficoVentasMonedarias(P, C, String.Format("{0:d}", FI.Value.Date), String.Format("{0:d}", FF.Value.Date));
            Costos.Series.Clear();
            Costos.Titles.Clear();
            Costos.Palette = ChartColorPalette.BrightPastel;
            Costos.Titles.Add("Total Costo");

            int I = 0;
            foreach (string i in P)
            {
                Series Serie = Costos.Series.Add(i.ToString());
                Serie.Label = i.ToString();
                Serie.Points.Add(double.Parse(C[I].ToString()));
                I++;
            }
        }

        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exporta Exp = new Exporta();
            Exp.ExportarXML(GridInventario);
        }

        private void costosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exporta Exp = new Exporta();
            Exp.ExportarXML(GridCosto);
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exporta Exp = new Exporta();
            Exp.ExportarXML(GridVentas);
        }

        private void ventasTotalesPorProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exporta Exp = new Exporta();
            Exp.ExportarXML(GridTotal);
        }
    }
}
