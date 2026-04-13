namespace SistemaGeometrico;

public abstract class Forma
{
    public string Nome { get; set; }

    protected Forma(string nome)
    {
        Nome = nome;
    }

    public abstract double CalcularArea();
}
