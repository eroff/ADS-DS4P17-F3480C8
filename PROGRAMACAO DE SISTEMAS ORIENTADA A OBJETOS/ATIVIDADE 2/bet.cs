using System;
using System.Collections.Generic;

public class PRODUTO
{
    public string Nome { get; set; }
    public double Preco { get; set; }
    public int Prazo { get; set; }

    public PRODUTO(string nome, double preco, int prazo)
    {
        Nome = nome;
        Preco = preco;
        Prazo = prazo;
    }
}

public class CACHORRO
{
    public string Nome { get; set; }
    public string Raca { get; set; }
    public string Porte { get; set; }

    public CACHORRO(string nome, string raca, string porte)
    {
        Nome = nome;
        Raca = raca;
        Porte = porte;
    }
}

public class CLIENTE
{
    public string Nome { get; set; }
    public string Endereco { get; set; }
    public string Contato { get; set; }
    public List<CACHORRO> Cachorros { get; set; }

    public CLIENTE(string nome, string endereco, string contato)
    {
        Nome = nome;
        Endereco = endereco;
        Contato = contato;
        Cachorros = new List<CACHORRO>();
    }

    public void AdicionarCachorro(CACHORRO cachorro)
    {
        Cachorros.Add(cachorro);
    }
}

public class PETSHOP
{
    public string Nome { get; set; }
    public string Contato { get; set; }
    public List<PRODUTO> Produtos { get; set; }
    public List<CLIENTE> Clientes { get; set; }

    public PETSHOP(string nome, string contato)
    {
        Nome = nome;
        Contato = contato;
        Produtos = new List<PRODUTO>();
        Clientes = new List<CLIENTE>();
    }

    public void AdicionarProduto(PRODUTO produto)
    {
        Produtos.Add(produto);
    }

    public void AdicionarCliente(CLIENTE cliente)
    {
        Clientes.Add(cliente);
    }
}

class Program
{
    static void Main()
    {
        PETSHOP petshop = new PETSHOP("Meu Petshop");

        PRODUTO produto1 = new PRODUTO("Banho", 30m);
        PRODUTO produto2 = new PRODUTO("Tosa", 30m);
        PRODUTO produto3 = new PRODUTO("Banho e Tosa", 60m);")

        petshop.AdicionarProduto(produto1);
        petshop.AdicionarProduto(produto2);
        petshop.AdicionarProduto(produto3);

        CLIENTE cliente1 = new CLIENTE("João", "joao@email.com");
        CLIENTE cliente2 = new CLIENTE("Maria", "maria@email.com");

        CACHORRO cachorro1 = new CACHORRO("Thor", "Labrador", 5);
        CACHORRO cachorro2 = new CACHORRO("Filó", "Poodle", 3);

        cliente1.AdicionarCachorro(cachorro1);
        cliente2.AdicionarCachorro(cachorro2);

        petshop.AdicionarCliente(cliente1);
        petshop.AdicionarCliente(cliente2);

        Console.WriteLine("Informações do Petshop:");
        Console.WriteLine("Nome: " + petshop.Nome);
        Console.WriteLine("Contato: " + petshop.Contato);
        Console.WriteLine("\nProdutos Disponíveis:");
        foreach (var produto in petshop.Produtos)
        {
            Console.WriteLine($"Nome: {produto.Nome}, Preço: {produto.Preco:C}, Prazo: {produto.Prazo} minutos");
        }

        Console.WriteLine("\nClientes:");
        foreach (var cliente in petshop.Clientes)
        {
            Console.WriteLine($"Nome: {cliente.Nome}, Email: {cliente.Email}");
            Console.WriteLine("Cachorros:");
            foreach (var cachorro in cliente.Cachorros)
            {
                Console.WriteLine($"Nome: {cachorro.Nome}, Raça: {cachorro.Raca}, Porte: {cachorro.Porte}");
            }
            Console.WriteLine();
        }
    }
}
