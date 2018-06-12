namespace Proyecto_Final
{
    partial class formPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnProductosVendidos = new System.Windows.Forms.Button();
            this.btnVentas = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.btnClientes);
            this.panel1.Controls.Add(this.btnProductos);
            this.panel1.Controls.Add(this.btnProductosVendidos);
            this.panel1.Controls.Add(this.btnVentas);
            this.panel1.Controls.Add(this.btnUsuarios);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(184, 490);
            this.panel1.TabIndex = 0;
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnClientes.Location = new System.Drawing.Point(3, 96);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(178, 46);
            this.btnClientes.TabIndex = 4;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnProductos.Location = new System.Drawing.Point(3, 148);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(178, 46);
            this.btnProductos.TabIndex = 3;
            this.btnProductos.Text = "Productos";
            this.btnProductos.UseVisualStyleBackColor = false;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnProductosVendidos
            // 
            this.btnProductosVendidos.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnProductosVendidos.Location = new System.Drawing.Point(3, 252);
            this.btnProductosVendidos.Name = "btnProductosVendidos";
            this.btnProductosVendidos.Size = new System.Drawing.Size(178, 46);
            this.btnProductosVendidos.TabIndex = 2;
            this.btnProductosVendidos.Text = "Productos Vendidos";
            this.btnProductosVendidos.UseVisualStyleBackColor = false;
            // 
            // btnVentas
            // 
            this.btnVentas.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnVentas.Location = new System.Drawing.Point(3, 200);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(178, 46);
            this.btnVentas.TabIndex = 1;
            this.btnVentas.Text = "Ventas";
            this.btnVentas.UseVisualStyleBackColor = false;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnUsuarios.Location = new System.Drawing.Point(3, 44);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(178, 46);
            this.btnUsuarios.TabIndex = 0;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.UseVisualStyleBackColor = false;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // formPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 490);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "formPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.formPrincipal_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnProductosVendidos;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Button btnUsuarios;
    }
}