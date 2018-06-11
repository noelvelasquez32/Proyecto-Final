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

        public string guardar(Venta venta, List<Detalle_venta>detalle)
        {
            string respuesta = "";
            return respuesta;
            
            int idventa;
            string idcliente;
            string factura;
            decimal totalfinal;
            

            idventa = venta.Idventa;
            idcliente = venta.Idcliente;
            factura = venta.Factura;
            totalfinal = venta.Totalfinal;

            foreach (Detalle_venta det in detalle)
            {
                det.Idventa = this.Idventa;
                det.guardar(det);
                break;

            }
        
        }

    }
}
