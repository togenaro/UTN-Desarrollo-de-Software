using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsw2025Ej06.Domain;

public class Producto
{
    private int _codigo;
    private string _descripcion;
    private bool _isActive;
    private double _precioVenta = 0.00f;
    private float _impuesto = 0.21f;
    private int _stock;
    private char _presentacion;
    private DateTime _fechaAlta;

    #region Getters y Setters
    public int GetCodigo()
    {
        return _codigo;
    }

    public void SetCodigo(int value)
    {
        _codigo = value;
    }

    public string GetDescripcion()
    {
        return _descripcion;
    }

    public void SetDescription(string text)
    {
        _descripcion = text;
    }

    public bool GetIsActive()
    {
        return _isActive;
    }

    public void SetActive(bool value)
    {
        _isActive = value;
    }
    #endregion

    #region Métodos del enunciado
    public double GetPrecioSinImpuesto()
    {
        return _precioVenta / (1 + _impuesto);
    }

    public void GetProducto()
    {
        Console.WriteLine($"[{_codigo} {_descripcion} [{_presentacion}]: {_precioVenta:C2}");
    }

    public int IncrementarStock()
    {
        return _stock++;
    }

    public int DecrementarStock()
    {
        return _stock--;
    }

    public int AumentarStock(int value)
    {
        return _stock + value;
    }
    #endregion
}
