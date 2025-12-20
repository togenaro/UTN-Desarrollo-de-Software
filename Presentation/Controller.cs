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
        if (account is null) { throw new CuentaNoEncontrada(); }

        if (mount <= 0)
        {
            throw new MontoNoValido(); //MontoNoValido
        }

        if (account.Estado != Estado.Activa)
        {
            throw new CuentaNoActiva(account.Estado); //CuentaNoActiva
        }

        account.Depositar(mount);
    }

    public void RetirarDinero(string code, decimal mount)
    {
        var account = Accounts.Where(c => c.Numero == code).FirstOrDefault();
        if (account is null) { throw new CuentaNoEncontrada(); }

        if (mount <= 0)
        {
            throw new MontoNoValido(); //MontoNoValido
        }

        if (account.Estado != Estado.Activa)
        {
            throw new CuentaNoActiva(account.Estado); //CuentaNoActiva
        }

        if (account is CuentaCorriente cc)
        {
            if (cc.Saldo - mount <= -cc.LimiteDeDescubierto) { cc.Retirar(mount); }
            else { throw new SaldoInsuficiente(); /*SaldoInsuficiente*/ }
        }
        else { account.Retirar(mount); }

        if (account.Saldo < 0)
        {
            account.CambiarEstado(Estado.Suspendida);

            throw new SaldoInsuficiente(); //SaldoInsuficiente
        }
    }
    #endregion
}
