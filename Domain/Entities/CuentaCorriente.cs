namespace Dsw2025Ej8.Domain.Entities;

public class CuentaCorriente : CuentaBancaria
{
    #region Propiedades
    public decimal LimiteDeDescubierto { get; init; }
    public decimal Comision { get; private set; }
    #endregion

    #region Constructor
    public CuentaCorriente(string numero, decimal saldo, string[] titulares, decimal comision) : base(numero, saldo, titulares)
    {
        Comision = comision;
    }
    #endregion

    #region Getters/Setters
    //public decimal GetLimiteDeDescubierto()
    //{
    //    return _limiteDeDescubierto;
    //}

    //public void SetLimiteDeDescubierto(decimal limiteDeDescubierto)
    //{
    //    _limiteDeDescubierto = limiteDeDescubierto;
    //}

    //public decimal GetComision()
    //{
    //    return _comision;
    //}

    //public void SetComision(decimal comision)
    //{
    //    _comision = comision;
    //}
    #endregion

    #region Métodos
    public override void Depositar(decimal monto)
    {
        monto -= monto * Comision;
        Saldo += monto;
    }

    public override void Retirar(decimal monto)
    {
        Saldo -= monto;

        if (Saldo < 0)
        {
            Estado = Estado.Suspendida;
        }
    }
    #endregion  

}
