using Ex2;

namespace Ex3;

public enum TipoTriangulo
{
    Equilatero,
    Isosceles,
    Escaleno
}

public class Triangulo
{
    private Vertice _v1;
    private Vertice _v2;
    private Vertice _v3;

    public Vertice V1
    {
        get { return _v1; }
        private set { _v1 = value; }
    }

    public Vertice V2
    {
        get { return _v2; }
        private set { _v2 = value; }
    }

    public Vertice V3
    {
        get { return _v3; }
        private set { _v3 = value; }
    }

    public Triangulo(Vertice v1, Vertice v2, Vertice v3)
    {
        if (!FormamTriangulo(v1, v2, v3))
            throw new ArgumentException("Os vértices não formam um triângulo");

        _v1 = v1;
        _v2 = v2;
        _v3 = v3;
    }

    private bool FormamTriangulo(Vertice v1, Vertice v2, Vertice v3)
    {
        double a = v1.Distancia(v2);
        double b = v2.Distancia(v3);
        double c = v3.Distancia(v1);
        return a + b > c && a + c > b && b + c > a;
    }

    public double Perimetro
    {
        get
        {
            double a = _v1.Distancia(_v2);
            double b = _v2.Distancia(_v3);
            double c = _v3.Distancia(_v1);
            return a + b + c;
        }
    }

    public TipoTriangulo Tipo
    {
        get
        {
            double a = _v1.Distancia(_v2);
            double b = _v2.Distancia(_v3);
            double c = _v3.Distancia(_v1);

            if (a == b && b == c)
            {
                return TipoTriangulo.Equilatero;
            }
            else if (a == b || b == c || a == c)
            {
                return TipoTriangulo.Isosceles;
            }
            else
            {
                return TipoTriangulo.Escaleno;
            }
        }
    }

    public double Area
    {
        get
        {
            double a = _v1.Distancia(_v2);
            double b = _v2.Distancia(_v3);
            double c = _v3.Distancia(_v1);
            double s = Perimetro / 2;
            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }
    }

    public bool Equals(Triangulo outro)
    {
        var verticesThis = new List<Vertice> { _v1, _v2, _v3 };
        var verticesOutro = new List<Vertice> { outro.V1, outro.V2, outro.V3 };

        verticesThis.Sort((a, b) => a.GetHashCode().CompareTo(b.GetHashCode()));
        verticesOutro.Sort((a, b) => a.GetHashCode().CompareTo(b.GetHashCode()));

        return verticesThis[0].Equals(verticesOutro[0]) &&
               verticesThis[1].Equals(verticesOutro[1]) &&
               verticesThis[2].Equals(verticesOutro[2]);
    }

    public override bool Equals(object obj)
    {
        if (obj is Triangulo outro)
        {
            return Equals(outro);
        }
        return false;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(_v1, _v2, _v3);
    }
}