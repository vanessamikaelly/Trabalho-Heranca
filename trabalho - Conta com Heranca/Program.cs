using trabalho___Conta_com_Heranca.classes;
using System;

public class Program
{
    static void Main(string[] args)
    {
        Conta c = new Conta();

        c.NumConta = 1230;
        c.Agencia = "504072";
        c.Titular = "Vanessa Mikaelly";
        c.Saldo = 10000000000;

        Console.WriteLine("Digite um valor para sacar");
        double saque = Convert.ToDouble(Console.ReadLine());
        c.Sacar(saque);

        Console.WriteLine("Digite um valor para depositar");
        double deposito = Convert.ToDouble(Console.ReadLine());
        c.Deposito(deposito);


       //nao entendi como deveria executar o programa por isso coloquei apenas o metodo sacar e depositar
    

        

       


    }

}

