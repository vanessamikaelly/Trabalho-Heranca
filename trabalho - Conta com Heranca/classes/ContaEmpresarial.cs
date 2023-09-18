using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalho___Conta_com_Heranca.classes
{
    internal class ContaEmpresarial:Conta
    {

        public double Anuidade { get; set; }

        public double LimiteEmprestimo { get; set; }

        public double TotalEmprestimo { get; set; }

       
       public ContaEmpresarial(double anuidade, double limiteEmprestimo, double totalEmprestimo, int numConta, string agencia, string titular, double saldo)
            :base(numConta, agencia, titular, saldo)
        {
            Anuidade = anuidade;
            LimiteEmprestimo = limiteEmprestimo;
            TotalEmprestimo = totalEmprestimo;
            NumConta = numConta;
            Agencia = agencia;
            Titular = titular;
            Saldo = saldo;
        }

        public override void Sacar(double valor)
        {
            if(valor > Saldo)
            {
                Console.WriteLine("Saldo idisponivel");
            }
            else
            {
                double SaldoFinal = valor - Saldo;
                Console.WriteLine($"{SaldoFinal}");

                Saldo = SaldoFinal;

                if(valor > 5000)
                {
                    double taxa = 5.00;
                    valor = valor + taxa;
                    Saldo = Saldo - valor;
                    Console.WriteLine($"{Saldo}");

                }
            }

        }

        public void Emprestivo(double valor)
        {
            if(valor > LimiteEmprestimo)
            {
                Console.WriteLine("Não é possivél realizar o emprestimo");
            }
            else
            {
                valor = LimiteEmprestimo - valor;
                
                Console.WriteLine($"{valor}");
            }
            

        }


    }
}
