using Dsw2025Ej8.Data;
using Dsw2025Ej8.Domain.Exceptions;
using Dsw2025Ej8.Domain.Entities;
using System.Data;

namespace Dsw2025Ej8.Presentation;

public class Controller
{
    #region Dependencias/Constructores
    List<CuentaBancaria> Accounts = new List<CuentaBancaria>();
    Persistence Persistencia = new Persistence();
    public List<CuentaBancaria> GetAccounts()
    {
        return Accounts;
    }

    public Controller()
    {
        Accounts = Persistencia.GetCuentas();
    }
    #endregion

    #region Métodos
    public void DepositarDinero(string code, decimal mount)
    {
        var account = Accounts.Where(c => c.Numero == code).FirstOrDefault();
        if (account is null) { throw new CuentaNoEncontrada("Cuenta no encontrada"); }

        if (mount <= 0)
        {
            throw new MontoNoValido("Monto no valido"); //MontoNoValido
        }

        if (account.Estado is Estado.Inactiva)
        {
            throw new CuentaNoActiva("Cuenta no activa"); //CuentaNoActiva
        }

        account.Depositar(mount);
    }

    public void RetirarDinero(string code, decimal mount)
    {
        var account = Accounts.Where(c => c.Numero == code).FirstOrDefault();
        if (account is null) { throw new Exception(); }

        if (mount <= 0)
        {
            throw new MontoNoValido("Monto no valido"); //MontoNoValido
        }

        if (account.Estado is Estado.Inactiva)
        {
            throw new CuentaNoActiva("Cuenta no activa"); //CuentaNoActiva
        }

        if (account is CuentaCorriente cc)
        {
            if (cc.Saldo - mount <= -cc.LimiteDeDescubierto) { cc.Retirar(mount); }
            else { throw new SaldoInsuficiente("Saldo insuficiente"); /*SaldoInsuficiente*/ }
        }
        else { account.Retirar(mount); }

        if (account.Saldo < 0)
        {
            account.CambiarEstado(Estado.Suspendida);

            throw new SaldoInsuficiente("Saldo insuficiente"); //SaldoInsuficiente
        }
    }
    #endregion
}
