namespace Dsw2025Ej8.Domain.Entities;

public abstract class CuentaBancaria
{
    public string Numero { get; init; }

    public decimal Saldo { get; protected set; }

    public Estado Estado { get;  protected set; }

    protected string[] _titulares;

    public CuentaBancaria(string numero, decimal saldo, string[] titulares)
    {
        Numero = numero;
        Saldo = saldo;
        Estado = Estado.Activa;
        _titulares = titulares;
    }

    #region Getters/Setters
    //public string GetNumero()
    //{
    //    return _numero;
    //}

    //public decimal GetSaldo()
    //{
    //    return _saldo;
    //}

    //public Estado GetEstado()
    //{
    //    return _estado;
    //}

    //public void SetEstado(Estado estado)
    //{
    //    _estado = estado;
    //}

    //public string[] GetTitulares()
    //{
    //    return _titulares;
    //}
    #endregion

    #region Métodos
    public abstract void Depositar(decimal monto);

    public abstract void Retirar(decimal monto);

    #endregion
}
