﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Farmacia.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.10.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string IdGlobal {
            get {
                return ((string)(this["IdGlobal"]));
            }
            set {
                this["IdGlobal"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("BEGIN TRANSACTION;\r\nCREATE TABLE IF NOT EXISTS \"Venta\" (\r\n\t\"Id_Venta\"\tint NOT NUL" +
            "L,\r\n\t\"Producto\"\ttext NOT NULL,\r\n\t\"Cantidad\"\tint NOT NULL,\r\n\t\"Id_Vendedor\"\tint NO" +
            "T NULL,\r\n\t\"Fecha_de_Venta\"\ttext NOT NULL,\r\n\t\"Total_Vendido\"\tdecimal(0 , 5) NOT N" +
            "ULL,\r\n\tFOREIGN KEY(\"Id_Vendedor\") REFERENCES \"Usuario\"(\"Id\"),\r\n\tPRIMARY KEY(\"Id_" +
            "Venta\")\r\n);\r\nCREATE TABLE IF NOT EXISTS \"Inventario\" (\r\n\t\"Id\"\tint NOT NULL,\r\n\t\"P" +
            "roducto\"\ttext NOT NULL,\r\n\t\"Tipo\"\ttext NOT NULL,\r\n\t\"Cantidad\"\tint NOT NULL,\r\n\t\"Pr" +
            "ecio_Compra\"\tdecimal(0 , 5) NOT NULL,\r\n\t\"Precio_Unitario\"\tdecimal(0 , 5) NOT NUL" +
            "L,\r\n\t\"Fecha_Compra\"\ttext NOT NULL,\r\n\t\"Fecha_Vencimiento\"\ttext NOT NULL,\r\n\tPRIMAR" +
            "Y KEY(\"Id\")\r\n);\r\nCREATE TABLE IF NOT EXISTS \"Costos_TP\" (\r\n\t\"Id_Costo\"\tint NOT N" +
            "ULL,\r\n\t\"Id_Producto\"\tint NOT NULL,\r\n\t\"Total_CP\"\tdecimal(0 , 5) NOT NULL,\r\n\tPRIMA" +
            "RY KEY(\"Id_Costo\"),\r\n\tFOREIGN KEY(\"Id_Producto\") REFERENCES \"Inventario\"(\"Id\")\r\n" +
            ");\r\nCREATE TABLE IF NOT EXISTS \"Usuario\" (\r\n\t\"Id\"\tint NOT NULL,\r\n\t\"Nombre\"\ttext " +
            "NOT NULL,\r\n\t\"Apellido\"\ttext NOT NULL,\r\n\t\"Telefono\"\tint NOT NULL,\r\n\t\"Direccion\"\tt" +
            "ext NOT NULL,\r\n\t\"Contrasena\"\ttext NOT NULL,\r\n\t\"Administrador\"\tbool NOT NULL,\r\n\tP" +
            "RIMARY KEY(\"Id\")\r\n);\r\nINSERT INTO \"Usuario\" VALUES (1,\'root\',\'root\',0,\'Nicaragua" +
            "\',\'dc76e9f0c0006e8f919e0c515c66dbba3982f785\',\'true\');\r\nCREATE VIEW Costo \r\nAs \r\n" +
            "Select Id_Producto,Inventario.Producto as Producto, Inventario.Cantidad as Canti" +
            "dad,Inventario.Fecha_Compra as Fecha_Compra, Costos_TP.Total_CP as Total_Costo, " +
            "(Select (Select Precio_Unitario From Inventario Where Id=Id_Producto)*(Select Ca" +
            "ntidad From Inventario Where Id=Id_Producto)) As Total_Venta From Costos_TP inne" +
            "r join Inventario on Inventario.Id = Costos_TP.Id_Producto;\r\nCOMMIT;")]
        public string Data {
            get {
                return ((string)(this["Data"]));
            }
            set {
                this["Data"] = value;
            }
        }
    }
}
