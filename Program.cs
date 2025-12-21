namespace Dsw2025Ej10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* a partir de la lista de productos que se obtiene de producto.crearlistadeejemplo()
             * resolver:
             * 1. el primer producto 
             * 2. el último producto
             * 3. la suma de precios
             * 4. el promedio de precios
             * 5. listar los productos con id mayor a 15
             * 6. obtener una lista de cada producto con su nombre y el precio en formato moneda, luego mostrar los elementos
             * 7. el producto con el precio más alto
             * 8. el producto con el precio más bajo
             * 9. obtener y mostrar los productos cuyo precio sea mayor al promedio
             * 10. listar los productos ordenados por descripción de forma descendente
             * cada punto se debe realizar en un método distinto, en una nueva clase llamada solucion

             */

            var solucion = new Solucion();

            Console.WriteLine(solucion.FirstProduct().Descripcion);

            Console.WriteLine(solucion.LastProduct().Descripcion);

            Console.WriteLine(solucion.SumOfPrices());

            Console.WriteLine(solucion.AveragePrice());

            var productsGT15 = solucion.ListProductsGT15();
            foreach (var product in productsGT15) Console.WriteLine(product.Id);

            var products = solucion.ListProducts();
            foreach (var product in products) Console.WriteLine(product);

            Console.WriteLine($"Producto con mayor precio: {solucion.GetProductWHP().Descripcion} - {solucion.GetProductWHP().Precio}");

            Console.WriteLine($"Producto con menor precio: {solucion.GetProductWLP().Descripcion} - {solucion.GetProductWLP().Precio}");

            var productsHTA = solucion.ListProductsHTA();
            foreach (var product in productsHTA) Console.WriteLine(product.Id);

            var productsOBD = solucion.ListProductOBD();
            foreach (var product in productsOBD) Console.WriteLine(product.Id);
        }
    }
}
