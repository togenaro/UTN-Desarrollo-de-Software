using Dsw2025Ej8.Domain.Entities;

namespace Dsw2025Ej8.Domain.Exceptions;

public class CuentaNoActiva : Exception
{
    public Estado EstadoDeLaCuenta { get; }

    public CuentaNoActiva(Estado estado)
    {
        this.EstadoDeLaCuenta = estado;
    }
}
