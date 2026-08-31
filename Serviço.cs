public class Servico
{
    private string nome;

    public string Nome
    {
        get { return nome; }
        set { nome = value; }
    }

    public Servico(string nome)
    {
        this.nome = nome;
    }

    public override string ToString()
    {
        return "Serviço: " + nome;
    }
}
