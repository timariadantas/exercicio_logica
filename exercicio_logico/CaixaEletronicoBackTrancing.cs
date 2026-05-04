namespace exercicios_logico;

public class CaixaEletronico
{
    private static readonly int [] notas = [200, 100, 50 , 20];
    public static void Sacar(int valor)
    {
        Console.WriteLine($"Saque: {valor} \n" );
        
        ResolverSaque(valor, 0, new List<int>());
      
    }
    public static void ResolverSaque(int valor , int index , List<int> caminho)
    {
        if (valor == 0)
        {
            Console.WriteLine(string.Join(" ", caminho));
    
            
            return;
        }
          
        
        if (index >= notas.Length)
            return;
        
        int nota = notas[index];

        for (int i = valor / nota; i >= 0; i--)
        {
         
            for (int j = 0; j<i ; j++)
                caminho.Add(nota);


            int resto = valor - (i * nota);

             ResolverSaque(resto, index + 1, caminho);
             
             for (int j = 0; j < i; j++)
                caminho.RemoveAt(caminho.Count - 1);
        }
    }

}
    
// Explora todas as combinações possíveis de notas usando backtracking,
 //reduzindo o valor até encontrar soluções completas.
