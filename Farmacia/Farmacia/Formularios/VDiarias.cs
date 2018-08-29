using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farmacia
{
    public partial class VDiarias : Form
    {
        public VDiarias()
        {
            InitializeComponent();
        }

        private void exportarAExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exporta Exp = new Exporta();
            Exp.ExportarXML(dataGridView1);
        }

        private void VentasDiarias_Load(object sender, EventArgs e)
        {
            Datos Dat = new Datos();
            dataGridView1.DataSource = Dat.TablaVentas(String.Format("{0:d}",DateTime.Now.Date), String.Format("{0:d}", DateTime.Now.Date));
        }
    }
}
