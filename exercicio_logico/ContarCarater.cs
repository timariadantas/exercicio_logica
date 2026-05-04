namespace exercicios_logico;

public class ContarCarater
{
    public static Dictionary<char, int> Contar (string texto){


        var dict = new Dictionary<char, int>();
        foreach (var c in texto)
        {
            
            if (dict.ContainsKey(c))
                dict[c]++;
            else
                dict[c] = 1;
        }
        
         Console.WriteLine("Contagem de caracter");

        foreach (var item in dict)
        {
            Console.WriteLine($"{item.Key}: {item.Value}");
        }
        return dict;
    }
    }

