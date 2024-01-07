using System;

class Jogador
{
    public string Nome { get; set; }
    public string Nacionalidade { get; set; }
    public int Idade { get; set; }
    public string Posicao { get; set; }

    public Jogador()
    {
    }
    public void NovoJogador(string nome, string nacionalidade, int idade, string posicao)
        {
            Jogador novoJogador = new Jogador();
            {
            Nome = nome;
            Nacionalidade = nacionalidade;
            Idade = idade;
            Posicao = posicao;
            };
        
            
        }
}

class Program
{
    static void Main()
    {
     string nome = Console.ReadLine();
        string nacionalidade = Console.ReadLine();
        int idade = int.Parse(Console.ReadLine());
        string posicao = Console.ReadLine();

        Jogador newPlayer = new Jogador();

        newPlayer.NovoJogador(nome, nacionalidade, idade, posicao);
        
        Console.WriteLine("Jogador criado!");
        Console.WriteLine(newPlayer.Nome);
        Console.WriteLine(newPlayer.Nacionalidade);
        Console.WriteLine(newPlayer.Idade);
        Console.WriteLine($"Posição: {newPlayer.Posicao}");
    }
}