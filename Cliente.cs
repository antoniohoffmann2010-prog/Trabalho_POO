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
 
    public override string ToString()
    {
        return "Cliente: " + nome;
    }
}