public class Barbeiro
{
    private string nome;
 
    public string Nome
    {
        get { return nome; }
        set { nome = value; }
    }
 
    public Barbeiro(string nome)
    {
        this.nome = nome;
    }

    public void CortarCabelo()
    {
        Console.WriteLine(nome + "está cortando o cabelo.");
    }
 
    public override string ToString()
    {
        return "Barbeiro: " + nome;
    }
}