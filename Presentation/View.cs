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
                var anonymousClass = new
                {
                    numero = account.Numero,
                    tipo = account.GetType().Name,
                    saldo = account.Saldo,
                };

                Console.WriteLine($"{anonymousClass.numero} - {anonymousClass.tipo} - {anonymousClass.saldo:C2}");
            }
        }
        catch (Exception ex) { Console.WriteLine(ex.Message); }

    }
}
