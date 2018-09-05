using System;
using System.Windows.Forms;

namespace Farmacia
{
    public partial class Almacen : Form
    {
        Conexion Co = new Conexion();
        public Almacen()
        {
            InitializeComponent();
            ActualizarGrid();
        }

        public void ActualizarGrid()
        {
            Datos.DataSource = Co.getInventario();
        }

        int Id { get; set; }

        void DatosCellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow Rows = Datos.Rows[e.RowIndex];

                Id = int.Parse(Rows.Cells["Id"].Value.ToString());
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        void AgreagarToolStripMenuItemClick(object sender, EventArgs e)
        {
            Producto Pro = new Producto();
            Pro.Actualizar.Enabled = false;
            Pro.ShowDialog();
        }

        void ActualizarToolStripMenuItemClick(object sender, EventArgs e)
        {
            Producto Pro = new Producto();
            Pro.Registrar.Enabled = false;
            Pro.Id = Id;
            Pro.ShowDialog();
        }

        void EliminarToolStripMenuItemClick(object sender, EventArgs e)
        {
            Co.Codigo = Id.ToString();
            Co.Conectar();
            if (Co.Eliminar())
            {
                ActualizarGrid();
                MessageBox.Show("Producto Eliminado");
                Alerta.MostrarNotificacion("Eliminacion", "Producto Eliminado", 300);
            }
            else
            {
                MessageBox.Show("Producto No Eliminado!!!");
            }
        }

        void RefrescarToolStripMenuItemClick(object sender, EventArgs e)
        {
            Datos.DataSource = null;
            Datos.DataSource = Co.getInventario(); 
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            Datos.DataSource = null;
            Datos.DataSource = Co.Buscar_Producto(BuscarTxt.Text);
        }
    }
}
