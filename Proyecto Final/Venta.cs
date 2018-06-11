using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final
{
    class Venta
    {
       private int idventa;
       private string idcliente;
       private string factura;
       private decimal totalfinal;


        public int Idventa
        {
            get
            {
                return idventa;
            }

            set
            {
                idventa = value;
            }
        }

        public string Idcliente
        {
            get
            {
                return idcliente;
            }

            set
            {
                idcliente = value;
            }
        }

        public string Factura
        {
            get
            {
                return factura;
            }

            set
            {
                factura = value;
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


        public Venta()
        {

        }

        public Venta(int idventa, string idcliente, string factura, decimal totalfinal)
        {
            this.Idventa = idventa;
            this.Idcliente = idcliente;
            this.Factura = factura;
            this.Totalfinal = totalfinal;

        }


    }
}
