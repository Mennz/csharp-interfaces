class Circulo : IFormaGeometrica
{
    public double Raio;

    public Circulo(double raio)
    {
        Raio = raio;
    }

    public double CalcularArea()
    {
        return Math.PI * Raio * Raio;
    }

    public double CalcularPerimetro()
    {
        return 2 * Math.PI * Raio;
    }
}
