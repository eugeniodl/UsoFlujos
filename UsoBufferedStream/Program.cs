using UsoBufferedStream;

string archivoProductos = "productos.txt";


IProductRepository productoRepository =
    new ProductBufferedRepository(archivoProductos);

productoRepository.Add(new Product
{
    Id = 3,
    Name = "Atún",
    Price = 50m,
});

productoRepository.Add(new Product
{
    Id = 4,
    Name = "Arroz",
    Price = 22m,
});

// Mostrar todos los productos
Console.WriteLine( "Todos los productos");
foreach (var product in productoRepository.GetAll())
    Console.WriteLine(  $"Id: {product.Id}, Nombre: {product.Name}, " +
        $"Precio: {product.Price}");

