using Ejercicio1;

public class Rectangulo(double ancho, double largo) : Figura
{
    public double Ancho {  get; set; } = ancho;
    public double Largo { get; set; } = largo;

    public override double CalcularArea()
    {
        return Ancho * Largo;
    }

    public override double CalcularPerimetro()
    {
        return 2 * (Ancho + Largo);
    }
}
