using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;

namespace Farmacia
{
    public class Conexion
    {

        protected SQLiteConnection Cadena;
        protected SQLiteCommand Command;
        protected SQLiteDataReader Reader;
        protected SQLiteDataAdapter Adacter;
        protected DataTable Tabla;

        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public string Cantidad { get; set; }
        public string Precio_Compra { get; set; }
        public string Precio_Unitario { get; set; }
        public DateTime Fecha_Compra { get; set; }
        public DateTime Fecha_Vencimiento { get; set; }

        public string Total { get; set; }
        public string Id_Usuario { get; set; }
        public string Usuarios { get; set; }
        public bool Tipo_Users { get; set; }

        public Conexion()
        {
            if (File.Exists("DB.db"))
            {
                Cadena = new SQLiteConnection("Data Source=DB.db;Version=3;New=false;Compress=true,Read Only=false");
            }
            else
            {
                Cadena = new SQLiteConnection("Data Source=DB.db;Version=3;New=false;Compress=true,Read Only=false");
                Cadena.Open();
                Command = new SQLiteCommand(Properties.Settings.Default.Data,Cadena);
                Command.ExecuteNonQuery();
                Cadena.Close();
            }
        }

        public void Conectar()
        {
            try
            {
                if (Cadena.State == ConnectionState.Closed)
                {
                    Cadena.Open();
                }
                else
                {
                    Console.WriteLine(Cadena.State.ToString());
                }
            }
            catch (SQLiteException Ex)
            {
                Console.WriteLine(Ex.Message);
            }
        }

