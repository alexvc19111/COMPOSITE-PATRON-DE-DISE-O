public class program
{
    static void Main(string[]args)
    {
        ProductoSimple p1= new ProductoSimple("Memoria RAM 4GB",50,"Intel");
        ProductoSimple p2= new ProductoSimple("Cascos Gamer",20,"Asus");
        compuesto orden=new compuesto("Productos para pc");
        orden.AddProducto(p1);
        orden.AddProducto(p2);
        orden.ImprimirComposite();
        ProductoSimple p3=new ProductoSimple("Toallitas humedas",0.25,"HUGGIES");
        compuesto orden1=new compuesto("ORDEN 1");
        orden1.AddProducto(p3);
        orden1.AddProducto(orden);
        orden1.ImprimirComposite();
        compuesto orden2=new compuesto("ORDEN 2");
        ProductoSimple p4=new ProductoSimple("Balon de futbol",100,"Adidas");
        orden2.AddProducto(p4);
        orden2.AddProducto(orden1);
        orden2.ImprimirComposite();    
        }
}


