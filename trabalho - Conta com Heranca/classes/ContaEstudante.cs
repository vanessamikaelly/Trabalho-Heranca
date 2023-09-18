using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalho___Conta_com_Heranca.classes
{
    internal class ContaEstudante:Conta
    {
        public double LimiteChequeEspecial { get; set; }

        public string Cpf { get; set; }

        public string NomeInstituicao  { get; set; }


        public ContaEstudante(double limiteChequeEspecial, string cpf, string nomeInstituicao, 
            int numConta, string agencia, string titular, double saldo) 
           :base(numConta,agencia, titular, saldo)
        {
            LimiteChequeEspecial = limiteChequeEspecial;
            Cpf = cpf;
            NomeInstituicao = nomeInstituicao;
            NumConta = numConta;
            Agencia = agencia;
            Titular = titular;
            Saldo = saldo;


        }

        public override void Sacar(double valor)
        {

            double saldo = Saldo + LimiteChequeEspecial;

            if(valor > Saldo)
            {
                Console.WriteLine("Não há saldo disponivel");
            }
            else
            {
                Saldo = Saldo - saldo;
                Console.WriteLine($"{Saldo}");
            }
             
        }

       




    }
}
