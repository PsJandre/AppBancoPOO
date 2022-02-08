using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public abstract class Conta : IConta

    {
        public string NomeTitular { get; set; }
        public string Cpf { get; set; }
        public double Saldo { get; set; }
        public DateTime DataCriacao { get; set; }
        public double Rendimento { get; set; }


        

        public abstract double Sacar(double valor);

        public double Depositar(double valor)
        {
            Saldo += valor;
            return Saldo;
        }
       
        public double ConsultarSaldo()
        {
            return Saldo;
        }
    }
}
