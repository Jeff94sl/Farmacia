using System;
using System.Windows.Forms;
using System.Linq;

namespace Farmacia
{
    public partial class Producto : Form
    {
        Conexion Co = new Conexion();
        public Producto()
        {
            InitializeComponent();
        }

        public int Id { get; set; }

        void ProductoLoad(object sender, EventArgs e)
        {
            if (Id > 0)
            {
                Co.getProductos(Id);
                CodigoTxt.Text = Co.Codigo;
                NombreTxt.Text = Co.Nombre;
                TipoTxt.Text = Co.Tipo;
                CantidadTxt.Text = Co.Cantidad;
                PCompraTxt.Text = Co.Precio_Compra;
                PUnitario.Text = Co.Precio_Unitario;
                FechaCompra.Value = Co.Fecha_Compra;
                FechaVencimiento.Value = Co.Fecha_Vencimiento;
            }
        }
        void ValidarCodigo(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (Char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (Char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (Char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        void ValidarPrecio(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (Char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }

            if (PCompraTxt.Text.Contains('.'))
            {
                if (Char.IsPunctuation(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }
        void Limpiar()
        {
            foreach (Control C in this.Controls)
            {
                if (C is TextBox)
                {
                    C.Text = "";
                }
            }
        }
        void RegistrarClick(object sender, EventArgs e)
        {
            if (CodigoTxt.Text != "" && NombreTxt.Text != "" && TipoTxt.Text != "")
            {
                if (CantidadTxt.Text != "" && PCompraTxt.Text != "" && PUnitario.Text != "" && FechaCompra.Text != "" && FechaVencimiento.Text != "")
                {

                    Co.Codigo = CodigoTxt.Text;
                    Co.Nombre = NombreTxt.Text;
                    Co.Tipo = TipoTxt.Text;
                    Co.Cantidad = CantidadTxt.Text;
                    Co.Precio_Compra = PCompraTxt.Text;
                    Co.Precio_Unitario = PUnitario.Text;
                    Co.Fecha_Compra = FechaCompra.Value.Date;
                    Co.Fecha_Vencimiento = FechaVencimiento.Value.Date;


                    if (Co.Insert_Inventario())
                    {
                        MessageBox.Show("Producto Guardado");
                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show("Error Al Guardar Producto");
                    }
                }
                else
                {
                    MessageBox.Show("Rellene Correctamente Los Campos");
                }
            }
            else
            {
                MessageBox.Show("Rellene Correctamente Los Campos");
            }
        }

        void ActualizarClick(object sender, EventArgs e)
        {
            if (CodigoTxt.Text != "" && NombreTxt.Text != "" && TipoTxt.Text != "")
            {
                if (CantidadTxt.Text != "" && PCompraTxt.Text != "" && PUnitario.Text != "" && FechaCompra.Text != "" && FechaVencimiento.Text != "")
                {


                    Co.Codigo = CodigoTxt.Text;
                    Co.Nombre = NombreTxt.Text;
                    Co.Tipo = TipoTxt.Text;
                    Co.Cantidad = CantidadTxt.Text;
                    Co.Precio_Compra = PCompraTxt.Text;
                    Co.Precio_Unitario = PUnitario.Text;
                    Co.Fecha_Compra = FechaCompra.Value;
                    Co.Fecha_Vencimiento = FechaVencimiento.Value;

                    if (Co.Actualizar())
                    {
                        MessageBox.Show("Producto Guardado");
                    }
                    else
                    {
                        MessageBox.Show("Error Al Guardar Producto");
                    }
                }
                else
                {
                    MessageBox.Show("Rellene Correctamente Los Campos");
                }
            }
            else
            {
                MessageBox.Show("Rellene Correctamente Los Campos");
            }
        }
    }
}
