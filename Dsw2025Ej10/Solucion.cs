using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Dsw2025Ej10;

public class Solucion
{
    List<Producto> productos = Producto.CrearListaDeEjemplo();

    #region 1. El primer producto
    public Producto FirstProduct()
    {
        return productos.First();
    }
    #endregion

    #region 2. El último producto
    public Producto LastProduct()
    {
        return productos.Last();
    }
    #endregion

    #region 3. La suma de precios
    public decimal SumOfPrices()
    {
        return productos.Select(p => p.Precio).Sum();
    }
    #endregion

    #region 4. El promedio de precios
    public decimal AveragePrice()
    {
        return productos.Select(p => p.Precio).Average();
    }
    #endregion

    #region 5. Listar los productos con id mayor a 15
    public List<Producto> ListProductsGT15()
    {
        return productos.Where(p => p.Id > 15).ToList();
    }
    #endregion

    #region 6. Obtener una lista de cada producto con su nombre y el precio en formato moneda, luego mostrar los elementos
    public List<string> ListProducts()
    {
        return productos.Select(p => $"{p.Descripcion} {p.Precio:C}").ToList();
    }
    #endregion

    #region 7. El producto con el precio más alto
    public Producto GetProductWHP()
    {
        return productos.MaxBy(p => p.Precio);
    }
    #endregion

    #region 8. El producto con el precio más bajo
    public Producto GetProductWLP()
    {
        return productos.MinBy(p => p.Precio);
    }
    #endregion

    #region 9. Obtener y mostrar los productos cuyo precio sea mayor al promedio
    public List<Producto> ListProductsHTA()
    {
        var avg = AveragePrice();
        return productos.Where(p => p.Precio > avg).ToList();
    }
    #endregion

    #region 10. Listar los productos ordenados por descripción de forma descendente
    public List<Producto> ListProductOBD()
    {
        return productos.OrderByDescending(p => p.Descripcion).ToList();
    }
    #endregion
}
