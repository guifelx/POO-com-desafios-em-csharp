using System;

class Pessoa
{
  
    private string nome; 
    private int idade;

    public Pessoa() {
    
    }
    public Pessoa(string n, int i)
    {
        nome = n;
        idade = i;
    }

    public string GetNome()
    {
        string nome = Console.ReadLine();
        return nome;
    }

    public int GetIdade()
    {   
        int idade = Convert.ToInt32(Console.ReadLine());
        return idade;
    }
}

class Program
{
    static void Main()
    {
       
    Pessoa p1 = new Pessoa("João", 29);
    
    string nome = p1.GetNome();
    int idade = p1.GetIdade();
    
    Console.WriteLine($"Nome: {nome}, Idade: {idade}");
    }
}