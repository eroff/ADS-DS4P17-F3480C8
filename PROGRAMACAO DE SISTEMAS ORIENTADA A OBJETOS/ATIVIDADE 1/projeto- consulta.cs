using System;
using System.Collections.Generic;

class Aluno
{
    public string RA { get; }
    public string Nome { get; }

    public Aluno(string ra, string nome)
    {
        RA = ra;
        Nome = nome;
    }

    public virtual string ObterInformacoes()
    {
        return $"RA: {RA}, Nome: {Nome}";
    }
}

class AlunoAroldo : Aluno
{
    public AlunoAroldo() : base("G54DFG9", "AROLDO JOSE DE OLIVEIRA") { }
}

class AlunoEron : Aluno
{
    public AlunoEron() : base("F3480C8", "ERON KAUE PINHEIRO MENDES") { }
}

class AlunoMatheus : Aluno
{
    public AlunoMatheus() : base("G51EFJ3", "MATHEUS CAMARGO DO NASCIMENTO") { }
}

class AlunoRenato : Aluno
{
    public AlunoRenato() : base("G497333", "RENATO LEME JUNIOR") { }
}

class AlunoStefanie : Aluno
{
    public AlunoStefanie() : base("N894440", "STEFANIE MARTINS FERNANDES PEREIRA") { }
}

class AlunoUelson : Aluno
{
    public AlunoUelson() : base("G4238C1", "UELSON WILLIAN DA SILVA") { }
}

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, Aluno> alunos = new Dictionary<string, Aluno>
        {
            { "G54DFG9", new AlunoAroldo() },
            { "F3480C8", new AlunoEron() },
            { "G51EFJ3", new AlunoMatheus() },
            { "G497333", new AlunoRenato() },
            { "N894440", new AlunoStefanie() },
            { "G4238C1", new AlunoUelson() }
        };

        Console.WriteLine("Digite o RA do aluno:");
        string ra = Console.ReadLine().ToUpper();

        if (alunos.ContainsKey(ra))
        {
            Aluno aluno = alunos[ra];
            Console.WriteLine(aluno.ObterInformacoes());
        }
        else
        {
            Console.WriteLine("Aluno nao encontrado.");
        }
    }
}