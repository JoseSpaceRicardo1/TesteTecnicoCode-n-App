public class Program
{
    public static bool Palindromo(string input)
    {
        if (string.IsNullOrEmpty(input))
        {
            return false;
        }
        string limpainput = "";
        foreach (char c in input)
        {
            if (char.IsLetterOrDigit(c))
            {
                limpainput += char.ToLower(c);
            }
        }
        string reverso = "";
        for (int i = limpainput.Length - 1; i >= 0; i--)
        {
            reverso += limpainput[i];
        }
        return limpainput == reverso;
    }
    // Testes
    /*
    
    public static void Main()
    {
        Console.WriteLine(Palindromo("Arara")); // true
        Console.WriteLine(Palindromo("O lobo, ama o bolo")); // true
        Console.WriteLine(Palindromo("Roma me tem amor")); // true
        Console.WriteLine(Palindromo("DotNet")); // false
    }
    */
    
}