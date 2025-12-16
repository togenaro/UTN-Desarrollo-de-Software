using Dsw2025Ej5.Data;
using Dsw2025Ej5.Presentation;

namespace Dsw2025Ej5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persistencia.Inicializar();
            ConsoleView.DibujarMenu();
        }
    }
}
