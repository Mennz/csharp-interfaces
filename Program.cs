List<IFormaGeometrica> formas = new List<IFormaGeometrica>
{
    new Circulo(5),
    new Retangulo(4, 6),
    new Triangulo(3, 4, 5, 4, 3)
};

foreach (var forma in formas)
{
    Console.WriteLine(forma.GetType().Name);
    Console.WriteLine("area: " + forma.CalcularArea());
    Console.WriteLine("perimetro: " + forma.CalcularPerimetro());
    Console.WriteLine();
}
