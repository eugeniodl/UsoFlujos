using UsoBufferedStream;

string archivoProducto = "productos.txt";

IProductRepository productoRepository 
    = new ProductRepository(archivoProducto);

productoRepository.Add(new Product
{
    Id = 1,
    Name = "Product 1",
    Price = 10.5m
});
productoRepository.Add(new Product
{
    Id = 2,
    Name = "Product 2",
    Price = 20.75m
});

Console.WriteLine(  "Todos los productos");
foreach (var product in productoRepository.GetAll())
    Console.WriteLine($"Id: {product.Id}," +
        $"Nombre: {product.Name}," +
        $"Precio: {product.Price}");