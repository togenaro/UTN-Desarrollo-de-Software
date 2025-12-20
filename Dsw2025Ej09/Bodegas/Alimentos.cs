using Dsw2025Ej9.Entidades;
using System.Collections;

namespace Dsw2025Ej9.Bodegas;

public class Alimentos
{
    private readonly ArrayList _items = [];

    public void Agregar(Alimento item)
    {
        _items.Add(item);
    }

    public Alimento Obtener(int index)
    {
        if (_items.Count == 0 || index >= _items.Count)
            throw new Exception("No hay elementos en la bodega");
        return (Alimento)_items[index]!;
    }

    public ArrayList Listar() => _items;
}
