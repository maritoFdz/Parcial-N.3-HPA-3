using Ejercicio1;

public class Cuadrado(double lado) : Figura
{
    public double Lado { get; set; } = lado;

    public override double CalcularArea()
    {
        return Lado * Lado;
    }

    public override double CalcularPerimetro()
    {
        return 4 * Lado;
    }
}
