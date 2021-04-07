using System;
using System.Collections.Generic;
using System.Text;

namespace Teste_Pedro
{
    class Quadrado : Figura
    {
        public Quadrado(double ladoA)
        {
            this.ladoA = ladoA;
        }

        public override double Area()
        {
            return ladoA * ladoA;
        }
    }
}