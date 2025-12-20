namespace Dsw2025Ej9.Entidades;

public abstract class Mercancia
{
    public string Nombre { get; set; }
    protected Mercancia(string nombre)
    {
        Nombre = nombre;
    }
}