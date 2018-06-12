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
    public partial class Form1 : Form
    {


        string lineaT;
        string usuario;
        string contraseña;
        public string usuarioa;
        string contraseñaa;

        bool correcto = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string fileName = @"C:\\Users\\Wilmar Velàsquez\\Desktop\\Proyecto Final\\Usuarios.txt";

            //Abrimos el archivo, en este caso lo abrimos para lectura
            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader archivo = new StreamReader(stream);

            
            usuarioa = Convert.ToString(txtUsuario.Text);
            contraseñaa = Convert.ToString(textBox2.Text);
            Globales.usuario = usuario;


            while (archivo.Peek() > -1)
            {
                lineaT = archivo.ReadLine();
                string[] campos = lineaT.Split('/');
                usuario = (campos[1]);
                contraseña = (campos[2]);


                if (usuarioa == usuario && contraseñaa == contraseña)
                {
                    correcto = true;

                    formPrincipal principal = new formPrincipal();
                    principal.Show();
                    MessageBox.Show("Bienvendio");
                    this.Hide();
                    break;


                }
                else
                {
                    correcto = false;
                    MessageBox.Show("incorrecto");
                    break;
                    

                }
            }



            archivo.Close();

        }
    }
}
