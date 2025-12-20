namespace Dsw2025Ej9.Entidades;

public class ProductoElectronico : Mercancia
{
    public string Marca { get; }

    public ProductoElectronico(string nombre, string marca) : base(nombre)
    {
        Marca = marca;
    }
}
