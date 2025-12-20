using System.Collections;

namespace Dsw2025Ej9.Bodegas;

public class Basica
{
    private readonly ArrayList _items = [];

    public void Agregar(object item)
    {
        _items.Add(item);
    }

    public object Obtener(int index)
    {
        if(_items.Count == 0 || index >= _items.Count)
            throw new Exception("No hay elementos en la bodega");
        return _items[index]!;
    }

    public ArrayList Listar()
    {
        return _items;
    }
}
