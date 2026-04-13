using SistemaGeometrico;

static void ExibirDados(Forma forma)
{
    Console.WriteLine($"Forma: {forma.Nome}");
    Console.WriteLine($"Área:  {forma.CalcularArea():F2}");
}

static void ExibirDados(Forma forma, double escala)
{
    double areaRedimensionada = forma.CalcularArea() * escala;
    Console.WriteLine($"Forma: {forma.Nome}");
    Console.WriteLine($"Área com escala {escala}x: {areaRedimensionada:F2}");
}

Console.WriteLine("=== Sistema de Modelagem Geométrica ===\n");

List<Forma> formas = new List<Forma>
{
    new Circulo(raio: 5),
    new Retangulo(largura: 4, altura: 6),
    new Circulo(raio: 3),
    new Retangulo(largura: 10, altura: 2)
};

Console.WriteLine("--- Áreas calculadas (polimorfismo) ---");
for (int i = 0; i < formas.Count; i++)
{
    Forma f = formas[i];
    Console.WriteLine($"{f.Nome}: área = {f.CalcularArea():F2}");
}

Console.WriteLine("\n--- ExibirDados: Versão 1 (sem escala) ---");
ExibirDados(formas[0]); 
Console.WriteLine();
ExibirDados(formas[1]); 

Console.WriteLine("\n--- ExibirDados: Versão 2 (com escala) ---");
ExibirDados(formas[0], escala: 2.0); 
Console.WriteLine();
ExibirDados(formas[1], escala: 0.5);