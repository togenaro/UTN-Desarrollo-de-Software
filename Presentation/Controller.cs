using Dsw2025Ej8.Data;
using Dsw2025Ej8.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dsw2025Ej8.Domain.Entities;

namespace Dsw2025Ej8.Presentation;

public class Controller
{
    decimal monto;

    List<CuentaBancaria> Accounts = new List<CuentaBancaria>();
    Persistence Persistencia = new Persistence();

    public void ObtainAccounts()
    {
        Accounts = Persistencia.GetCuentas();
    }
    
    public void DepositarDinero(CuentaBancaria account)
    {
        if (monto <= 0) 
        {
            throw new Exception(); //MontoNoValido
        } 

        if(account.Estado is Estado.Inactiva)
        {
            throw new Exception(); //CuentaNoActiva
        }


        account.Depositar(monto);
    }

    public void RetirarDinero(CuentaBancaria account)
    {
        if (monto <= 0)
        {
            throw new Exception(); //MontoNoValido
        }

        if (account.Estado is Estado.Inactiva)
        {
            throw new Exception(); //CuentaNoActiva
        }

        if (account is CuentaCorriente cc)
        {
            if (cc.Saldo - monto <= -cc.LimiteDeDescubierto) { cc.Retirar(monto); }
            else { throw new Exception(); /*SaldoInsuficiente*/ }
        }
        else { account.Retirar(monto);}

        if (account.Saldo < 0)
        {
            account.CambiarEstado(Estado.Suspendida);

            throw new Exception(); //SaldoInsuficiente
        }

    }

}
