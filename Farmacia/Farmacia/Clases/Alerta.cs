/*
 * Creado por SharpDevelop.
 * Usuario: Administrator
 * Fecha: 22/08/2018
 * Hora: 08:13 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Farmacia
{
    public abstract class Alerta
    {
        public Alerta()
        {
        }

        private static NotifyIcon Notificacion = new NotifyIcon();

        public static void MostrarNotificacion(string Titulo, string Mensaje, int Tiempo)
        {
            try
            {
                Notificacion.Visible = true;
                Notificacion.Icon = Properties.Resources.store32;
                Notificacion.BalloonTipIcon = ToolTipIcon.Info;
                Notificacion.BalloonTipTitle = Titulo;
                Notificacion.BalloonTipText = Mensaje;
                Notificacion.ShowBalloonTip(Tiempo);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
    }
}
