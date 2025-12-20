namespace Dsw2025Ej9.Entidades;

public class Herramienta : Mercancia
{
    public bool IsElectrico { get; }

    public Herramienta(string nombre, bool isElectrico = false) : base(nombre)
    {
        IsElectrico = isElectrico;
    }
}
