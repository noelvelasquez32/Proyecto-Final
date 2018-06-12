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
    public partial class Clientes : Form
    {
        int contador = 5;
        string Archivo = "C:\\Users\\Wilmar Velàsquez\\Desktop\\Proyecto Final\\Cliente.txt";
        public Clientes()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cliente clientes = new Cliente(Convert.ToInt32(txtId.Text),txtNombre.Text, txtApellido.Text, Convert.ToInt32(txtEdad.Text), txtNit.Text);

            StreamWriter Escribir = File.AppendText(Archivo);

            Escribir.WriteLine(txtId.Text+"/"+txtNombre.Text + "/" + txtApellido.Text + "/" + txtEdad.Text + "/" + txtNit.Text);
            MessageBox.Show("Los datos se guardaro");
            Escribir.Close();
            contador++;
            Globales.idcliente = contador;
            txtId.Text = Globales.idcliente.ToString();
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtEdad.Text = "";
            txtNit.Text = "";




        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            txtId.Text = contador.ToString();

        }
    }
}
