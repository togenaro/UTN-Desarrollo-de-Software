using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsw2025Ej06.Domain;

internal class Producto
{
    private int _codigo;
    private string _descripcion;
    private bool _isActive;
    private double _precioVenta = 0.00f;
    private float _impuesto = 0.21f;
    private int _stock;
    private char _presentacion;
    private DateTime _fechaAlta;

    public double GetPrecioSinImpuesto()
    {
        return _precioVenta / (1 + _impuesto);
    }


}
