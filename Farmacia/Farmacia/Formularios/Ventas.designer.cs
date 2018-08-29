namespace Farmacia
{
    partial class Ventas
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Facturar = new System.Windows.Forms.Button();
            this.Agregar = new System.Windows.Forms.Button();
            this.Total = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PCantidad = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.PrecioTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ProductosCmb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Carrito = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Neto = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PCantidad)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Carrito)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.Facturar);
            this.groupBox1.Controls.Add(this.Agregar);
            this.groupBox1.Controls.Add(this.Total);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.PCantidad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.PrecioTxt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ProductosCmb);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(544, 136);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle de Venta";
            // 
            // Facturar
            // 
            this.Facturar.Location = new System.Drawing.Point(319, 77);
            this.Facturar.Name = "Facturar";
            this.Facturar.Size = new System.Drawing.Size(75, 23);
            this.Facturar.TabIndex = 9;
            this.Facturar.Text = "Facturar";
            this.Facturar.UseVisualStyleBackColor = true;
            this.Facturar.Click += new System.EventHandler(this.FacturarClick);
            // 
            // Agregar
            // 
            this.Agregar.Location = new System.Drawing.Point(238, 78);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(75, 23);
            this.Agregar.TabIndex = 8;
            this.Agregar.Text = "Agregar";
            this.Agregar.UseVisualStyleBackColor = true;
            this.Agregar.Click += new System.EventHandler(this.AgregarClick);
            // 
            // Total
            // 
            this.Total.Location = new System.Drawing.Point(284, 21);
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Size = new System.Drawing.Size(100, 20);
            this.Total.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(246, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Total:";
            // 
            // PCantidad
            // 
            this.PCantidad.Location = new System.Drawing.Point(74, 80);
            this.PCantidad.Name = "PCantidad";
            this.PCantidad.Size = new System.Drawing.Size(147, 20);
            this.PCantidad.TabIndex = 5;
            this.PCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PCantidad.ValueChanged += new System.EventHandler(this.PCantidadValueChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(7, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cantidad:";
            // 
            // PrecioTxt
            // 
            this.PrecioTxt.Location = new System.Drawing.Point(74, 46);
            this.PrecioTxt.Name = "PrecioTxt";
            this.PrecioTxt.ReadOnly = true;
            this.PrecioTxt.Size = new System.Drawing.Size(147, 20);
            this.PrecioTxt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(8, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Precio:";
            // 
            // ProductosCmb
            // 
            this.ProductosCmb.FormattingEnabled = true;
            this.ProductosCmb.Location = new System.Drawing.Point(74, 20);
            this.ProductosCmb.Name = "ProductosCmb";
            this.ProductosCmb.Size = new System.Drawing.Size(147, 21);
            this.ProductosCmb.TabIndex = 1;
            this.ProductosCmb.SelectedIndexChanged += new System.EventHandler(this.ProductosCmbSelectedIndexChanged);
            this.ProductosCmb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ProductosCmbKeyPress);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Producto:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.Carrito);
            this.groupBox2.Location = new System.Drawing.Point(13, 156);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(544, 129);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Carrito";
            // 
            // Carrito
            // 
            this.Carrito.AllowUserToAddRows = false;
            this.Carrito.AllowUserToDeleteRows = false;
            this.Carrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Carrito.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Carrito.Location = new System.Drawing.Point(3, 16);
            this.Carrito.Name = "Carrito";
            this.Carrito.ReadOnly = true;
            this.Carrito.Size = new System.Drawing.Size(538, 110);
            this.Carrito.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Neto);
            this.groupBox3.Location = new System.Drawing.Point(400, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(138, 111);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tatol A Pagar";
            // 
            // Neto
            // 
            this.Neto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Neto.Location = new System.Drawing.Point(3, 16);
            this.Neto.Name = "Neto";
            this.Neto.ReadOnly = true;
            this.Neto.Size = new System.Drawing.Size(132, 92);
            this.Neto.TabIndex = 0;
            this.Neto.Text = "";
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(569, 297);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Ventas";
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.VentasLoad);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PCantidad)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Carrito)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.DataGridView Carrito;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Total;
        private System.Windows.Forms.Button Agregar;
        private System.Windows.Forms.Button Facturar;
        private System.Windows.Forms.NumericUpDown PCantidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ProductosCmb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PrecioTxt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox Neto;
    }
}
