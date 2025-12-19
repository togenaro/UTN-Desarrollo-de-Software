using Dsw2025Ej8.Domain.Entities;

namespace Dsw2025Ej8;

public class Program
{
    static void Main(string[] args)
    {
        var cajaAhorro = new CajaDeAhorro("P001", 100000.00m, ["Genaro"])
        {
            TasaDeInteres = 0.05m
        };

    }
}
