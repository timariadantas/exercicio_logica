namespace exercicios_logico;

public class Atm
{
    private static readonly int [] notas = [200, 100, 50, 20];

    public static void Sacar (int valor)
    {
        Console.WriteLine($"Saque de : {valor} \n");


        Dictionary<int, int> resultado = new ();

        foreach (var nota in notas)
        {
            int quantidade = valor / nota;

            if (quantidade > 0)
            {
                resultado[nota] = quantidade;
                valor -= quantidade * nota;
            }
        }
        if (valor != 0)
        {
            Console.WriteLine("Erro: não é possivel sacar com as notas disponíveis.");
        }

        Console.WriteLine("Notas utilizadas: ");
        foreach (var item in resultado)
        {
            Console.WriteLine($"{item.Value} , {item.Key} \n");
        }

    }
}
