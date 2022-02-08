using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class Menu
    {
        readonly Conta conta;
        readonly string menuPrincipal = "Selecione o que deseja fazer: \n" +
                            "0.Sair \n" +
                            "1.Sacar \n" +
                            "2.Depositar \n" +
                            "3.Consultar seu saldo";
        public Menu(Conta conta)
        {
            this.conta = conta;
        }
        public void MenuInicial()
        {
            int menuItem = 4;
            while (menuItem != 0)
            {
                switch (menuItem)
                {
                    case 1 :
                        Console.Clear();
                        MenuSacar();
                        menuItem = 4;
                        break;
                    case 2:
                        Console.Clear();
                        MenuDepositar();
                        menuItem = 4;
                        break;
                    case 3:
                        Console.Clear();
                        MenuSaldo();
                        menuItem = 4;
                        break;
                    default:
                        Console.WriteLine(menuPrincipal);
                        String itemMenu = Console.ReadLine();
                        try
                        {
                            menuItem = Int32.Parse(itemMenu);
                        }
                        catch (FormatException e)
                        {
                            Console.WriteLine("Digite um número valido");
                        }
                        break;
                }



            }

        }

        private void MenuSaldo()
        {
            Console.WriteLine("Saldo disponível: R$" + conta.ConsultarSaldo());
        }

        private void MenuDepositar()
        {
            Console.WriteLine("Qual valor deseja depositar?");
            string valorString = Console.ReadLine();
            try
            {
                double valor = Int32.Parse(valorString);
                conta.Depositar(valor);
            }
            catch (FormatException)
            {
                Console.WriteLine("Digite um número valido");
            }
            Console.WriteLine("Valor depositado");
        }

        public void MenuSacar()
        {
            Console.WriteLine("Qual valor deseja sacar?");
            string valorString = Console.ReadLine();
            try
            {
                double valor = Int32.Parse(valorString);
                conta.Sacar(valor);
                Console.WriteLine("Valor sacado");
            }
            catch (FormatException)
            {
                Console.WriteLine("Digite um número valido");
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("Valor maior que o disponível para saque");
            }
        }
    }
}
