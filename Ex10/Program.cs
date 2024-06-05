using Ex10;

class Program
{
    static void Main(string[] args)
    {
        List<int> intList = new List<int> { 1, 2, 2, 3, 4, 4, 5 };
        intList.RemoveRepetidos();
        Console.WriteLine("Lista de inteiros sem repetidos: " + string.Join(", ", intList));

        // Exemplo com strings
        List<string> stringList = new List<string> { "apple", "banana", "apple", "orange", "banana", "banana" };
        stringList.RemoveRepetidos();
        Console.WriteLine("Lista de strings sem repetidos: " + string.Join(", ", stringList));
    }
}