namespace Farmacia
{
    partial class MainForm
    {
        /// <summary>
        /// Designer variable used to keep track of non-visual components.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Disposes resources used by the form.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// This method is required for Windows Forms designer support.
        /// Do not change the method contents inside the source code editor. The Forms designer might
        /// not be able to load this method if it was changed manually.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Estado = new System.Windows.Forms.StatusStrip();
            this.Usuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.Hora = new System.Windows.Forms.ToolStripStatusLabel();
            this.Barra_Menu = new System.Windows.Forms.MenuStrip();
            this.almacenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSessionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Herramientas = new System.Windows.Forms.ToolStrip();
            this.VentasDiarias = new System.Windows.Forms.ToolStripButton();
            this.VentasTool = new System.Windows.Forms.ToolStripButton();
            this.ReportesTool = new System.Windows.Forms.ToolStripButton();
            this.Time = new System.Windows.Forms.Timer(this.components);
            this.Estado.SuspendLayout();
            this.Barra_Menu.SuspendLayout();
            this.Herramientas.SuspendLayout();
            this.SuspendLayout();
            // 
            // Estado
            // 
            this.Estado.BackColor = System.Drawing.Color.DeepPink;
            this.Estado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Usuario,
            this.Hora});
            this.Estado.Location = new System.Drawing.Point(0, 375);
            this.Estado.Name = "Estado";
            this.Estado.Size = new System.Drawing.Size(776, 22);
            this.Estado.TabIndex = 0;
            this.Estado.Text = "statusStrip1";
            // 
            // Usuario
            // 
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(47, 17);
            this.Usuario.Text = "Usuario";
            // 
            // Hora
            // 
            this.Hora.Name = "Hora";
            this.Hora.Size = new System.Drawing.Size(33, 17);
            this.Hora.Text = "Hora";
            // 
            // Barra_Menu
            // 
            this.Barra_Menu.BackColor = System.Drawing.Color.DeepPink;
            this.Barra_Menu.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.Barra_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.almacenToolStripMenuItem,
            this.personalToolStripMenuItem,
            this.verToolStripMenuItem,
            this.cerrarSessionToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.Barra_Menu.Location = new System.Drawing.Point(0, 0);
            this.Barra_Menu.Name = "Barra_Menu";
            this.Barra_Menu.Size = new System.Drawing.Size(776, 40);
            this.Barra_Menu.TabIndex = 2;
            this.Barra_Menu.Text = "Menu";
            // 
            // almacenToolStripMenuItem
            // 
            this.almacenToolStripMenuItem.Image = global::Farmacia.Properties.Resources.box;
            this.almacenToolStripMenuItem.Name = "almacenToolStripMenuItem";
            this.almacenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.almacenToolStripMenuItem.Size = new System.Drawing.Size(98, 36);
            this.almacenToolStripMenuItem.Text = "&Almacen";
            this.almacenToolStripMenuItem.Click += new System.EventHandler(this.AlmacenToolStripMenuItemClick);
            // 
            // personalToolStripMenuItem
            // 
            this.personalToolStripMenuItem.Image = global::Farmacia.Properties.Resources.diagram_1;
            this.personalToolStripMenuItem.Name = "personalToolStripMenuItem";
            this.personalToolStripMenuItem.Size = new System.Drawing.Size(96, 36);
            this.personalToolStripMenuItem.Text = "&Personal";
            this.personalToolStripMenuItem.Click += new System.EventHandler(this.personalToolStripMenuItem_Click);
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cascadaToolStripMenuItem,
            this.horizontalToolStripMenuItem,
            this.verticalToolStripMenuItem});
            this.verToolStripMenuItem.Image = global::Farmacia.Properties.Resources.presentation_2;
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(68, 36);
            this.verToolStripMenuItem.Text = "&Ver";
            // 
            // cascadaToolStripMenuItem
            // 
            this.cascadaToolStripMenuItem.Name = "cascadaToolStripMenuItem";
            this.cascadaToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.cascadaToolStripMenuItem.Text = "Cascada";
            this.cascadaToolStripMenuItem.Click += new System.EventHandler(this.CascadaToolStripMenuItemClick);
            // 
            // horizontalToolStripMenuItem
            // 
            this.horizontalToolStripMenuItem.Name = "horizontalToolStripMenuItem";
            this.horizontalToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.horizontalToolStripMenuItem.Text = "Horizontal";
            this.horizontalToolStripMenuItem.Click += new System.EventHandler(this.HorizontalToolStripMenuItemClick);
            // 
            // verticalToolStripMenuItem
            // 
            this.verticalToolStripMenuItem.Name = "verticalToolStripMenuItem";
            this.verticalToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.verticalToolStripMenuItem.Text = "Vertical";
            this.verticalToolStripMenuItem.Click += new System.EventHandler(this.VerticalToolStripMenuItemClick);
            // 
            // cerrarSessionToolStripMenuItem
            // 
            this.cerrarSessionToolStripMenuItem.Image = global::Farmacia.Properties.Resources._002_exit;
            this.cerrarSessionToolStripMenuItem.Name = "cerrarSessionToolStripMenuItem";
            this.cerrarSessionToolStripMenuItem.Size = new System.Drawing.Size(120, 36);
            this.cerrarSessionToolStripMenuItem.Text = "&Cerrar Sesion";
            this.cerrarSessionToolStripMenuItem.Click += new System.EventHandler(this.cerrarSessionToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manualToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
            this.ayudaToolStripMenuItem.Image = global::Farmacia.Properties.Resources._001_info;
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(85, 36);
            this.ayudaToolStripMenuItem.Text = "A&yuda";
            // 
            // manualToolStripMenuItem
            // 
            this.manualToolStripMenuItem.Name = "manualToolStripMenuItem";
            this.manualToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.manualToolStripMenuItem.Text = "Manual";
            this.manualToolStripMenuItem.Click += new System.EventHandler(this.manualToolStripMenuItem_Click);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de...";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // Herramientas
            // 
            this.Herramientas.BackColor = System.Drawing.Color.DeepPink;
            this.Herramientas.Dock = System.Windows.Forms.DockStyle.Left;
            this.Herramientas.ImageScalingSize = new System.Drawing.Size(64, 64);
            this.Herramientas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.VentasDiarias,
            this.VentasTool,
            this.ReportesTool});
            this.Herramientas.Location = new System.Drawing.Point(0, 40);
            this.Herramientas.Name = "Herramientas";
            this.Herramientas.Size = new System.Drawing.Size(69, 335);
            this.Herramientas.TabIndex = 3;
            this.Herramientas.Text = "toolStrip1";
            // 
            // VentasDiarias
            // 
            this.VentasDiarias.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.VentasDiarias.Image = global::Farmacia.Properties.Resources.money;
            this.VentasDiarias.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.VentasDiarias.Name = "VentasDiarias";
            this.VentasDiarias.Size = new System.Drawing.Size(66, 68);
            this.VentasDiarias.Text = "V&entas del Dia";
            this.VentasDiarias.Click += new System.EventHandler(this.VentasDiarias_Click);
            // 
            // VentasTool
            // 
            this.VentasTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.VentasTool.Image = global::Farmacia.Properties.Resources.basket;
            this.VentasTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.VentasTool.Name = "VentasTool";
            this.VentasTool.Size = new System.Drawing.Size(66, 68);
            this.VentasTool.Text = "Ve&nder";
            this.VentasTool.Click += new System.EventHandler(this.VentasToolClick);
            // 
            // ReportesTool
            // 
            this.ReportesTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ReportesTool.Image = global::Farmacia.Properties.Resources.pie_chart;
            this.ReportesTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ReportesTool.Name = "ReportesTool";
            this.ReportesTool.Size = new System.Drawing.Size(66, 68);
            this.ReportesTool.Text = "&Reportes";
            this.ReportesTool.Click += new System.EventHandler(this.ReportesToolClick);
            // 
            // Time
            // 
            this.Time.Enabled = true;
            this.Time.Tick += new System.EventHandler(this.TimeTick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Fuchsia;
            this.ClientSize = new System.Drawing.Size(776, 397);
            this.Controls.Add(this.Herramientas);
            this.Controls.Add(this.Estado);
            this.Controls.Add(this.Barra_Menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.Barra_Menu;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Farmacia";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFormFormClosing);
            this.Load += new System.EventHandler(this.MainFormLoad);
            this.Estado.ResumeLayout(false);
            this.Estado.PerformLayout();
            this.Barra_Menu.ResumeLayout(false);
            this.Barra_Menu.PerformLayout();
            this.Herramientas.ResumeLayout(false);
            this.Herramientas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.ToolStripMenuItem verticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cascadaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.Timer Time;
        public System.Windows.Forms.ToolStripMenuItem personalToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel Hora;
        public System.Windows.Forms.ToolStripStatusLabel Usuario;
        private System.Windows.Forms.ToolStripButton ReportesTool;
        private System.Windows.Forms.ToolStripButton VentasTool;
        private System.Windows.Forms.ToolStripButton VentasDiarias;
        private System.Windows.Forms.ToolStrip Herramientas;
        public System.Windows.Forms.ToolStripMenuItem almacenToolStripMenuItem;
        private System.Windows.Forms.MenuStrip Barra_Menu;
        private System.Windows.Forms.StatusStrip Estado;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSessionToolStripMenuItem;
    }
}
