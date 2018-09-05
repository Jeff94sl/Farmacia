namespace Farmacia
{
    partial class Reporte
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Ventas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.GridVentas = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.Existencias = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.GridInventario = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.FI = new System.Windows.Forms.DateTimePicker();
            this.FF = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.Filtrar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.Total = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.GridTotal = new System.Windows.Forms.DataGridView();
            this.Exportar = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exportarAExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.costosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasTotalesPorProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tabControl4 = new System.Windows.Forms.TabControl();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.Costos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.GridCosto = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ventas)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridVentas)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.tabControl3.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Existencias)).BeginInit();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridInventario)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Total)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridTotal)).BeginInit();
            this.Exportar.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabControl4.SuspendLayout();
            this.tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Costos)).BeginInit();
            this.tabPage8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridCosto)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.tabControl1);
            this.groupBox2.Location = new System.Drawing.Point(407, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(372, 291);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ventas";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 16);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(366, 272);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Ventas);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(358, 246);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Grafica";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Ventas
            // 
            chartArea1.Name = "ChartArea1";
            this.Ventas.ChartAreas.Add(chartArea1);
            this.Ventas.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.Ventas.Legends.Add(legend1);
            this.Ventas.Location = new System.Drawing.Point(3, 3);
            this.Ventas.Name = "Ventas";
            this.Ventas.Size = new System.Drawing.Size(352, 240);
            this.Ventas.TabIndex = 1;
            this.Ventas.Text = "Ventas";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.GridVentas);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(358, 246);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tabla";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // GridVentas
            // 
            this.GridVentas.AllowUserToAddRows = false;
            this.GridVentas.AllowUserToDeleteRows = false;
            this.GridVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridVentas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridVentas.Location = new System.Drawing.Point(3, 3);
            this.GridVentas.Name = "GridVentas";
            this.GridVentas.ReadOnly = true;
            this.GridVentas.Size = new System.Drawing.Size(352, 240);
            this.GridVentas.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox3.Controls.Add(this.tabControl3);
            this.groupBox3.Location = new System.Drawing.Point(12, 349);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(376, 238);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Existecias";
            // 
            // tabControl3
            // 
            this.tabControl3.Controls.Add(this.tabPage5);
            this.tabControl3.Controls.Add(this.tabPage6);
            this.tabControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl3.Location = new System.Drawing.Point(3, 16);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(370, 219);
            this.tabControl3.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.Existencias);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(362, 193);
            this.tabPage5.TabIndex = 0;
            this.tabPage5.Text = "Grafico";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // Existencias
            // 
            chartArea2.Name = "ChartArea1";
            this.Existencias.ChartAreas.Add(chartArea2);
            this.Existencias.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.Existencias.Legends.Add(legend2);
            this.Existencias.Location = new System.Drawing.Point(3, 3);
            this.Existencias.Name = "Existencias";
            this.Existencias.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.DodgerBlue,
        System.Drawing.Color.Fuchsia,
        System.Drawing.Color.Orange,
        System.Drawing.Color.Lime};
            this.Existencias.Size = new System.Drawing.Size(356, 187);
            this.Existencias.TabIndex = 2;
            this.Existencias.Text = "chart3";
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.GridInventario);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(362, 193);
            this.tabPage6.TabIndex = 1;
            this.tabPage6.Text = "Tabla";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // GridInventario
            // 
            this.GridInventario.AllowUserToAddRows = false;
            this.GridInventario.AllowUserToDeleteRows = false;
            this.GridInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridInventario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridInventario.Location = new System.Drawing.Point(3, 3);
            this.GridInventario.Name = "GridInventario";
            this.GridInventario.ReadOnly = true;
            this.GridInventario.Size = new System.Drawing.Size(356, 187);
            this.GridInventario.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "De Fecha:";
            // 
            // FI
            // 
            this.FI.Location = new System.Drawing.Point(80, 13);
            this.FI.Name = "FI";
            this.FI.Size = new System.Drawing.Size(200, 20);
            this.FI.TabIndex = 3;
            // 
            // FF
            // 
            this.FF.Location = new System.Drawing.Point(353, 13);
            this.FF.Name = "FF";
            this.FF.Size = new System.Drawing.Size(200, 20);
            this.FF.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(289, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "A Fecha:";
            // 
            // Filtrar
            // 
            this.Filtrar.Location = new System.Drawing.Point(560, 13);
            this.Filtrar.Name = "Filtrar";
            this.Filtrar.Size = new System.Drawing.Size(75, 23);
            this.Filtrar.TabIndex = 6;
            this.Filtrar.Text = "Filtrar";
            this.Filtrar.UseVisualStyleBackColor = true;
            this.Filtrar.Click += new System.EventHandler(this.Filtrar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.tabControl2);
            this.groupBox1.Location = new System.Drawing.Point(12, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 291);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Total Vendido";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(3, 16);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(370, 272);
            this.tabControl2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.Total);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(362, 246);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Grafica";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Total
            // 
            chartArea3.Name = "ChartArea1";
            this.Total.ChartAreas.Add(chartArea3);
            this.Total.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Name = "Legend1";
            this.Total.Legends.Add(legend3);
            this.Total.Location = new System.Drawing.Point(3, 3);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(356, 240);
            this.Total.TabIndex = 1;
            this.Total.Text = "Venta Monetaria";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.GridTotal);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(362, 246);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Tabla";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // GridTotal
            // 
            this.GridTotal.AllowUserToAddRows = false;
            this.GridTotal.AllowUserToDeleteRows = false;
            this.GridTotal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridTotal.Location = new System.Drawing.Point(3, 3);
            this.GridTotal.Name = "GridTotal";
            this.GridTotal.ReadOnly = true;
            this.GridTotal.Size = new System.Drawing.Size(356, 240);
            this.GridTotal.TabIndex = 0;
            // 
            // Exportar
            // 
            this.Exportar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportarAExcelToolStripMenuItem});
            this.Exportar.Name = "Exportar";
            this.Exportar.Size = new System.Drawing.Size(156, 26);
            // 
            // exportarAExcelToolStripMenuItem
            // 
            this.exportarAExcelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.costosToolStripMenuItem,
            this.inventarioToolStripMenuItem,
            this.ventasToolStripMenuItem,
            this.ventasTotalesPorProductoToolStripMenuItem});
            this.exportarAExcelToolStripMenuItem.Name = "exportarAExcelToolStripMenuItem";
            this.exportarAExcelToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.exportarAExcelToolStripMenuItem.Text = "Exportar a Excel";
            // 
            // costosToolStripMenuItem
            // 
            this.costosToolStripMenuItem.Name = "costosToolStripMenuItem";
            this.costosToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.costosToolStripMenuItem.Text = "Costos";
            this.costosToolStripMenuItem.Click += new System.EventHandler(this.costosToolStripMenuItem_Click);
            // 
            // inventarioToolStripMenuItem
            // 
            this.inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            this.inventarioToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.inventarioToolStripMenuItem.Text = "Inventario";
            this.inventarioToolStripMenuItem.Click += new System.EventHandler(this.inventarioToolStripMenuItem_Click);
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.ventasToolStripMenuItem.Text = "Ventas";
            this.ventasToolStripMenuItem.Click += new System.EventHandler(this.ventasToolStripMenuItem_Click);
            // 
            // ventasTotalesPorProductoToolStripMenuItem
            // 
            this.ventasTotalesPorProductoToolStripMenuItem.Name = "ventasTotalesPorProductoToolStripMenuItem";
            this.ventasTotalesPorProductoToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.ventasTotalesPorProductoToolStripMenuItem.Text = "Ventas Totales Por Producto";
            this.ventasTotalesPorProductoToolStripMenuItem.Click += new System.EventHandler(this.ventasTotalesPorProductoToolStripMenuItem_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.tabControl4);
            this.groupBox4.Location = new System.Drawing.Point(407, 349);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(372, 238);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Costos";
            // 
            // tabControl4
            // 
            this.tabControl4.Controls.Add(this.tabPage7);
            this.tabControl4.Controls.Add(this.tabPage8);
            this.tabControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl4.Location = new System.Drawing.Point(3, 16);
            this.tabControl4.Name = "tabControl4";
            this.tabControl4.SelectedIndex = 0;
            this.tabControl4.Size = new System.Drawing.Size(366, 219);
            this.tabControl4.TabIndex = 0;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.Costos);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(358, 193);
            this.tabPage7.TabIndex = 0;
            this.tabPage7.Text = "Grafico";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // Costos
            // 
            chartArea4.Name = "ChartArea1";
            this.Costos.ChartAreas.Add(chartArea4);
            this.Costos.Dock = System.Windows.Forms.DockStyle.Fill;
            legend4.Name = "Legend1";
            this.Costos.Legends.Add(legend4);
            this.Costos.Location = new System.Drawing.Point(3, 3);
            this.Costos.Name = "Costos";
            this.Costos.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.DodgerBlue,
        System.Drawing.Color.Fuchsia,
        System.Drawing.Color.Orange,
        System.Drawing.Color.Lime};
            this.Costos.Size = new System.Drawing.Size(352, 187);
            this.Costos.TabIndex = 2;
            this.Costos.Text = "chart3";
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.GridCosto);
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(358, 193);
            this.tabPage8.TabIndex = 1;
            this.tabPage8.Text = "Tabla";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // GridCosto
            // 
            this.GridCosto.AllowUserToAddRows = false;
            this.GridCosto.AllowUserToDeleteRows = false;
            this.GridCosto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridCosto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridCosto.Location = new System.Drawing.Point(3, 3);
            this.GridCosto.Name = "GridCosto";
            this.GridCosto.ReadOnly = true;
            this.GridCosto.Size = new System.Drawing.Size(352, 187);
            this.GridCosto.TabIndex = 2;
            // 
            // Reporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 599);
            this.ContextMenuStrip = this.Exportar;
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Filtrar);
            this.Controls.Add(this.FF);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FI);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "Reporte";
            this.Text = "Reporte";
            this.groupBox2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Ventas)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridVentas)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.tabControl3.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Existencias)).EndInit();
            this.tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridInventario)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Total)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridTotal)).EndInit();
            this.Exportar.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.tabControl4.ResumeLayout(false);
            this.tabPage7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Costos)).EndInit();
            this.tabPage8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridCosto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker FI;
        private System.Windows.Forms.DateTimePicker FF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Filtrar;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataVisualization.Charting.Chart Ventas;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl tabControl3;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DataVisualization.Charting.Chart Existencias;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataVisualization.Charting.Chart Total;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView GridVentas;
        private System.Windows.Forms.DataGridView GridInventario;
        private System.Windows.Forms.DataGridView GridTotal;
        private System.Windows.Forms.ContextMenuStrip Exportar;
        private System.Windows.Forms.ToolStripMenuItem exportarAExcelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasTotalesPorProductoToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TabControl tabControl4;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.DataVisualization.Charting.Chart Costos;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.DataGridView GridCosto;
        private System.Windows.Forms.ToolStripMenuItem costosToolStripMenuItem;
    }
}
