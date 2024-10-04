public class Veiculo
{
    protected string marca;
    protected string modelo;
    protected int ano;

    public Veiculo(string marca, string modelo, int ano)
    {
        this.marca = marca;
        this.modelo = modelo;
        this.ano =ano;
    }
    public void Ligar()
    {
        Console.WriteLine("o veiculo esta ligado");
    }
    public void Desligar()
    {
        Console.WriteLine("O VEIULO ESTA DESLIGADO");
    }
    
}