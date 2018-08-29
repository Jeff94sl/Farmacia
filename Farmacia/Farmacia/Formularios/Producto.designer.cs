namespace Farmacia
{
    partial class Producto
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
            this.FechaCompra = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.Actualizar = new System.Windows.Forms.Button();
            this.Registrar = new System.Windows.Forms.Button();
            this.PUnitario = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.FechaVencimiento = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.PCompraTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CantidadTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TipoTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NombreTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CodigoTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.FechaCompra);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.Actualizar);
            this.groupBox1.Controls.Add(this.Registrar);
            this.groupBox1.Controls.Add(this.PUnitario);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.FechaVencimiento);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.PCompraTxt);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.CantidadTxt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TipoTxt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.NombreTxt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.CodigoTxt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(562, 191);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Producto";
            // 
            // FechaCompra
            // 
            this.FechaCompra.Location = new System.Drawing.Point(315, 70);
            this.FechaCompra.Name = "FechaCompra";
            this.FechaCompra.Size = new System.Drawing.Size(148, 20);
            this.FechaCompra.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(201, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "Fecha de Compra:";
            // 
            // Actualizar
            // 
            this.Actualizar.Location = new System.Drawing.Point(462, 150);
            this.Actualizar.Name = "Actualizar";
            this.Actualizar.Size = new System.Drawing.Size(75, 23);
            this.Actualizar.TabIndex = 17;
            this.Actualizar.Text = "Actualizar";
            this.Actualizar.UseVisualStyleBackColor = true;
            this.Actualizar.Click += new System.EventHandler(this.ActualizarClick);
            // 
            // Registrar
            // 
            this.Registrar.Location = new System.Drawing.Point(381, 150);
            this.Registrar.Name = "Registrar";
            this.Registrar.Size = new System.Drawing.Size(75, 23);
            this.Registrar.TabIndex = 16;
            this.Registrar.Text = "Registrar";
            this.Registrar.UseVisualStyleBackColor = true;
            this.Registrar.Click += new System.EventHandler(this.RegistrarClick);
            // 
            // PUnitario
            // 
            this.PUnitario.Location = new System.Drawing.Point(329, 44);
            this.PUnitario.Name = "PUnitario";
            this.PUnitario.Size = new System.Drawing.Size(134, 20);
            this.PUnitario.TabIndex = 11;
            this.PUnitario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidarPrecio);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(201, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Precio de Venta Unitario:";
            // 
            // FechaVencimiento
            // 
            this.FechaVencimiento.Location = new System.Drawing.Point(315, 99);
            this.FechaVencimiento.Name = "FechaVencimiento";
            this.FechaVencimiento.Size = new System.Drawing.Size(148, 20);
            this.FechaVencimiento.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(201, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Fecha de Vencimiento:";
            // 
            // PCompraTxt
            // 
            this.PCompraTxt.Location = new System.Drawing.Point(315, 16);
            this.PCompraTxt.Name = "PCompraTxt";
            this.PCompraTxt.Size = new System.Drawing.Size(148, 20);
            this.PCompraTxt.TabIndex = 9;
            this.PCompraTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidarPrecio);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(201, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Precio de Compra:";
            // 
            // CantidadTxt
            // 
            this.CantidadTxt.Location = new System.Drawing.Point(72, 95);
            this.CantidadTxt.Name = "CantidadTxt";
            this.CantidadTxt.Size = new System.Drawing.Size(111, 20);
            this.CantidadTxt.TabIndex = 7;
            this.CantidadTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidarCodigo);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(9, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cantidad:";
            // 
            // TipoTxt
            // 
            this.TipoTxt.Location = new System.Drawing.Point(53, 68);
            this.TipoTxt.Name = "TipoTxt";
            this.TipoTxt.Size = new System.Drawing.Size(130, 20);
            this.TipoTxt.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(7, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tipo:";
            // 
            // NombreTxt
            // 
            this.NombreTxt.Location = new System.Drawing.Point(53, 42);
            this.NombreTxt.Name = "NombreTxt";
            this.NombreTxt.Size = new System.Drawing.Size(130, 20);
            this.NombreTxt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(7, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre:";
            // 
            // CodigoTxt
            // 
            this.CodigoTxt.Location = new System.Drawing.Point(53, 16);
            this.CodigoTxt.Name = "CodigoTxt";
            this.CodigoTxt.Size = new System.Drawing.Size(130, 20);
            this.CodigoTxt.TabIndex = 1;
            this.CodigoTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidarCodigo);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo:";
            // 
            // Producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(587, 216);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Producto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Producto";
            this.Load += new System.EventHandler(this.ProductoLoad);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker FechaCompra;
        public System.Windows.Forms.Button Actualizar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox PUnitario;
        public System.Windows.Forms.Button Registrar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker FechaVencimiento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PCompraTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TipoTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CantidadTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NombreTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CodigoTxt;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
