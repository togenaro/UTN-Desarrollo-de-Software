namespace Dsw2025Ej8.Domain.Exceptions;

public class SaldoInsuficiente : Exception
{
    public SaldoInsuficiente(string message)
        : base(message) { }
}
