using System;

public interface IAcordar
{
    void Acordar();
}


public interface ITrabalhar
{
    void Trabalhar();
}

public interface IComer
{
    void Comer();

}

public interface IMalhar
{
    void Treinar();
}

public interface IDormir
{
    void Dormir();
}

public class Pessoa : IAcordar, ITrabalhar, IComer, IMalhar, IDormir
{
    string nome, profissao;
    int idade;
    public Pessoa(string nome, string profissao, int idade)
    {
        this.nome = nome;
        this.profissao = profissao;
        this.idade = idade;
    }
    
    public void Acordar()
    {
        Console.WriteLine("Abri os olhos e levantei.");
    }

    public void Comer()
    {
        Console.WriteLine("Comer salada, arroz, feijão e FRANGO");
    }

    public void Dormir()
    {
        Console.WriteLine("Deitei e fechei os olhos.");
    }

    public void Trabalhar()
    {
        Console.WriteLine("Cheguei no trabalho,li os emails, vi se tem irregularidade no RH e Resolvo os problemas acumulados.");
    }

    public void Treinar()
    {
        Console.WriteLine("Dia de Peito:");
        Console.WriteLine("Supino 3x10 \n Crcifixo 3x10 \n Voador 3x10");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Pessoa Igor= new Pessoa("Igor","Assistente de Informatica",27);
        Igor.Acordar();
        Igor.Trabalhar();
        Igor.Comer();
        Igor.Treinar();
        Igor.Dormir();

    }
}