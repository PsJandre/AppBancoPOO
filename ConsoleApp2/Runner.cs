using System;

namespace ConsoleApp2
{
    class Runner
    {
        
    
        static void Main(string[] args)
        {
            Conta contaPoupanca = new ContaPoupanca("Pedro Jandre", "262.480.750-00");
            //Conta contaCorrente = new ContaCorrente("Pedro Jandre", "262.480.750-00");
            Menu menu = new Menu(contaPoupanca);
            menu.MenuInicial();
        }

    }
}
