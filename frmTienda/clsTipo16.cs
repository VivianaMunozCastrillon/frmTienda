﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmTienda
{
    internal class clsTipo16 : clsArticulo
    {
        public clsTipo16(string nombre, double precio, double iva, int tipo )
            : base(nombre, precio, iva, tipo) //En el constructor de clsTipo4, se esta llamando
                                              //al constructor de la clase base clsArticulo para inicializar las propiedades heredadas.
        {
           this.tipo = 4;
        }

        public double tipo { get; set; }

        public override double precio1(double precio, double iva) //override:indica que el método de la subclase está proporcionando una
                                                                  //implementación específica del metodo de la clase padre
        {
            double montoIVA = Precio * (iva / 100);
            double precioConIVA = Precio + montoIVA;
            double montoDescuento = precioConIVA * (0.016 / 100);
            double precioFinal = precioConIVA - montoDescuento;
            return precioFinal;
        }

        //public double precio1(double precio, double iva)
        //{
        //    double montoIVA = precio * (iva / 100);
        //    double precioConIVA = precio + montoIVA;
        //    double montoDescuento = precioConIVA * 0.6 ;
        //    double precioFinal = precioConIVA - montoDescuento;
        //    return precioFinal;


        //}


    }
}
