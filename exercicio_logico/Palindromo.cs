namespace exercicios_logico;

public class Palindromo
{
    public static bool Verificar(string palavra)
    {
        palavra = palavra.ToLower().Replace(" "," ");

        int inicioPalavra = 0;
        int fimPalavra = palavra.Length - 1;

        while (inicioPalavra < fimPalavra)
        {
            if (palavra[inicioPalavra] != palavra[fimPalavra])
            {
                Console.Write("Essa palavra não é um palindromo.\n");
                return false;
                
            }

            inicioPalavra++;
            fimPalavra--;
            
        }
        Console.Write("Essa palavra é um palindromo\n ");
        return true;
    }
}
