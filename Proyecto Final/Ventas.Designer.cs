namespace Proyecto_Final
{
    partial class Ventas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.lbltotal = new System.Windows.Forms.TabPage();
            this.lblTotalFinal = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtExistencia = new System.Windows.Forms.TextBox();
            this.cmbProducto = new System.Windows.Forms.ComboBox();
            this.numericCantidad = new System.Windows.Forms.NumericUpDown();
            this.dataListDetalle = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtNit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGuardarVenta = new System.Windows.Forms.Button();
            this.txtPago = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.lbltotal.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataListDetalle)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.lbltotal);
            this.tabControl1.Location = new System.Drawing.Point(2, 6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(698, 467);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Click += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.listBox4);
            this.tabPage1.Controls.Add(this.listBox3);
            this.tabPage1.Controls.Add(this.listBox2);
            this.tabPage1.Controls.Add(this.listBox1);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(690, 441);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Lista de Ventas";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(455, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "usuario";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(335, 54);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "total";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(211, 54);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "fecha";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(81, 54);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "cliente";
            // 
            // listBox4
            // 
            this.listBox4.FormattingEnabled = true;
            this.listBox4.Location = new System.Drawing.Point(429, 79);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(120, 303);
            this.listBox4.TabIndex = 24;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(303, 79);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(120, 303);
            this.listBox3.TabIndex = 23;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(177, 79);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 303);
            this.listBox2.TabIndex = 22;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(51, 79);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 303);
            this.listBox1.TabIndex = 21;
            this.listBox1.Click += new System.EventHandler(this.lbltotal_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(609, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "Guardar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // lbltotal
            // 
            this.lbltotal.Controls.Add(this.lblTotalFinal);
            this.lbltotal.Controls.Add(this.label9);
            this.lbltotal.Controls.Add(this.groupBox2);
            this.lbltotal.Controls.Add(this.groupBox1);
            this.lbltotal.Controls.Add(this.btnGuardarVenta);
            this.lbltotal.Controls.Add(this.txtPago);
            this.lbltotal.Controls.Add(this.label6);
            this.lbltotal.Location = new System.Drawing.Point(4, 22);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Padding = new System.Windows.Forms.Padding(3);
            this.lbltotal.Size = new System.Drawing.Size(690, 441);
            this.lbltotal.TabIndex = 1;
            this.lbltotal.Text = "Nueva Venta";
            this.lbltotal.UseVisualStyleBackColor = true;
            this.lbltotal.Click += new System.EventHandler(this.lbltotal_Click);
            // 
            // lblTotalFinal
            // 
            this.lblTotalFinal.AutoSize = true;
            this.lblTotalFinal.Location = new System.Drawing.Point(103, 415);
            this.lblTotalFinal.Name = "lblTotalFinal";
            this.lblTotalFinal.Size = new System.Drawing.Size(22, 13);
            this.lblTotalFinal.TabIndex = 59;
            this.lblTotalFinal.Text = "0:0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 415);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 13);
            this.label9.TabIndex = 58;
            this.label9.Text = "Total a Pagar = ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtExistencia);
            this.groupBox2.Controls.Add(this.cmbProducto);
            this.groupBox2.Controls.Add(this.numericCantidad);
            this.groupBox2.Controls.Add(this.dataListDetalle);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtPrecio);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnAgregar);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(6, 90);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(678, 296);
            this.groupBox2.TabIndex = 53;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalle de Venta";
            // 
            // txtExistencia
            // 
            this.txtExistencia.AcceptsReturn = true;
            this.txtExistencia.Location = new System.Drawing.Point(94, 68);
            this.txtExistencia.Name = "txtExistencia";
            this.txtExistencia.Size = new System.Drawing.Size(132, 20);
            this.txtExistencia.TabIndex = 57;
            // 
            // cmbProducto
            // 
            this.cmbProducto.FormattingEnabled = true;
            this.cmbProducto.Location = new System.Drawing.Point(15, 35);
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.Size = new System.Drawing.Size(193, 21);
            this.cmbProducto.TabIndex = 40;
            this.cmbProducto.SelectedIndexChanged += new System.EventHandler(this.cmbProducto_SelectedIndexChanged);
            // 
            // numericCantidad
            // 
            this.numericCantidad.Location = new System.Drawing.Point(214, 36);
            this.numericCantidad.Name = "numericCantidad";
            this.numericCantidad.Size = new System.Drawing.Size(132, 20);
            this.numericCantidad.TabIndex = 41;
            // 
            // dataListDetalle
            // 
            this.dataListDetalle.AllowUserToAddRows = false;
            this.dataListDetalle.AllowUserToDeleteRows = false;
            this.dataListDetalle.AllowUserToResizeColumns = false;
            this.dataListDetalle.AllowUserToResizeRows = false;
            this.dataListDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataListDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataListDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListDetalle.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataListDetalle.Location = new System.Drawing.Point(11, 111);
            this.dataListDetalle.MultiSelect = false;
            this.dataListDetalle.Name = "dataListDetalle";
            this.dataListDetalle.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataListDetalle.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataListDetalle.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataListDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataListDetalle.ShowEditingIcon = false;
            this.dataListDetalle.Size = new System.Drawing.Size(647, 160);
            this.dataListDetalle.TabIndex = 54;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(361, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 56;
            this.label8.Text = "Precio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "Producto";
            // 
            // txtPrecio
            // 
            this.txtPrecio.AcceptsReturn = true;
            this.txtPrecio.Location = new System.Drawing.Point(404, 35);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(132, 20);
            this.txtPrecio.TabIndex = 55;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(297, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "Cantidad";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(590, 82);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(68, 23);
            this.btnAgregar.TabIndex = 44;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 46;
            this.label5.Text = "En existencia:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCliente);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.txtNit);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnVerificar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(678, 78);
            this.groupBox1.TabIndex = 57;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Encabezado de venta";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(214, 41);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(148, 20);
            this.txtCliente.TabIndex = 62;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(435, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 61;
            this.label7.Text = "Fecha:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(438, 38);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 60;
            // 
            // txtNit
            // 
            this.txtNit.Location = new System.Drawing.Point(11, 38);
            this.txtNit.Name = "txtNit";
            this.txtNit.Size = new System.Drawing.Size(100, 20);
            this.txtNit.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Nit:";
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(117, 35);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(75, 23);
            this.btnVerificar.TabIndex = 37;
            this.btnVerificar.Text = "Verificar Datos";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Cliente:";
            // 
            // btnGuardarVenta
            // 
            this.btnGuardarVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGuardarVenta.Location = new System.Drawing.Point(555, 410);
            this.btnGuardarVenta.Name = "btnGuardarVenta";
            this.btnGuardarVenta.Size = new System.Drawing.Size(116, 22);
            this.btnGuardarVenta.TabIndex = 53;
            this.btnGuardarVenta.Text = "Realizar Venta";
            this.btnGuardarVenta.UseVisualStyleBackColor = true;
            this.btnGuardarVenta.Click += new System.EventHandler(this.btnGuardarVenta_Click);
            // 
            // txtPago
            // 
            this.txtPago.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtPago.Location = new System.Drawing.Point(268, 414);
            this.txtPago.Name = "txtPago";
            this.txtPago.Size = new System.Drawing.Size(100, 20);
            this.txtPago.TabIndex = 49;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(272, 391);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 47;
            this.label6.Text = "Pago:";
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 474);
            this.Controls.Add(this.tabControl1);
            this.Name = "Ventas";
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.Ventas_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.lbltotal.ResumeLayout(false);
            this.lbltotal.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataListDetalle)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabPage lbltotal;
        private System.Windows.Forms.Button btnGuardarVenta;
        private System.Windows.Forms.TextBox txtPago;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericCantidad;
        private System.Windows.Forms.ComboBox cmbProducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNit;
        private System.Windows.Forms.DataGridView dataListDetalle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtExistencia;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTotalFinal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox1;
    }
}