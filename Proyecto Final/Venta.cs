using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Proyecto_Final
{
    class Venta
    {
    
       private string cliente;
        private DateTime fecha;
       private decimal totalfinal;
        private string usuario;

        public string Cliente
        {
            get
            {
                return cliente;
            }

            set
            {
                cliente = value;
            }
        }

        public DateTime Fecha
        {
            get
            {
                return fecha;
            }

            set
            {
                fecha = value;
            }
        }

        public decimal Totalfinal
        {
            get
            {
                return totalfinal;
            }

            set
            {
                totalfinal = value;
            }
        }

        public string Usuario
        {
            get
            {
                return usuario;
            }

            set
            {
                usuario = value;
            }
        }

        public Venta()
        {

        }

        public Venta(string cliente, DateTime fecha, decimal totalfianal, string usuario)
        {
            this.Cliente = cliente;
            this.Fecha = fecha;
            this.Totalfinal = totalfianal;
            this.Usuario = usuario;
        }


    }
}
