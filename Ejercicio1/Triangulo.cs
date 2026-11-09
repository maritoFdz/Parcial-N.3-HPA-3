using Ejercicio1;

public class Triangulo(double ladoA, double ladoB, double ladoC) : Figura
{
    public double LadoA { get; set; } = ladoA;
    public double LadoB { get; set; } = ladoB;
    public double LadoC { get; set; } = ladoC;

    public override double CalcularArea()
    {
        double s = (LadoA + LadoB + LadoC) / 2;
        return Math.Sqrt(s * (s - LadoA) * (s - LadoB) * (s - LadoC));
    }

    public override double CalcularPerimetro()
    {
        return LadoA + LadoB + LadoC;
    }
}