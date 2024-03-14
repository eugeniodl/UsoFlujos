using(Stream ms = new MemoryStream())
{
    using(Stream fs = new FileStream("clientes.txt",
        FileMode.Open, FileAccess.Read))
        fs.CopyTo(ms);

    ms.Seek(0, SeekOrigin.Begin);

    using(StreamReader sr = new StreamReader(ms))
    {
        while(!sr.EndOfStream)
        {
            Console.WriteLine( sr.ReadLine());
        }

    }

    using (Stream fs = new FileStream("clientes.txt",
        FileMode.Append, FileAccess.Write))
    {
        using (StreamWriter sw = new StreamWriter(fs))
        {
            sw.WriteLine("200,Alicia,Espinoza,14523");
        }
    }
}