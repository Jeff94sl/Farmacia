using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;

namespace Farmacia
{
    class Datos : Conexion
    {
        public Datos()
        {
            
        }

        public void GraficoInventario(List<String> Product, List<string> Cantidad, string Init_Fecha, string Final_Fecha)
        {
            Conectar();
            try
            {
                Command = new SQLiteCommand("Select Producto,Cantidad From Inventario Where Fecha_Compra Between '"+Init_Fecha+"' And '"+Final_Fecha+"'",Cadena);
                SQLiteDataReader GReader = Command.ExecuteReader();

                while (GReader.Read())
                {
                    Product.Add(GReader["Producto"].ToString());
                    Cantidad.Add(GReader["Cantidad"].ToString());
                }
                Cadena.Close();
            }catch(SQLiteException Ex)
            {
                Console.WriteLine(Ex.Message);
            }
            Cadena.Close();
        }
        public DataTable TablaInventario(string Init_Fecha, string Final_Fecha)
        {
            Conectar();
            try
            {
                Adacter = new SQLiteDataAdapter("Select * From Inventario Where Fecha_Compra Between '" + Init_Fecha + "' And '" + Final_Fecha + "'", Cadena);

                Tabla = new DataTable();

                Adacter.Fill(Tabla);

                Cadena.Close();

                return Tabla;
            }
            catch (SQLiteException Ex)
            {
                Console.WriteLine(Ex.Message);
            }
            Cadena.Close();
            return null;
        }
        public void GraficoVentas(List<String> Product, List<string> Cantidad, string Init_Fecha, string Final_Fecha)
        {
            Conectar();
            try
            {
                Command = new SQLiteCommand("Select Distinct Producto From Venta Where Fecha_de_Venta Between '" + Init_Fecha + "' And '" + Final_Fecha + "'", Cadena);

                Reader = Command.ExecuteReader();

                while (Reader.Read())
                {
                    Product.Add(Reader["Producto"].ToString());
                }
                Cadena.Close();
                Conectar();

                foreach (string p in Product)
                {
                    Command = new SQLiteCommand("Select Sum(Cantidad) As Cantidad From Venta Where Fecha_de_Venta Between '" + Init_Fecha + "' And '" + Final_Fecha + "' And Producto= '"+p+"'", Cadena);

                    Reader = Command.ExecuteReader();

                    while (Reader.Read())
                    {
                        Cantidad.Add(Reader["Cantidad"].ToString());
                    }
                }
            }
            catch (SQLiteException Ex)
            {
                Console.WriteLine(Ex.Message);
            }
            Cadena.Close();
        }

        public DataTable TablaVentas(string Init_Fecha, string Final_Fecha)
        {
            Conectar();
            try
            {
                Adacter = new SQLiteDataAdapter("Select * From Venta Where Fecha_de_Venta Between '" + Init_Fecha + "' And '" + Final_Fecha + "'", Cadena);

                Tabla = new DataTable();

                Adacter.Fill(Tabla);

                Cadena.Close();

                return Tabla;
            }
            catch (SQLiteException Ex)
            {
                Console.WriteLine(Ex.Message);
            }
            Cadena.Close();
            return null;
        }

        public void GraficoVentasMonedarias(List<String> Product, List<string> Cantidad, string Init_Fecha, string Final_Fecha)
        {
            Conectar();
            try
            {
                Command = new SQLiteCommand("Select Distinct Producto From Venta Where Fecha_de_Venta Between '" + Init_Fecha + "' And '" + Final_Fecha + "'", Cadena);

                Reader = Command.ExecuteReader();

                while (Reader.Read())
                {
                    Product.Add(Reader["Producto"].ToString());
                }
                Cadena.Close();
                Conectar();

                foreach (string p in Product)
                {
                    Command = new SQLiteCommand("Select Sum(Total_Vendido) As Total From Venta Where Fecha_de_Venta Between '" + Init_Fecha + "' And '" + Final_Fecha + "' And Producto= '" + p + "'", Cadena);

                    Reader = Command.ExecuteReader();

                    while (Reader.Read())
                    {
                        Cantidad.Add(Reader["Total"].ToString());
                    }
                }
            }
            catch (SQLiteException Ex)
            {
                Console.WriteLine(Ex.Message);
            }
            Cadena.Close();
        }

        public DataTable TablaVentasMonedarias(string Init_Fecha, string Final_Fecha)
        {
            Conectar();
            try
            {
                Adacter = new SQLiteDataAdapter("Select * From Venta Where Fecha_de_Venta Between '" + Init_Fecha + "' And '" + Final_Fecha + "'", Cadena);

                Tabla = new DataTable();

                Adacter.Fill(Tabla);

                Cadena.Close();

                return Tabla;
            }
            catch (SQLiteException Ex)
            {
                Console.WriteLine(Ex.Message);
            }
            Cadena.Close();
            return null;
        }

        public void GraficoCosto(List<String> Product, List<string> Cantidad,string Init_Fecha, string Final_Fecha)
        {
            Conectar();
            try
            {
                Command = new SQLiteCommand("Select Producto From Costo Where Fecha_Compra Between '" + Init_Fecha + "' And '" + Final_Fecha + "'", Cadena);

                Reader = Command.ExecuteReader();

                while (Reader.Read())
                {
                    Product.Add(Reader["Producto"].ToString());
                }
                Cadena.Close();
                Conectar();

                foreach (string p in Product)
                {
                    Command = new SQLiteCommand("Select Total_Costo As Total From Costo Where Fecha_Compra Between '" + Init_Fecha + "' And '" + Final_Fecha + "' And Producto= '" + p + "'", Cadena);

                    Reader = Command.ExecuteReader();

                    while (Reader.Read())
                    {
                        Cantidad.Add(Reader["Total"].ToString());
                    }
                }
            }
            catch (SQLiteException Ex)
            {
                Console.WriteLine(Ex.Message);
            }
            Cadena.Close();
        }
        public DataTable TablaCosto(string Init_Fecha, string Final_Fecha)
        {
            Conectar();
            try
            {
                Adacter = new SQLiteDataAdapter("Select * From Costo Where Fecha_Compra Between '" + Init_Fecha + "' And '" + Final_Fecha + "'", Cadena);

                Tabla = new DataTable();

                Adacter.Fill(Tabla);

                Cadena.Close();

                return Tabla;
            }
            catch (SQLiteException Ex)
            {
                Console.WriteLine(Ex.Message);
            }
            Cadena.Close();
            return null;
        }
    }
}
