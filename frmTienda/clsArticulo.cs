using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmTienda
{
     abstract class clsArticulo
     {
        private  string nombre;
        private double precio;
        private double iva;
        private int tipo;
        

        public clsArticulo(string nombre, double precio, double iva, int tipo)
        {
            this.Nombre = nombre;//Está asignando el valor del parámetro nombre al atributo Nombre del objeto actual (this).
            this.Precio = precio;
            this.Iva = iva;
            this.Tipo = tipo;
            
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public double Precio { get => precio; set => precio = value; }
        public double Iva { get => iva; set => iva = value; }
        public int Tipo { get => tipo; set => tipo = value; }

        public abstract double precio1(double descuento, double iva);

        //public abstract double precio1(double precio, double descuento, double iva)
        //{
        //    double montoIVA = precio * (iva / 100);
        //    double precioConIVA = precio + montoIVA;
        //    double montoDescuento = precioConIVA * (descuento / 100);
        //    double precioFinal = precioConIVA - montoDescuento;
        //    return precioFinal;



        //}


    }
}
