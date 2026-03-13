using System;
using Area1;

Retangulo valor = new Retangulo();

Console.WriteLine("Insira a base do retângulo:");
valor.Base = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Insira a altura do retângulo:");
valor.Altura = Convert.ToInt32(Console.ReadLine());

valor.CalcularArea();
