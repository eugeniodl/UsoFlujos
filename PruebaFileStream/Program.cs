using (Stream fs = new FileStream("clientes.txt",
    FileMode.Open, FileAccess.Read))
{
    // Obtenemos el número de bytes
    long cantidad = fs.Length;
    Console.WriteLine($"El archivo tiene una longitud de " +
        $"{cantidad} bytes");

    for ( long cont = 0; cont < cantidad; cont++)
    {
        // Establecemos la posición
        fs.Seek( cont, SeekOrigin.Begin );
        int valor = fs.ReadByte();
        Console.WriteLine( $"Posición {cont}:{(char)valor}");
    }

    Console.WriteLine("-----------------------------------");

    for (long cont = cantidad - 1; cont >= 0; cont--)
    {
        // Establecemos la posición
        fs.Seek(cont, SeekOrigin.Begin);
        int valor = fs.ReadByte();
        Console.WriteLine($"Posición {cont}:{(char)valor}");
    }

    Console.WriteLine("-----------------------------------");

    long numeracion = cantidad - 1;
    for (long cont = 1; cont <= cantidad; cont++)
    {
        // Establecemos la posición
        fs.Seek(-cont, SeekOrigin.End);
        int valor = fs.ReadByte();
        Console.WriteLine($"Posición {numeracion}:{(char)valor}");
        numeracion--;
    }

    fs.Seek(0, SeekOrigin.Begin);

    using (StreamReader sr = new StreamReader(fs))
    {
        while(!sr.EndOfStream)
        {
            Console.WriteLine(sr.ReadLine());
        }
/*
        string todo = sr.ReadToEnd();
        Console.WriteLine( todo);
*/
    }

    
}