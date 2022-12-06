using System;
using System.Collections.Generic;
//Clase hija de producto, la cual se interpreta como el elemento Composite que posee el patron de dessarrollo COMPOSITE, y posee los productos simples agreagados en mi clase program
public class compuesto:Producto
{
    private List<Producto>productos=new List<Producto>();
    public compuesto(string nombre):base(nombre,0)
    {}
    public override double getprecio()
    {
        double precio=0d;
        foreach(Producto x in productos)
        {
            precio +=x.getprecio();
        }
        return precio;
    }
    public override void setprecio(double precio)
    {
        throw new NotSupportedException();
    }
    public void AddProducto(Producto product)
    {
        this.productos.Add(product);
    }
    public Boolean RemoverProducto(Producto product)
    {
        return this.productos.Remove(product);
    }
    public void ImprimirComposite()
    {
        Console.WriteLine("=============================================");
        Console.WriteLine(nombre+":");
        Console.WriteLine("Productos:");
        foreach(Producto x in productos)
        {
            Console.WriteLine(x.nombre+" $"+x.precio);
        }
        Console.WriteLine("Precio total: $"+getprecio());
        Console.WriteLine("=============================================");
        precio=getprecio();


    }
}