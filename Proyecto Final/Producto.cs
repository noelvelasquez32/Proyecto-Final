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
    public partial class Producto : Form
    {
        int contador = 4;
        string Archivo = "U:\\Proyecto Final\\Producto.txt";
        string lineaT;
        string[] campos;
        StreamReader archivo;

        int indiceE = -1;
        public Producto()
        {
            InitializeComponent();
        }


        public void seleccion(object sender, ListBox l)
        {
            l = sender as ListBox;

            if (l.SelectedIndex != -1)
            {
                listBox2.SelectedIndex = l.SelectedIndex;
                listBox3.SelectedIndex = l.SelectedIndex;
                listBox4.SelectedIndex = l.SelectedIndex;
                listBox1.SelectedIndex = l.SelectedIndex;
            }

            indiceE = Convert.ToSByte(listBox1.SelectedIndex);


            if (indiceE != -1)
            {

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Producto_Load(object sender, EventArgs e)
        {
            txtId.Text = contador.ToString();

            archivo = File.OpenText("C:\\Users\\Wilmar Velàsquez\\Desktop\\Proyecto Final\\Producto.txt");
            while ((lineaT = archivo.ReadLine()) != null)
            {
                campos = lineaT.Split('/');
                listBox1.Items.Add(campos[0]);
                listBox2.Items.Add(campos[1]);
                listBox3.Items.Add(campos[2]);
                listBox4.Items.Add(campos[3]);
               

                //if (cadena == campos[1])
                //{
                //  MessageBox.Show(campos[2]);
                //}

            }
            archivo.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Productos producto = new Productos(Convert.ToInt32(txtId.Text),txtNombre.Text,Convert.ToDecimal(txtPrecio.Text),Convert.ToInt32(txtExistencia.Text));

            StreamWriter Escribir = File.AppendText(Archivo);

            Escribir.WriteLine(txtId.Text + "/" + txtNombre.Text +"/"+ txtPrecio.Text +"/"+ txtExistencia.Text );
            MessageBox.Show("Los datos se guardaro");
            Escribir.Close();
            contador++;
            Globales.idproducto = contador;
            txtId.Text = Globales.idproducto.ToString();
            txtNombre.Text = "";
            txtPrecio.Text = "";
            txtExistencia.Text = "";
            




        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;
            if (l.SelectedIndex != -1)
            {
                listBox2.SelectedIndex = l.SelectedIndex;
                listBox3.SelectedIndex = l.SelectedIndex;
                listBox4.SelectedIndex = l.SelectedIndex;
                listBox1.SelectedIndex = l.SelectedIndex;
            }

            indiceE = Convert.ToSByte(listBox1.SelectedIndex);


            if (indiceE != -1)
            {

            }

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;
            if (l.SelectedIndex != -1)
            {
                listBox2.SelectedIndex = l.SelectedIndex;
                listBox3.SelectedIndex = l.SelectedIndex;
                listBox4.SelectedIndex = l.SelectedIndex;
                listBox1.SelectedIndex = l.SelectedIndex;
            }

            indiceE = Convert.ToSByte(listBox1.SelectedIndex);


            if (indiceE != -1)
            {

            }
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;
            if (l.SelectedIndex != -1)
            {
                listBox2.SelectedIndex = l.SelectedIndex;
                listBox3.SelectedIndex = l.SelectedIndex;
                listBox4.SelectedIndex = l.SelectedIndex;
                listBox1.SelectedIndex = l.SelectedIndex;
            }

            indiceE = Convert.ToSByte(listBox1.SelectedIndex);


            if (indiceE != -1)
            {

            }
        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;
            if (l.SelectedIndex != -1)
            {
                listBox2.SelectedIndex = l.SelectedIndex;
                listBox3.SelectedIndex = l.SelectedIndex;
                listBox4.SelectedIndex = l.SelectedIndex;
                listBox1.SelectedIndex = l.SelectedIndex;
            }

            indiceE = Convert.ToSByte(listBox1.SelectedIndex);


            if (indiceE != -1)
            {

            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
