using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto_Figuras
{
    class Circulo : Figura
    {
        public double raio;
        
        public Circulo(double raio)
        {
            this.raio = raio;            
        }

        public override double Area()
        {
            return raio * raio * Math.PI;
        }
    }
}