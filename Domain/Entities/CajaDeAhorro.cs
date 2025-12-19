using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsw2025Ej8.Domain.Entities;

public class CajaDeAhorro : CuentaBancaria
{
    public decimal TasaDeInteres { get; init; }

    public CajaDeAhorro(string numero, decimal saldo, string[] titulares) : base(numero, saldo, titulares)
    {
    }

    #region Getters/Setters
    //public decimal GetTasaDeInteres()
    //{
    //    return _tasaDeInteres;
    //}

    //public void SetTasaDeInteres(decimal tasaDeInteres)
    //{
    //    _tasaDeInteres = tasaDeInteres;
    //}
    #endregion

    #region Métodos
    public override void Depositar(decimal monto)
    {
        Saldo += monto;
    }

    public override void Retirar(decimal monto)
    {
        Saldo -= monto;
    }

    public void AplicarInteres()
    {
        Saldo += Saldo * TasaDeInteres;
    }
    #endregion
}
