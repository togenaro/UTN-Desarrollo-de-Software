using Dsw2025Ej8.Domain.Entities;
using Dsw2025Ej8.Presentation;
using System.Runtime.CompilerServices;

namespace Dsw2025Ej8;

public class Program
{
    static void Main(string[] args)
    {
        var view = new View();

        view.ShowConsole();

        Console.ReadKey();

    }
}
