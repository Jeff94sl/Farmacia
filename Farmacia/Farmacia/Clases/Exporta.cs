using System.Data;
using System.Windows.Forms;
using ClosedXML.Excel;

namespace Farmacia
{
    class Exporta
    {
        
        SaveFileDialog Guardar = new SaveFileDialog();
        public Exporta()
        {
            
        }

        public void ExportarXML(DataGridView Data)
        {
            DataTable Tabla = new DataTable();

            foreach (DataGridViewColumn Column in Data.Columns)
            {
                Tabla.Columns.Add(Column.HeaderText,Column.ValueType);
            }

            foreach (DataGridViewRow Row in Data.Rows)
            {
                Tabla.Rows.Add();
                foreach (DataGridViewCell Cell in Row.Cells)
                {
                    Tabla.Rows[Tabla.Rows.Count - 1][Cell.ColumnIndex] = Cell.Value.ToString();
                }
            }

            using (XLWorkbook W = new XLWorkbook())
            {
                Guardar.Filter = "Excel|*.xlsx";
                if (Guardar.ShowDialog() == DialogResult.OK)
                {
                    W.Worksheets.Add(Tabla, "Reporte");
                    W.SaveAs(Guardar.FileName);
                }                
            }
        }
    }
}
