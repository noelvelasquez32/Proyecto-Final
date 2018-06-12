using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Proyecto_Final
{
    public partial class Ventas : Form
    {
        DataTable dtDetalle;
        StreamReader archivo;
        StreamReader archivoa;
        StreamReader ArchivoCliente;

        decimal total, subtotal;

        string lineaT;
        string lineaTVenta;
        string lineaTCliente;
      
        string[] campos;
        string[] camposVenta;
        string[] camposcCliente;
        public Ventas()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbltotal_Click(object sender, EventArgs e)
        {

        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            //string cadena = "cocacola";
            archivo = File.OpenText("C:\\Users\\Wilmar Velàsquez\\Desktop\\Proyecto Final\\Producto.txt");
            while ((lineaT = archivo.ReadLine())!=null)
            {
                campos = lineaT.Split('/');
                cmbProducto.Items.Add(campos[1]);
                //if (cadena == campos[1])
                //{
                  //  MessageBox.Show(campos[2]);
                //}

            }
            archivo.Close();

          
            
            //______creacion de tabla y especificacion de tipo de datos por cada columna

            this.dtDetalle = new DataTable("dtDetalle");

            this.dtDetalle.Columns.Add("Producto", System.Type.GetType("System.String"));
            this.dtDetalle.Columns.Add("Cantidad", System.Type.GetType("System.Int32"));

            this.dtDetalle.Columns.Add("Precio", System.Type.GetType("System.Decimal"));
            



            this.dataListDetalle.DataSource = this.dtDetalle;


            

            archivoa = File.OpenText("U:\\Proyecto Final\\Ventas.txt");
            while ((lineaTVenta = archivoa.ReadLine()) != null)
            {
                campos = lineaTVenta.Split('/');
                listBox1.Items.Add(camposVenta[0]);
                listBox2.Items.Add(camposVenta[1]);
                listBox3.Items.Add(camposVenta[2]);
                listBox4.Items.Add(camposVenta[3]);


                //if (cadena == campos[1])
                //{
                //  MessageBox.Show(campos[2]);
                //}

            }
            archivo.Close();


        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (numericCantidad.Value <= 0)
            {
                MessageBox.Show("La cantidad a vender no puede ser 0");
            }
            else
            {
                DataRow row = this.dtDetalle.NewRow();
                row["Producto"] = cmbProducto.Text;
                row["Cantidad"] = Convert.ToInt32(numericCantidad.Value);
                row["Precio"] = Convert.ToDecimal(txtPrecio.Text);

                if (Convert.ToInt32(numericCantidad.Value) > Convert.ToInt32(txtExistencia.Text))
                {
                    MessageBox.Show("La cantidad es mayor a la existencia actual");
                }
                else
                {
                    this.dtDetalle.Rows.Add(row);

                    string lineaT1;
                    int diferencia;
                    archivo = File.OpenText("U:\\Proyecto Final\\Producto.txt");
                    StreamWriter Escribir = File.CreateText("tmp.txt");

                    lineaT1 = archivo.ReadLine();
                    while (lineaT1 != null)
                    {
                        string[] campos1 = lineaT1.Split('/');
                        //cmbProducto.Items.Add(campos[1]);
                        if (campos1[1].Trim().Equals(cmbProducto.Text))
                        {
                            txtPrecio.Text = campos1[2];
                            txtExistencia.Text = campos1[3];

                            diferencia = Convert.ToInt32(txtExistencia.Text) - Convert.ToInt32(numericCantidad.Value);

                            txtExistencia.Text = diferencia.ToString();

                            Escribir.WriteLine(campos1[0] + "/" + campos1[1] + "/" + campos1[2] + "/" + diferencia);


                            MessageBox.Show("Los datos se guardaro");



                        }
                        else
                        {
                            Escribir.WriteLine(lineaT1);
                        }

                        lineaT1 = archivo.ReadLine();
                    }
                    archivo.Close();
                    Escribir.Close();

                    File.Delete("C:\\Users\\Wilmar Velàsquez\\Desktop\\Proyecto Final\\Producto.txt");
                    File.Move("tmp.txt", "C:\\Users\\Wilmar Velàsquez\\Desktop\\Proyecto Final\\Producto.txt");
                    subtotal = Convert.ToDecimal(txtPrecio.Text) * numericCantidad.Value;
                    total = total + subtotal;
                    lblTotalFinal.Text = total.ToString();


                }
            }
            

           
            

           



           
        }

        /// <summary>
        /// f
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVerificar_Click(object sender, EventArgs e)
        {
            ArchivoCliente = File.OpenText("U:\\Proyecto Final\\Cliente.txt");
            while ((lineaTCliente = ArchivoCliente.ReadLine()) != null)
            {
                string []camposcCliente1 = lineaTCliente.Split('/');
                //cmbClientes.Items.Add(camposcCliente[1]);
                if (camposcCliente1[4].Trim().Equals(txtNit.Text))
                {
                    txtCliente.Text = camposcCliente1[1];
                }

             

            }
            ArchivoCliente.Close();
        }

        private void btnGuardarVenta_Click(object sender, EventArgs e)
        {
            decimal vuelto;
            vuelto = Convert.ToDecimal(txtPago.Text) - Convert.ToDecimal(lblTotalFinal.Text);
            MessageBox.Show("Su vuelto es de : = " + vuelto.ToString());

            Venta venta = new Venta(txtCliente.Text,dateTimePicker1.Value,Convert.ToDecimal(lblTotalFinal.Text),Globales.usuario);
        }

 

        private void cmbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbProducto.SelectedIndex > -1)
            {
                string lineaT1;
                //StreamReader archivo1 = new StreamReader("U:\\Proyecto Final\\Producto.txt");
                archivo = new StreamReader("U:\\Proyecto Final\\Producto.txt");
                while ((lineaT1 = archivo.ReadLine()) != null)
                {
                    string[] campos1 = lineaT1.Split('/');
                    //cmbProducto.Items.Add(campos[1]);
                    if (cmbProducto.Text == campos1[1])
                    {
                        txtPrecio.Text = campos1[2];
                        txtExistencia.Text = campos1[3];
                       
                    }
                   
                }
                archivo.Close();

            }
            
           


        }
    }
}
