namespace Programa;

public class Pessoa {
    public string Nome { get; set; }
    public int Idade { get; set; }

    public Pessoa(string nome, int idade) {
        Nome = nome;
        Idade = idade;

        RepoPessoa.pessoas.Add(this);
    }

    public static List<Pessoa> Listar() {
        return RepoPessoa.pessoas;
    }

    public static void Alterar(int indice, string nome, int idade) {
        RepoPessoa.pessoas[indice].Nome = nome;
        RepoPessoa.pessoas[indice].Idade = idade;
    }

    public static void Deletar(int indice) {
        RepoPessoa.pessoas.RemoveAt(indice);
    }
}