namespace Ex10;
using System.Collections.Generic;

public static class MetodoExtensao
{
    public static void RemoveRepetidos<T>(this List<T> lista)
    {
        HashSet<T> uniqueItems = new HashSet<T>();
        for (int i = lista.Count - 1; i >= 0; i--)
        {
            if (!uniqueItems.Add(lista[i]))
            {
                lista.RemoveAt(i);
            }
        }
    }
}