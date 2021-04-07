using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto_Figuras
{
    abstract public class Figura
    {
        public double ladoA { get; set; }
        public double ladoB { get; set; }
        public double ladoC { get; set; }
        
        public double valorTotal { get; set; }

        public abstract double Area();
    }
}