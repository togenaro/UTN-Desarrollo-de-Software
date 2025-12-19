using Dsw2025Ej8.Domain.Entities;

namespace Dsw2025Ej8.Data;

public class Persistence
{
    List<CuentaBancaria> Cuentas = new List<CuentaBancaria>();

    #region Simulación de fetching de las cuentas
    CuentaBancaria cajaAhorro1 = new CajaDeAhorro("CA-001", 1000000, ["Genaro", "Mariela"]);
    CuentaBancaria cajaAhorro2 = new CajaDeAhorro("CA-002", 500000, ["Olga", "Juan"]);

    CuentaBancaria cuentaCorriente1 = new CuentaCorriente("CC-001", 500000, ["Mario", "Pedro"], 0.05m);
    CuentaBancaria cuentaCorriente2 = new CuentaCorriente("CC-002", 5500000, ["Juana", "María"], 0.1m);
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
        Cuentas.Add(cuentaCorriente1);
    }

    public List<CuentaBancaria> GetCuentas()
    {
        return Cuentas;
    }

}
