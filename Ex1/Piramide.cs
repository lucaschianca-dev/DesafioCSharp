namespace Ex1;

public class Piramide
{
    private int _n;

    public int N
    {
        get { return _n; }
        set
        {
            if (value < 1)
                throw new ArgumentException("N deve ser maior ou igual a 1");
            _n = value;
        }
    }

    public Piramide(int n)
    {
        if (n < 1)
            throw new ArgumentException("N deve ser maior ou igual a 1");
        _n = n;
    }

    public void Desenha()
    {
        for (int i = 1; i <= N; i++)
        {
            for (int j = N - i; j > 0; j--)
            {
                Console.Write(" ");
            }
            // ASC
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j);
            }
            // DESC
            for (int j = i - 1; j >= 1; j--)
            {
                Console.Write(j);
            }
            Console.WriteLine();
        }
    }
}
