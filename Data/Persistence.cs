using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Dsw2025Ej8.Domain.Entities;

namespace Dsw2025Ej8.Data;

public class Persistence
{
    List<CuentaBancaria> Cuentas = new List<CuentaBancaria>();

    CuentaBancaria cajaAhorro1 = new CajaDeAhorro("CA-001", 1000000, ["Genaro", "Mariela"]);
    CuentaBancaria cajaAhorro2 = new CajaDeAhorro("CA-002", 500000, ["Olga", "Juan"]);

    CuentaBancaria cuentaCorriente1 = new CajaDeAhorro("CC-001", 500000, ["Mario", "Pedro"]);

    public void Initialize()
    { 
        Cuentas.Add(cajaAhorro1);
        Cuentas.Add(cajaAhorro2);

        Cuentas.Add(cuentaCorriente1);
    }

    public List<CuentaBancaria> GetCuentas()
    {
        Initialize();

        return Cuentas;
    }

}
