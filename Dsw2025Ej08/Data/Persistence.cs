using Dsw2025Ej8.Domain.Entities;

namespace Dsw2025Ej8.Data;

public class Persistence
{
    List<CuentaBancaria> Cuentas = new List<CuentaBancaria>();

    #region Simulación de fetching de las cuentas
    CuentaBancaria cajaAhorro1 = new CajaDeAhorro("CA-001", 0, ["Genaro", "Mariela"])
    {
        TasaDeInteres = 0.2m
    };

    CuentaBancaria cajaAhorro2 = new CajaDeAhorro("CA-002", 0, ["Olga", "Juan"])
    {
        TasaDeInteres = 0.1m
    };

    CuentaBancaria cuentaCorriente1 = new CuentaCorriente("CC-001", 0, ["Mario", "Pedro"], 0.05m)
    {
        LimiteDeDescubierto = 50000
    };

    CuentaBancaria cuentaCorriente2 = new CuentaCorriente("CC-002", 0, ["Juana", "María"], 0.1m)
    {
        LimiteDeDescubierto = 100000,
    };
    #endregion

    public Persistence()
    {
        Initialize();
    }

    public void Initialize()
    { 
        Cuentas.Add(cajaAhorro1);
        Cuentas.Add(cajaAhorro2);

        Cuentas.Add(cuentaCorriente1);
        Cuentas.Add(cuentaCorriente2);
    }

    public List<CuentaBancaria> GetCuentas()
    {
        return Cuentas;
    }

}
