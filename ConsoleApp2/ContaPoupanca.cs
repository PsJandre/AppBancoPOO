using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class ContaPoupanca : Conta
    {
        public double taxaSaque;
        public ContaPoupanca(string nome, string cpf)
        {
            this.NomeTitular = nome;
            this.Cpf = cpf;
            this.DataCriacao = DateTime.Now;
            this.Rendimento = 0.012;
            this.taxaSaque = 2.90;
            Console.WriteLine("Nova conta criada:" +
                "\nNome do titular: " + NomeTitular +
                "\nCPF do titular: " + Cpf +
                "\nas " + DataCriacao);
        }

        public override double Sacar(double valor)
        {
            Console.WriteLine("O saque da conta poupança possui uma taxa extra de R$ "+taxaSaque);

            if (valor+taxaSaque < this.Saldo)
            {
                Saldo -= (valor+taxaSaque);
            }
            else
            {
                throw new InvalidOperationException("Valor maior que o disponível para saque");
            }


            return Saldo;

        }

    }
}
