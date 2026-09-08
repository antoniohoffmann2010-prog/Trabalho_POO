public class Cliente
{
    private string nome;
 
    public string Nome
    {
        get { return nome; }
        set { nome = value; }
    }
 
    public Cliente(string nome)
    {
        this.nome = nome;
    }

    public void MarcarHorario()
    {
        Console.WriteLine(nome + "marcou um horário");
    }
 
    public override string ToString()
    {
        return "Cliente: " + nome;
    }
}