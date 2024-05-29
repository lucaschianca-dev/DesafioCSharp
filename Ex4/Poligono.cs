using Ex2;

namespace Ex4;

public class Poligono
{
    private List<Vertice> _vertices;

    public Poligono(List<Vertice> vertices)
    {
        if (vertices == null || vertices.Count < 3)
        {
            throw new ArgumentException("O polígono deve ter pelo menos 3 vértices.");
        }

        _vertices = new List<Vertice>(vertices);
    }

    public bool AddVertice(Vertice v)
    {
        if (_vertices.Contains(v))
        {
            return false;
        }
        _vertices.Add(v);
        return true;
    }

    public void RemoveVertice(Vertice v)
    {
        if (_vertices.Count <= 3)
        {
            throw new InvalidOperationException("O polígono deve ter pelo menos 3 vértices.");
        }

        if (!_vertices.Remove(v))
        {
            throw new ArgumentException("O vértice não existe no polígono.");
        }
    }

    public double Perimetro()
    {
        double perimetro = 0.0;

        for (int i = 0; i < _vertices.Count; i++)
        {
            Vertice atual = _vertices[i];
            Vertice proximo = _vertices[(i + 1) % _vertices.Count];
            perimetro += atual.Distancia(proximo);
        }

        return perimetro;
    }

    public int QuantidadeDeVertices
    {
        get { return _vertices.Count; }
    }
}