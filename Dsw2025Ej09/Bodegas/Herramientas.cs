using Dsw2025Ej9.Entidades;
using System.Collections;

namespace Dsw2025Ej9.Bodegas;

public class Herramientas
{
    private readonly ArrayList _items = new ArrayList();

    public void Agregar(Herramienta item)
    {
        _items.Add(item);
    }

    public Herramienta Obtener(int index)
    {
        if (_items.Count == 0 || index >= _items.Count)
            throw new Exception("No hay elementos en la bodega");
        return (Herramienta)_items[index]!;
    }

    public ArrayList Listar() => _items;
}
