namespace exercicios_logico;

public class AssentoService
{
    
    private List<Assento> assentos = new List<Assento>();

    public void CriarAssentos(int quantidade)
    {
        for (int i= 1; i<= quantidade; i++)
        {
            assentos.Add(new Assento
            {
                Id = i,
                Status = StatusAssento.Livre
            });
        }
    }
    public bool ReservarAssento (int id)
    {
        var assento = assentos.FirstOrDefault(a=> a.Id == id);

        if (assento == null)
        {
            return false;
        }

        if (assento.Status != StatusAssento.Livre){
          
            return false;
         }
        assento.Status = StatusAssento.Reservado;
     
        return true;
    }

    public IReadOnlyList <Assento>ListarAssentos()
    {
       
        return assentos.AsReadOnly();
    }
    
}
