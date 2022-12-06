public class program
{
    static void Main(string[]args)
    {
        ProductoSimple p1= new ProductoSimple("Memoria RAM 4GB",50,"Intel");
        ProductoSimple p2= new ProductoSimple("Cascos Gamer",20,"Asus");
        //Se crean 2 objetos de la clase Producto simple
        compuesto orden=new compuesto("Productos para pc");
        //Se crea un objeto de la clase Producto compuesto
        orden.AddProducto(p1);
        orden.AddProducto(p2);
        //Se agregaron los 2 objetos de productos simples a el objeto producto compuesto
        orden.ImprimirComposite();
        //Se imprime la información del producto compuesto
        ProductoSimple p3=new ProductoSimple("Toallitas humedas",0.25,"HUGGIES");
        //Se crea 1 objeto de la clase Producto simple
        compuesto orden1=new compuesto("ORDEN 1");
        //Se crea 1 objeto de la clase Producto compuesto
        orden1.AddProducto(p3);
        orden1.AddProducto(orden);
        //Se agrega el nuevo objetos de la clase Producto simple a la clase Producto compuesto, y se agrega la anterior clase de producto compuesto a la nueva clase de producto compuesto
        orden1.ImprimirComposite();
        //Se imprime la información del producto compuesto
        compuesto orden2=new compuesto("ORDEN 2");
        //Se crea 1 objeto de la clase Producto compuesto
        ProductoSimple p4=new ProductoSimple("Balon de futbol",100,"Adidas");
        //Se crea 1 objeto de la clase Producto simple
        orden2.AddProducto(p4);
        orden2.AddProducto(orden1);
        //Se agrega el nuevo objetos de la clase Producto simple a la clase Producto compuesto, y se agrega la anterior clase de producto compuesto a la nueva clase de producto compuesto
        orden2.ImprimirComposite();
        //Se imprime la informacion de la clase producto compuesto que se encuentra jerarquicamente mas arriba    
        }
}


