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
            Cliente clientes = new Cliente(txtNombre.Text, txtApellido.Text, Convert.ToInt32(txtEdad.Text), txtNit.Text);

            StreamWriter Escribir = File.AppendText(Archivo);

            Escribir.WriteLine(txtNombre.Text + "/" + txtApellido.Text + "/" + txtEdad.Text + "/" + txtNit.Text);
            MessageBox.Show("Los datos se guardaro");
            Escribir.Close();
        }
    }
}
