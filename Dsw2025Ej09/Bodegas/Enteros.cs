using System.Collections;

namespace Dsw2025Ej9.Bodegas;

public class Enteros
{
    private readonly ArrayList _items = new ArrayList();

    public void Agregar(int item)
    {
        _items.Add(item);
    }

    public int Obtener(int index)
    {
        if (_items.Count == 0 || index >= _items.Count)
            throw new Exception("No hay elementos en la bodega");
        return (int)_items[index]!;
    }

    public ArrayList Listar() => _items;
}
