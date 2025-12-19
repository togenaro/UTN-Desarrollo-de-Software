using Dsw2025Ej8.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsw2025Ej8.Presentation;

public class View
{
    Controller Controller = new Controller();

    public void ShowConsole()
    {
        var Accounts = Controller.GetAccounts();

        try
        {
            // Operaciones

            Controller.DepositarDinero("CC-123123123124", 123.44m);
            Controller.RetirarDinero("CC-001", 123.44m);

            // Mostrar cuentas

            foreach (var account in Accounts)
            {
                Console.WriteLine($"{account.Numero} - {account.GetType().Name} - {account.Saldo:C2}");
            }
        }
        catch (Exception ex) { Console.WriteLine(ex.Message); }

    }
}
