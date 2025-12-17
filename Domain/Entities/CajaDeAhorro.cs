using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsw2025Ej8.Domain.Entities;

public class CajaDeAhorro : CuentaBancaria
{
    private decimal _tasaDeInteres;

    public CajaDeAhorro(string numero, decimal saldo, string[] titulares, decimal tasaDeInteres) : base(numero, saldo, titulares)
    {
        _tasaDeInteres = tasaDeInteres;
    }

    #region Getters/Setters
    public decimal GetTasaDeInteres()
    {
        return _tasaDeInteres;
    }

    public void SetTasaDeInteres(decimal tasaDeInteres)
    {
        _tasaDeInteres = tasaDeInteres;
    }
    #endregion

    #region Métodos
    public override void Depositar(decimal monto)
    {
        _saldo += monto;
    }

    public override void Retirar(decimal monto)
    {
        _saldo -= monto;
    }

    public void AplicarInteres()
    {
        _saldo += _saldo * _tasaDeInteres;
    }
    #endregion
}
