namespace exercicios_logico;

public class Assento
{
    public int Id {get; set;}
    public StatusAssento Status {get; set;}
}

public enum StatusAssento
    {
        Livre,
        Reservado,
        Vendido
    }