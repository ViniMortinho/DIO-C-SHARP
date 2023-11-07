//MinhaClasse é o nome da classe
public class MinhaClasse
{
    // Campo privado
    private string meuCampo;

    // MinhaPropriedade é uma propriedade pública que pode ser acessada de fora da classe.
    public string MinhaPropriedade { get; set; }

    // Construtor
    public MinhaClasse(string valor)
    {
        meuCampo = valor;
    }

    // Método público
    public void MeuMetodo()
    {
        Console.WriteLine("Olá, Mundo!");
    }
}
