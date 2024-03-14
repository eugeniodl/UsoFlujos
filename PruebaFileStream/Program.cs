using(Stream fs = new FileStream("clientes.txt",
    FileMode.Open, FileAccess.Read))
{
    // Obtenemos el número de bytes
    long cantidad = fs.Length;
    Console.WriteLine( $"El archivo tiene una " +
        $"longitud de {cantidad} bytes");
}
