namespace Ex2;

public class Vertice
{
    private double _x;
    private double _y;

    public double X
    {
        get { return _x; }
        private set { _x = value; }
    }

    public double Y
    {
        get { return _y; }
        private set { _y = value; }
    }

    public Vertice(double x, double y)
    {
        _x = x;
        _y = y;
    }

    public double Distancia(Vertice outro)
    {
        return Math.Sqrt(Math.Pow(outro.X - this.X, 2) + Math.Pow(outro.Y - this.Y, 2));
    }

    public void Move(double x, double y)
    {
        X = x;
        Y = y;
    }

    public bool Equals(Vertice outro)
    {
        return this.X == outro.X && this.Y == outro.Y;
    }
}