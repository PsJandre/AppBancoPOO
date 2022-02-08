using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    interface IConta
    {
        double Sacar(double valor);
        double Depositar(double valor);
        double ConsultarSaldo();
    }
}
