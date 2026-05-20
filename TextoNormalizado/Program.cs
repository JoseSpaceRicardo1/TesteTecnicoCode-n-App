using System;
using System.Text;
using System.Text.RegularExpressions;
public class Program
{
    public static string TextoNormalizado(string texto)
    {
        if (string.IsNullOrEmpty(texto)) return texto;
        StringBuilder a = new StringBuilder();

        for (int i = 0; i <texto.Length; i++)
            {
                char atual = texto[i];
                
                if (a.Length == 0)
                {
                    a.Append(atual);
                    continue;
                }
                char anterior = a[a.Length - 1];
                
                if (atual == '?' && anterior == '?') continue;
                if (atual == '!' && anterior == '!') continue;
                if (atual == '!' && anterior == '?') continue;
                {
                    if (a.Length > 1 && a[a.Length - 2] == '!') continue;
                }
            a.Append(atual);
        }
        return a.ToString();
    }
    
    /*
    //______________________________________________________Com Regex_______________________________________________________________________________________________________//

    
    public static string TextoNormalizado(string texto)
    {
        if (string.IsNullOrEmpty(texto)) return texto;
        string resultado = Regex.Replace(texto, @"\?+\!+", "?!");
        resultado = Regex.Replace(resultado,@"\?+", "?");
        resultado = Regex.Replace(resultado,@"\!+", "!");
        return resultado;
    }
    

    //______________________________________________________________________________________________________________________________________________________________________//
    */

    // Testes
    /*
   
    public static void Main()
    {
        Console.WriteLine(TextoNormalizado("Como é???????")); // "Como é?!"
        Console.WriteLine(TextoNormalizado("Não!!!!!!!!")); // "Não!"
        Console.WriteLine(TextoNormalizado("O que???!!!!! Não acredito!!!")); // "O que?! Não acredito!"
    }

    */
    
}