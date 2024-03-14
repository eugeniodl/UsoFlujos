using UsoBufferedStream;

string archivoProductos = "productos.txt";

// Crear una instancia del repositorio de productos
IProductRepository productoRepository =
    new ProductBufferedRepository(archivoProductos);

// Agregar algunos productos de ejemplo
productoRepository.Add(new Product 
{ Id = 1,
Name = "Producto 1",
 Price = 10.5m});
productoRepository.Add(new Product
{
    Id = 2,
    Name = "Producto 2",
    Price = 20.75m
});

// Mostrando todos los productos
Console.WriteLine( "Todos los productos");
foreach (var product in productoRepository.GetAll())
{
    Console.WriteLine($"Id: {product.Id}, Nombre: {product.Name}," +
        $"Price: {product.Price}");
}