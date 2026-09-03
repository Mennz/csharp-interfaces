List<IFormaGeometrica> formas = new List<IFormaGeometrica>
{
    new Circulo(5),
    new Retangulo(4, 6),
    new Triangulo(3, 4, 5, 4, 3)
};

foreach (var forma in formas)
{
    Console.WriteLine(forma.GetType().Name);
    // arredonda pra nao mostrar aquela dizima gigante do circulo
    Console.WriteLine("area: " + Math.Round(forma.CalcularArea(), 2));
    Console.WriteLine("perimetro: " + Math.Round(forma.CalcularPerimetro(), 2));
    Console.WriteLine();
}
