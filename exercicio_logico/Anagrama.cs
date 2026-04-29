namespace exercicios_logico;

public class Anagrama
{
    public static bool VerificarAnagrama(string palavra1, string palavra2)
    {
        palavra1 = palavra1.ToLower().Replace(" ", " ");
        palavra2 = palavra2.ToLower().Replace(" ", " ");

        if (palavra1.Length != palavra2.Length)
            return false;

        Dictionary<char ,int> contador = new Dictionary<char, int>();

        foreach (char c in palavra1)
        {
            if (contador.ContainsKey(c))
                contador[c]++;
            else 
                contador[c] = 1;
        }

        foreach (char c in palavra2)
        {
            if(!contador.ContainsKey(c))
                return false;

            contador[c]--;

            if(contador[c]< 0)
                return false;

        }
        return true;
        
    }
}
