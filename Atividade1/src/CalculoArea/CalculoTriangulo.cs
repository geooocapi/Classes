using System;

namespace Area2
{
    internal class Triangulo
    {
        public double Base;
        public double Altura;

        public double CalcularArea()
        {
            return (Base * Altura) / 2;
        }
    }