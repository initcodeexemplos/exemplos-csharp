namespace Programa;

public class ViewPessoa {
    public static void Criar() {
        Console.WriteLine("-- Criando uma pessoa --");
        Console.WriteLine("Informe o nome da pessoa: ");
        string nome = Console.ReadLine() ?? "";
        Console.WriteLine("Informe a idade da pessoa: ");
        int idade = Convert.ToInt32(Console.ReadLine());
        ControllerPessoa.Criar(nome, idade);
    }
    public static void Alterar() {
        Console.WriteLine("-- Alterar uma pessoa --");
        Console.WriteLine("Informe o indice da pessoa para alterar: ");
        int indice = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Informe o nome da pessoa: ");
        string nome = Console.ReadLine() ?? "";
        Console.WriteLine("Informe a idade da pessoa: ");
        int idade = Convert.ToInt32(Console.ReadLine());
        ControllerPessoa.Alterar(indice, nome, idade);
    }
    public static void Deletar() {
        Console.WriteLine("-- Deletar uma pessoa --");
        Console.WriteLine("Informe o indice da pessoa para deletar: ");
        int indice = Convert.ToInt32(Console.ReadLine());
        ControllerPessoa.Deletar(indice);
    }
    public static void Listar() {
        Console.WriteLine("-- Listando as pessoas --");
        List<Pessoa> pessoas = ControllerPessoa.Listar();
        foreach (Pessoa pessoa in pessoas) {
            Console.WriteLine($"{pessoa.Nome} - {pessoa.Idade}");
        }
    }
}