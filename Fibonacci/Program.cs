public class Program
{
    public static List<int> Fibonacci(int x)
    {
        List<int> resultado = new List<int>();

        if (x <= 0) return resultado;

        if (x >=1) resultado.Add(0);

        if (x >=2) resultado.Add(1);

        for (int i = 2; i < x; i++)
        {
            int proximo = resultado[i - 1] + resultado[i - 2];
            resultado.Add(proximo);
        }

        return resultado;
    }

    // Testes

    /*
    public static void Main()
    {
        Console.WriteLine(string.Join(", ", Fibonacci(3))); // 0, 1, 1
        Console.WriteLine(string.Join(", ", Fibonacci(5))); // 0, 1, 1, 2, 3
        Console.WriteLine(string.Join(", ", Fibonacci(7))); // 0, 1, 1, 2, 3, 5, 8
    }

    */
}
