namespace Laboratorio141
{
    partial class frmProductos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.tstId = new System.Windows.Forms.TextBox();
            this.tsbEliminar = new System.Windows.Forms.Button();
            this.tsbGuardar = new System.Windows.Forms.Button();
            this.tsbBuscar = new System.Windows.Forms.Button();
            this.tsbNuevo = new System.Windows.Forms.Button();
            this.tsbCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label1.Location = new System.Drawing.Point(143, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label2.Location = new System.Drawing.Point(313, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label3.Location = new System.Drawing.Point(313, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Stock";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label4.Location = new System.Drawing.Point(143, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Precio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label5.Location = new System.Drawing.Point(247, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Buscar por id:";
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnSalir.Location = new System.Drawing.Point(129, 317);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(109, 52);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(147, 263);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(122, 20);
            this.txtPrecio.TabIndex = 6;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(147, 144);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 7;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(317, 144);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(273, 20);
            this.txtNombre.TabIndex = 8;
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(317, 263);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(127, 20);
            this.txtStock.TabIndex = 9;
            // 
            // tstId
            // 
            this.tstId.Location = new System.Drawing.Point(365, 21);
            this.tstId.Name = "tstId";
            this.tstId.Size = new System.Drawing.Size(198, 20);
            this.tstId.TabIndex = 10;
            // 
            // tsbEliminar
            // 
            this.tsbEliminar.Image = global::Laboratorio141.Properties.Resources.eliminar;
            this.tsbEliminar.Location = new System.Drawing.Point(201, 12);
            this.tsbEliminar.Name = "tsbEliminar";
            this.tsbEliminar.Size = new System.Drawing.Size(41, 37);
            this.tsbEliminar.TabIndex = 15;
            this.tsbEliminar.UseVisualStyleBackColor = true;
            // 
            // tsbGuardar
            // 
            this.tsbGuardar.Image = global::Laboratorio141.Properties.Resources.guardar;
            this.tsbGuardar.Location = new System.Drawing.Point(104, 12);
            this.tsbGuardar.Name = "tsbGuardar";
            this.tsbGuardar.Size = new System.Drawing.Size(44, 36);
            this.tsbGuardar.TabIndex = 14;
            this.tsbGuardar.UseVisualStyleBackColor = true;
            // 
            // tsbBuscar
            // 
            this.tsbBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tsbBuscar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.tsbBuscar.Image = global::Laboratorio141.Properties.Resources.buscar;
            this.tsbBuscar.Location = new System.Drawing.Point(569, 14);
            this.tsbBuscar.Name = "tsbBuscar";
            this.tsbBuscar.Size = new System.Drawing.Size(40, 34);
            this.tsbBuscar.TabIndex = 12;
            this.tsbBuscar.UseVisualStyleBackColor = true;
            // 
            // tsbNuevo
            // 
            this.tsbNuevo.Image = global::Laboratorio141.Properties.Resources.nuevo;
            this.tsbNuevo.Location = new System.Drawing.Point(58, 12);
            this.tsbNuevo.Name = "tsbNuevo";
            this.tsbNuevo.Size = new System.Drawing.Size(40, 39);
            this.tsbNuevo.TabIndex = 11;
            this.tsbNuevo.UseVisualStyleBackColor = true;
            // 
            // tsbCancelar
            // 
            this.tsbCancelar.Image = global::Laboratorio141.Properties.Resources.cancelar;
            this.tsbCancelar.Location = new System.Drawing.Point(154, 10);
            this.tsbCancelar.Name = "tsbCancelar";
            this.tsbCancelar.Size = new System.Drawing.Size(41, 41);
            this.tsbCancelar.TabIndex = 16;
            this.tsbCancelar.UseVisualStyleBackColor = true;
            // 
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tsbCancelar);
            this.Controls.Add(this.tsbEliminar);
            this.Controls.Add(this.tsbGuardar);
            this.Controls.Add(this.tsbBuscar);
            this.Controls.Add(this.tsbNuevo);
            this.Controls.Add(this.tstId);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "frmProductos";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox tstId;
        private System.Windows.Forms.Button tsbNuevo;
        private System.Windows.Forms.Button tsbBuscar;
        private System.Windows.Forms.Button tsbGuardar;
        private System.Windows.Forms.Button tsbEliminar;
        private System.Windows.Forms.Button tsbCancelar;
    }
}

