using Dsw2025Ej8.Domain.Entities;
using Dsw2025Ej8.Domain.Exceptions;

namespace Dsw2025Ej8.Presentation;

public class View
{
    Controller Controller = new Controller();

    public void ShowConsole()
    {
        #region Depositos
        RealizarOperacion(() => Controller.DepositarDinero("CA-001", 10000000));
        RealizarOperacion(() => Controller.DepositarDinero("CA-002", 10000000));
        RealizarOperacion(() => Controller.DepositarDinero("CC-001", 10000000));
        RealizarOperacion(() => Controller.DepositarDinero("CC-002", 10000000));

        RealizarOperacion(() => Controller.DepositarDinero("CC-001", -1));
        #endregion

        #region Retiros
        RealizarOperacion(() => Controller.RetirarDinero("CA-001", 123.4m));
        RealizarOperacion(() => Controller.RetirarDinero("CA-002", 123.4m));
        RealizarOperacion(() => Controller.RetirarDinero("CA-001", 10004999));
        RealizarOperacion(() => Controller.RetirarDinero("CA-002", 10004999.4m));

        RealizarOperacion(() => Controller.RetirarDinero("CC-001", 123.4m));
        RealizarOperacion(() => Controller.RetirarDinero("CC-002", 123.4m));
        RealizarOperacion(() => Controller.RetirarDinero("CC-001", 10000000.4m));
        RealizarOperacion(() => Controller.RetirarDinero("CC-002", 10000000.4m));
        #endregion

        MostrarCuentas(Controller.GetAccounts());
    }

    private void MostrarCuentas(List<CuentaBancaria> accounts)
    {
        foreach (var account in accounts)
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

    private void RealizarOperacion(Action operacion)
    {
        var Accounts = Controller.GetAccounts();

        try
        {
            operacion();
        }
        catch (CuentaNoEncontrada)
        {
            Console.WriteLine("Error: La cuenta indicada no existe.");
        }
        catch (MontoNoValido)
        {
            Console.WriteLine("El monto ingresado no es válido para la operación solicitada.");
        }
        catch (CuentaNoActiva ex)
        {
            Console.WriteLine($"No se puede operar con la cuenta: {ex.EstadoDeLaCuenta}");
        }
        catch (SaldoInsuficiente)
        {
            Console.WriteLine("La cuenta no cuenta con saldo para la operación solicitada. Fue suspendida.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error inesperado: {ex.Message}");
        }
    }
}
