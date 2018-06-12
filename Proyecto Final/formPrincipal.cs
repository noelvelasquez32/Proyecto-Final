using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final
{
    public partial class formPrincipal : Form
    {
        public formPrincipal()
        {
            InitializeComponent();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.MdiParent = this;
            usuario.Show();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            Clientes cliente = new Clientes();
            cliente.MdiParent = this;
            cliente.Show();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            Producto prod = new Producto();
            prod.MdiParent = this;
            prod.Show();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            Ventas venta = new Ventas();
            venta.MdiParent = this;
            venta.Show();
        }

        private void formPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
