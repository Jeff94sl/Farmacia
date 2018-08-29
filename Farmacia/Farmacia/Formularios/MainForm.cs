using System;
using System.Windows.Forms;

namespace Farmacia
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        void AgregarPersonalClick(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        void VentasToolClick(object sender, EventArgs e)
        {

            string[] Ids = Usuario.Text.Split(' ');
            Properties.Settings.Default.IdGlobal = Ids[0].ToString();
            Properties.Settings.Default.Save();
            Ventas Ven = new Ventas();
            Ven.MdiParent = this;
            Ven.Show();
        }

        void ReportesToolClick(object sender, EventArgs e)
        {
            Reporte Re = new Reporte();
            Re.MdiParent = this;
            Re.Show();
        }

        void AlmacenToolStripMenuItemClick(object sender, EventArgs e)
        {
            Almacen Al = new Almacen();
            Al.MdiParent = this;
            Al.Show();
        }

        void TimeTick(object sender, EventArgs e)
        {
            Hora.Text = DateTime.Now.ToLongTimeString();
        }

        void MainFormFormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Desea Salir", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            else
            {
                e.Cancel = true;
            }
        }

        void MainFormLoad(object sender, EventArgs e)
        {
           Alerta.MostrarNotificacion("Saludos", "Bienvenida " + Usuario.Text, 300);
        }

        void CascadaToolStripMenuItemClick(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        void HorizontalToolStripMenuItemClick(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        void VerticalToolStripMenuItemClick(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Acerca Ac = new Acerca();
            Ac.ShowDialog();
        }

        private void personalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuarios Us = new Usuarios();
            Us.MdiParent = this;
            Us.Show();
        }

        private void cerrarSessionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Cerrar Session","Desea Cerrar Session",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Restart();
            }
        }

        private void VentasDiarias_Click(object sender, EventArgs e)
        {
            VDiarias VD = new VDiarias();
            VD.MdiParent = this;
            VD.Show();   
        }

        private void manualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Manual Man = new Manual();
            Man.Show();
        }
    }
}
