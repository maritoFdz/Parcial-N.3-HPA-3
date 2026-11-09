using System;

namespace Ejercicio1
{
    public class Program
    {
        public static void Main()
        {
            Triangulo triangulo = new(12, 10.2, 5.8);
            Cuadrado cuadrado = new(2);
            Cuadrado cuadrado2 = new(7.98);
            Rectangulo rectangulo = new(10, 2);

            Figura[] figuras = [triangulo, cuadrado, cuadrado2, rectangulo];

            for (int i = 0; i < figuras.Length; i++)
            {
                Console.WriteLine("Figura N. " + (i + 1));
                Console.WriteLine("Tipo de Figura: " + figuras[i]);
                Console.WriteLine("Area: " + figuras[i].CalcularArea());
                Console.WriteLine("Perimetro: " + figuras[i].CalcularPerimetro());
            }
        }
    }
}