namespace Dsw2025Ej8.Domain.Entities;

public class CajaDeAhorro : CuentaBancaria
{
    #region Propiedades
    public decimal TasaDeInteres { get; init; }
    #endregion

    #region Constructor
    public CajaDeAhorro(string numero, decimal saldo, string[] titulares) : base(numero, saldo, titulares)
    {
    }
    #endregion

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

        if (Saldo < 0)
        {
            Estado = Estado.Suspendida;
        }
    }

    public void AplicarInteres()
    {
        Saldo += Saldo * TasaDeInteres;
    }
    #endregion
}
