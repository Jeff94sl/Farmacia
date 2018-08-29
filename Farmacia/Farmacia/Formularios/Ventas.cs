using System;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Farmacia
{
    public partial class Ventas : Form
    {
        Item It;
        List<Item> Detalle = new List<Item>();
        public Ventas()
        {
            InitializeComponent();
        }

        void Calcular()
        {
            try
            {
                if (PCantidad.Value >= 1)
                {
                    int C;
                    double P;
                    C = (int)PCantidad.Value;
                    P = double.Parse(PrecioTxt.Text);
                    Total.Text = (C * P).ToString();
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        void VentasLoad(object sender, EventArgs e)
        {
            Conexion In = new Conexion();
            List<string> Pro = new List<string>();
            In.Productos(Pro);
            ProductosCmb.DataSource = Pro;
        }

        void ProductosCmbSelectedIndexChanged(object sender, EventArgs e)
        {
            Conexion In = new Conexion();
            In.Nombre = ProductosCmb.Text;
            PrecioTxt.Text = In.PrecioUni();
            PCantidad.Maximum = int.Parse(In.CantidadDisponible());
            if (int.Parse(In.CantidadDisponible()) < 10)
            {
                MessageBox.Show("El Producto Seleccionado esta agotandoce");
            }
            Calcular();
        }

        void ProductosCmbKeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (Char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        void PCantidadValueChanged(object sender, EventArgs e)
        {
            Calcular();
        }

        void AgregarClick(object sender, EventArgs e)
        {
            if (ProductosCmb.Text != "" && PrecioTxt.Text != "" && PCantidad.Text != "" && Total.Text != "")
            {
                It = new Item();
                It.Producto = ProductosCmb.Text;
                It.Precio = double.Parse(PrecioTxt.Text);
                It.Cantidad = int.Parse(PCantidad.Text);
                It.Total = double.Parse(Total.Text);
                Detalle.Add(It);

                Carrito.DataSource = null;
                Carrito.DataSource = Detalle;
            }
        }

        void FacturarClick(object sender, EventArgs e)
        {
            List<double> Suma = new List<double>();

            foreach (var i in Detalle)
            {
                Suma.Add(i.Total);
            }

            double Deuda = Convert.ToDouble(Suma.Sum().ToString());

            foreach (var i in Detalle)
            {
                Conexion In = new Conexion();
                In.Id_Usuario = Properties.Settings.Default.IdGlobal;
                In.Nombre = i.Producto;
                In.Cantidad = i.Cantidad.ToString();
                In.Total = i.Total.ToString();
                if (In.Insertar_Venta())
                {
                    Console.WriteLine(i.Producto);
                }
                else
                {
                    Console.WriteLine("Error");
                }
            }
            foreach (var i in Detalle)
            {
                Conexion In = new Conexion();
                In.Id_Usuario = Properties.Settings.Default.IdGlobal;
                In.Nombre = i.Producto;
                In.Cantidad = i.Cantidad.ToString();
                In.Total = i.Total.ToString();
                if (In.Actualizar_Cantidad())
                {
                    Console.WriteLine(i.Producto);
                }
                else
                {
                    Console.WriteLine("Error");
                }
            }
            Detalle.Clear();
            Neto.Text = Suma.Sum().ToString();
            Carrito.DataSource = null;
            Suma.Clear();     
        }
    }
}