        public bool Insertar_Usuario(string Nombre, string Apellido, string Telefono, string Direccion,string Contraseña)
        {
            Conectar();
            try
            {
                Command = new SQLiteCommand("Insert Into Usuario Values(((Select Count(Id) From Usuario)+1),'"+Nombre+"','"+Apellido+"','"+Telefono+"','"+Direccion+"','"+Encriptar.GetSHA1(Contraseña)+"','"+Tipo_Users+"')",Cadena);

                int query = Command.ExecuteNonQuery();

                Cadena.Close();

                if (query>0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (SQLiteException Ex)
            {
                Alerta.MostrarNotificacion("Error", Ex.Message, 300);
            }

            return false;
        }

        public bool EliminarUsuario()
        {
            Conectar();
            try
            {
                Command = new SQLiteCommand("Delete From Usuario Where Id='"+Id_Usuario+"'", Cadena);

                int query = Command.ExecuteNonQuery();

                Cadena.Close();

                if (query > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (SQLiteException Ex)
            {
                Alerta.MostrarNotificacion("Error", Ex.Message, 300);
            }

            return false;
        }

        public bool Actualizar_Usuario(string Nombre, string Apellido, string Telefono, string Direccion, string Contraseña)
        {
            Conectar();
            try
            {
                Command = new SQLiteCommand("Update Usuario Set Nombre='"+Nombre+"',Apellido= '"+Apellido+"',Telefono='"+Telefono+"',Direccion='"+Direccion+"',Contrasena='"+Encriptar.GetSHA1(Contraseña)+"' Where Id='" + Id_Usuario + "'", Cadena);

                int query = Command.ExecuteNonQuery();

                Cadena.Close();

                if (query > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (SQLiteException Ex)
            {
                Alerta.MostrarNotificacion("Error", Ex.Message, 300);
            }

            return false;
        }
        public void Cargar_Usuarios(List<string> Pro)
        {
            Cadena.Open();
            try
            {
                Command = new SQLiteCommand("Select * From Usuario", Cadena);
                Reader = Command.ExecuteReader();

                while (Reader.Read())
                {
                    Pro.Add(Reader["Nombre"].ToString());
                    
                    Alerta.MostrarNotificacion("Iniciando", "Cargando Usuarios", 100);
                }
                Cadena.Close();
            }
            catch (SQLiteException Ex)
            {
                Console.WriteLine(Ex.Message);
            }
            Cadena.Close();
        }

        public DataTable Users()
        {
            try
            {
                Adacter = new SQLiteDataAdapter("Select Id,Nombre,Apellido,Telefono,Direccion,Administrador From Usuario", Cadena);

                Tabla = new DataTable();

                Adacter.Fill(Tabla);

                Cadena.Close();

                return Tabla;

            }
            catch (SQLiteException Ex)
            {
                Console.WriteLine(Ex.Message);
            }
            return null;
        }

        public bool getUsuario(string Us, string Pass)
        {
            Cadena.Open();
            try
            {
                Command = new SQLiteCommand("Select Id,Nombre, Contrasena, Administrador From Usuario Where Nombre='" + Us + "' And Contrasena='" + Encriptar.GetSHA1(Pass) + "'", Cadena);

                Reader = Command.ExecuteReader();
                while (Reader.Read())
                {
                    Id_Usuario = Reader["Id"].ToString();
                    Usuarios = Reader["Nombre"].ToString();
                    Tipo_Users = Convert.ToBoolean(Reader["Administrador"]);
                    Cadena.Close();
                    return true;
                }
                Cadena.Close();
            }
            catch (SQLiteException Ex)
            {
                Console.WriteLine(Ex.Message);
            }
            Cadena.Close();
            return false;
        }
        public DataTable getInventario()
        {
            Conectar();
            try
            {
                Adacter = new SQLiteDataAdapter("Select * From Inventario", Cadena);

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

        public bool Insert_Inventario()
        {
            Conectar();
            try
            {
                Command = new SQLiteCommand("Insert Into Inventario Values('" + Codigo + "','" + Upper.ConvertFirtsCharToUpperString(Nombre) + "','" + Upper.ConvertFirtsCharToUpperString(Tipo) + "','" + Cantidad + "','" + Precio_Compra + "','" + Precio_Unitario + "','" + String.Format("{0:d}",Fecha_Compra.Date) + "','" + String.Format("{0:d}",Fecha_Vencimiento.Date)+ "');", Cadena);

                int query = Command.ExecuteNonQuery();

                Command = new SQLiteCommand("Insert Into Costos_TP Values(((Select Count(Id_Costo) From Costos_TP)+1),'" + Codigo + "',(Select (Select Cantidad From Inventario Where Id='" + Codigo + "') * (Select Precio_Compra From Inventario Where Id='" + Codigo + "')));", Cadena);

                int trigger = Command.ExecuteNonQuery();

                Cadena.Close();

                if (query > 0 && trigger > 0)
                {
                    Alerta.MostrarNotificacion("Insercion", "Producto " + Nombre + " Insertado", 300);
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (SQLiteException Ex)
            {
                Console.WriteLine(Ex.Message);
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.Message);
            }
            return false;
        }

        public DataTable Buscar_Producto(string Nombre)
        {
            Conectar();
            try
            {
                Adacter = new SQLiteDataAdapter("Select * From Inventario Where Producto Like '"+Upper.ConvertFirtsCharToUpperString(Nombre)+ "%'", Cadena);

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

        public void getProductos(int Id)
        {
            Conectar();
            try
            {
                Command = new SQLiteCommand("Select * From Inventario Where Id='" + Id + "'", Cadena);
                Reader = Command.ExecuteReader();

                while (Reader.Read())
                {
                    Codigo = Reader["Id"].ToString();
                    Nombre = Reader["Producto"].ToString();
                    Tipo = Reader["Tipo"].ToString();
                    Cantidad = Reader["Cantidad"].ToString();
                    Precio_Compra = Reader["Precio_Compra"].ToString();
                    Precio_Unitario = Reader["Precio_Unitario"].ToString();
                    Fecha_Compra = Convert.ToDateTime(Reader["Fecha_Compra"]);
                    Fecha_Vencimiento = Convert.ToDateTime(Reader["Fecha_Vencimiento"]);
                }
                Cadena.Close();
            }
            catch (SQLiteException Ex)
            {
                Console.WriteLine(Ex.Message);
            }
            Cadena.Close();
        }

        public bool Actualizar()
        {
            Conectar();
            try
            {
                Command = new SQLiteCommand("Update Inventario Set Producto='" + Nombre + "', Tipo='" + Tipo + "', Cantidad='" + Cantidad + "', Precio_Compra='" + Precio_Compra + "',Precio_Unitario='" + Precio_Unitario + "',Fecha_Compra='" + Fecha_Compra + "',Fecha_Vencimiento= '" + Fecha_Vencimiento + "' where Id= '" + Codigo + "'", Cadena);

                int query = Command.ExecuteNonQuery();

                Command = new SQLiteCommand("Update Costos_TP set Total_CP = (Select (Select Cantidad From Inventario Where Id='" + Codigo + "') * (Select Precio_Compra From Inventario Where Id='" + Codigo + "') Where Id_Producto='" + Codigo + "');", Cadena);

                int trigger = Command.ExecuteNonQuery();

                Cadena.Close();

                if (query > 0 && trigger > 0)
                {
                    Alerta.MostrarNotificacion("Actualizacion", "Producto " + Nombre + " Actualizado", 300);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (SQLiteException Ex)
            {
                Console.WriteLine(Ex.Message);
            }
            Cadena.Close();
            return false;
        }

        public bool Eliminar()
        {
            Conectar();
            try
            {
                Command = new SQLiteCommand("Delete From Inventario Where Id='" + Codigo + "'", Cadena);

                int query = Command.ExecuteNonQuery();

                Command = new SQLiteCommand("Delete From Costos_TP Where Id_Producto = '" + Codigo + "'", Cadena);

                int trigger = Command.ExecuteNonQuery();

                Cadena.Close();

                if (query > 0 && trigger > 0)
                {
                    Alerta.MostrarNotificacion("Eliminacion", "Producto Eliminado", 300);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (SQLiteException Ex)
            {
                Console.WriteLine(Ex.Message);
            }
            Cadena.Close();
            return false;
        }

        public void Productos(List<string> Pro)
        {
            Conectar();
            try
            {
                Command = new SQLiteCommand("Select Producto From Inventario", Cadena);
                Reader = Command.ExecuteReader();

                while (Reader.Read())
                {
                    Pro.Add(Reader["Producto"].ToString());
                }
                Cadena.Close();
            }
            catch (SQLiteException Ex)
            {
                Console.WriteLine(Ex.Message);
            }
            Cadena.Close();
        }

        public string PrecioUni()
        {
            Conectar();
            try
            {
                Command = new SQLiteCommand("Select Precio_Unitario From Inventario Where Producto ='" + Nombre + "'", Cadena);
                Reader = Command.ExecuteReader();
                while (Reader.Read())
                {
                    return Reader["Precio_Unitario"].ToString();
                }
                Cadena.Close();
            }
            catch (SQLiteException Ex)
            {
                Console.WriteLine(Ex.Message);
            }
            Cadena.Close();
            return null;
        }

        public string CantidadDisponible()
        {
            Conectar();
            try
            {
                Command = new SQLiteCommand("Select Cantidad From Inventario Where Producto ='" + Nombre + "'", Cadena);
                Reader = Command.ExecuteReader();
                while (Reader.Read())
                {
                    return Reader["Cantidad"].ToString();
                }
                Cadena.Close();
            }
            catch (SQLiteException Ex)
            {
                Console.WriteLine(Ex.Message);
            }
            Cadena.Close();
            return null;
        }

        public DataTable Ventas()
        {
            Conectar();
            try
            {
                Adacter = new SQLiteDataAdapter("Select * From Venta", Cadena);

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

        public bool Insertar_Venta()
        {
            Conectar();
            try
            {
                Command = new SQLiteCommand("Insert Into Venta Values(((Select count(Id_Venta) From Venta)+1),'" + Nombre + "','" + Cantidad + "',(Select Id From Usuario Where Id ='" + Id_Usuario + "'),'" + String.Format("{0:d}",DateTime.Now.Date) + "','" + Total + "')", Cadena);

                int query = Command.ExecuteNonQuery();

                Cadena.Close();

                if (query > 0)
                {
                    Alerta.MostrarNotificacion("Venta", "Producto Vendido " + Nombre, 300);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (SQLiteException Ex)
            {
                Alerta.MostrarNotificacion("Error", Ex.Message, 300);
            }
            Cadena.Close();
            return false;
        }

        public bool Actualizar_Cantidad()
        {
            Conectar();
            try
            {
                Command = new SQLiteCommand("Update Inventario Set Cantidad = (Select (Select Cantidad From Inventario Where Producto='" + Nombre + "') - '" + Cantidad + "') Where Producto = '"+Nombre+"';", Cadena);
                int query = Command.ExecuteNonQuery();

                Cadena.Close();

                if (query > 0)
                {
                    Alerta.MostrarNotificacion("Venta", "Producto Vendido " + Nombre, 300);
                    
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (SQLiteException Ex)
            {
                Console.WriteLine(Ex.Message);
            }
            Cadena.Close();
            return false;
        }
        public DataTable Costos()
        {
            Conectar();
            try
            {
                Adacter = new SQLiteDataAdapter("Select * From Costos_TP", Cadena);

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
