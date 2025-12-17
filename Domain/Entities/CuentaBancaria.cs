namespace Dsw2025Ej8.Domain.Entities;

public abstract class CuentaBancaria
{
    protected string _numero;
    protected decimal _saldo;
    protected Estado _estado;
    protected string[] _titulares;

    public CuentaBancaria(string numero, decimal saldo, string[] titulares)
    {
        _numero = numero;
        _saldo = saldo;
        _estado = Estado.Activa;
        _titulares = titulares;
    }

    #region Getters/Setters
    public string GetNumero()
    {
        return _numero;
    }

    public decimal GetSaldo()
    {
        return _saldo;
    }

    public Estado GetEstado()
    {
        return _estado;
    }

    public void SetEstado(Estado estado)
    {
        _estado = estado;
    }

    public string[] GetTitulares()
    {
        return _titulares;
    }
    #endregion

    #region Métodos
    public abstract void Depositar(decimal monto);

    public abstract void Retirar(decimal monto);

    #endregion
}
