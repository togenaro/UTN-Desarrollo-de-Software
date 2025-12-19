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

            // Mostrar cuentas

            foreach (var account in Accounts)
            {
                Console.WriteLine($"{account.Numero} - {account.GetType().Name} - {account.Saldo:C2}");
            }
        }
        catch (Exception ex) { Console.WriteLine(ex.Message); }

    }
}
