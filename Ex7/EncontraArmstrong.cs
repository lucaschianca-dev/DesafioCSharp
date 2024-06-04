using Ex7.Extensoes;

namespace Ex7;

public class EncontraArmstrong
{
    public void ImprimeNumerosArmstrong(int inicio, int fim)
    {
        for (int i = inicio; i <= fim; i++)
        {
            if (i.IsArmstrong())
            {
                Console.WriteLine(i);
            }
        }
    }
}
