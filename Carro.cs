public class Carro : Veiculo
{
    private int numDePortas;

    public Carro(string marca, string modelo, int ano, int numDePortas)
    :base(marca, modelo, ano)
    {
        this.numDePortas = numDePortas;
        
    }
    public void AbrirPortaMalas()
    {
        Console.WriteLine("o portamalas esta aberto");

    }   
    public void ExibirInformacoes()
    {
        Console.WriteLine($"marca: {marca}, modelo: {modelo}, ano: {ano} e numero de portas: {numDePortas}");
    } 
}