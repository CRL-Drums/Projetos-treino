using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto_Figuras
{
    class Retangulo : Figura
    {
        public Retangulo(double ladoA, double ladoB)
        {
            this.ladoA = ladoA;
            this.ladoB = ladoB;
        }

        public override double Area()
        {
            return ladoA * ladoB;
        }
    }
}
