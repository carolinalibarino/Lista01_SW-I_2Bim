using System;

public class Carro
{
    private string modelo;
    private int ano;
    private int velocidade;

    public string Modelo
    {
        get => modelo;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("O modelo do carro não pode ser vazio.");
            }
            modelo = value;
        }
    }

    public int Ano
    {
        get => ano;
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("O ano do carro deve ser um valor positivo.");
            }
            ano = value;
        }
    }

    public int Velocidade
    {
        get => velocidade;
        private set
        {
            if (value < 0)
            {
                velocidade = 0;
            }
            else
            {
                velocidade = value;
            }
        }
    }

    public Carro(string modelo, int ano)
    {
        Modelo = modelo;
        Ano = ano;
        Velocidade = 0;
    }

    public void Acelerar()
    {
        Velocidade += 10;
        Console.WriteLine($"O carro {Modelo} acelerou. Velocidade atual: {Velocidade} km/h.");
    }

    public void Frear()
    {
        Velocidade -= 10;
        if (Velocidade < 0) Velocidade = 0;
        Console.WriteLine($"O carro {Modelo} freou. Velocidade atual: {Velocidade} km/h.");
    }
}
