using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalho___Conta_com_Heranca.classes
{
    internal class Conta
    {
        public int NumConta { get; set; }

        public string Agencia { get; set; }

        public string Titular { get; set; }

        public double Saldo { get; set; }

        public Conta()
        {

        }

        public Conta(int NumConta, string Agencia, string Titular, double Saldo) 
        {
            this.NumConta = NumConta;
            this.Agencia = Agencia;
            this.Titular = Titular;
            this.Saldo = Saldo;

        }
        
        public virtual void Sacar(double valor)
        {
            if( valor > Saldo)
            {        
                Console.WriteLine("Saldo indisponível");
                
                
            }
            else
            {
                double SaldoFinal = Saldo - valor;
                Console.WriteLine($"{SaldoFinal} disponivel");
                Saldo = SaldoFinal;

            }

            
        }
        public void Deposito(double valor)
        {
            Saldo = valor + Saldo;
            Console.WriteLine($"{Saldo}");
        }




    }
}
