using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto_Figuras.Entities
{
    class Triangulo : Figura
    {

        public Triangulo(double ladoA, double ladoB, double ladoC)
        {
            this.ladoA = ladoA;
            this.ladoB = ladoB;
            this.ladoC = ladoC;
        }

        public override double Area()
        {
            double p = (base.ladoA + base.ladoB + base.ladoC) / 2.0;
            return Math.Sqrt(p * (p - base.ladoA) * (p - base.ladoB) * (p - base.ladoC));
        }
    }
}
