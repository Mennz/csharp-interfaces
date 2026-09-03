class Triangulo : IFormaGeometrica
{
    public double LadoA;
    public double LadoB;
    public double LadoC;
    public double Base;
    public double Altura;

    public Triangulo(double ladoA, double ladoB, double ladoC, double @base, double altura)
    {
        LadoA = ladoA;
        LadoB = ladoB;
        LadoC = ladoC;
        Base = @base;
        Altura = altura;
    }

    public double CalcularArea()
    {
        // area por base e altura, nao pelos 3 lados (formula de Heron fica pra depois)
        return (Base * Altura) / 2;
    }

    public double CalcularPerimetro()
    {
        return LadoA + LadoB + LadoC;
    }
}
