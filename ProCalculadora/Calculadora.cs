﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProCalculadora
{
    public class Calculadora
    {
        public int PrimerNumero{ get; set; }
        public int SegundoNumero { get; set; }

        public int Sumar()
        {
            return PrimerNumero + SegundoNumero;
        }

        public int Restar()
        {
            return PrimerNumero - SegundoNumero;
        }

        public int Multiplicar()
        {
            return PrimerNumero * SegundoNumero;
        }

        public int Dividir()
        {
            return PrimerNumero / SegundoNumero;
        }
    }
}
