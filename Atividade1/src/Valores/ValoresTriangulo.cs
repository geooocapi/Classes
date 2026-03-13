using System;
using Area2;

Triangulo valor = new Triangulo();

Console.WriteLine("Insira a base do triângulo:");
valor.Base = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Insira a altura do triângulo:");
valor.Altura = Convert.ToDouble(Console.ReadLine());

valor.CalcularArea();