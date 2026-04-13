namespace SistemaGeometrico;

public sealed class Circulo : Forma
{
    public double Raio { get; set; }

    public Circulo(double raio) : base("Círculo")
    {
        Raio = raio;
    }

    public override double CalcularArea()
    {
        return Math.PI * Raio * Raio;
    }
}
