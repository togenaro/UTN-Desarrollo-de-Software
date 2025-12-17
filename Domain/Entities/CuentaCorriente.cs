using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsw2025Ej8.Domain.Entities;

public class CuentaCorriente : CuentaBancaria
{

    private decimal _limiteDeDescubierto;
    private decimal _comision;

    public CuentaCorriente(string numero, decimal saldo, string[] titulares, decimal limiteDeDescubierto, decimal tasaDeInteres, decimal comision) : base(numero, saldo, titulares)
    {
        _limiteDeDescubierto = limiteDeDescubierto;
        _comision = comision;
    }

    #region Getters/Setters
    public decimal GetLimiteDeDescubierto()
    {
        return _limiteDeDescubierto;
    }

    public void SetLimiteDeDescubierto(decimal limiteDeDescubierto)
    {
        _limiteDeDescubierto = limiteDeDescubierto;
    }

    public decimal GetComision()
    {
        return _comision;
    }

    public void SetComision(decimal comision)
    {
        _comision = comision;
    }
    #endregion

    #region Métodos
    public override void Depositar(decimal monto)
    {
        monto -= monto * _comision;
        _saldo += monto;
    }

    public override void Retirar(decimal monto)
    {
        if (_saldo - monto >= -_limiteDeDescubierto)
        {
            _saldo -= monto;
        }
        if (_saldo < 0)
        {
            _estado = Estado.Suspendida;
        }
    }
    #endregion  

}
