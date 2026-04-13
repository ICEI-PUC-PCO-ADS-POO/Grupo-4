namespace SistemaGeometrico;

public partial class Retangulo : Forma
{
    public double Largura { get; set; }
    public double Altura { get; set; }

    public Retangulo(double largura, double altura) : base("Retângulo")
    {
        Largura = largura;
        Altura = altura;
    }
}
