namespace Dsw2025Ej8.Domain.Exceptions;

public class CuentaNoActiva : Exception
{
    public CuentaNoActiva(string message)
        : base(message) { }
}
