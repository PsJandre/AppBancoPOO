using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class ContaCorrente : Conta
    {
        public ContaCorrente(string nome, string cpf)
        {
            this.NomeTitular = nome;
            this.Cpf = cpf;
            this.DataCriacao = DateTime.Now;
            this.Rendimento = 0.012;
            Console.WriteLine("Nova conta criada:" +
                "\nNome do titular: " + NomeTitular +
                "\nCPF do titular: " + Cpf +
                "\nas " + DataCriacao);
        }

        public override double Sacar(double valor)
        {
            
                if (valor <= this.Saldo)
                {
                    Saldo -= valor;
            }
            else
            {
                throw new InvalidOperationException("Valor maior que o disponível para saque");
            }
            

            return Saldo;

        }

    }
}
