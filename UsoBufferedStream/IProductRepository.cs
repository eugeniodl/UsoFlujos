using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsoBufferedStream
{
    // Interfaz para el repositorio de productos
    public interface IProductRepository
    {
        void Add(Product product);
        List<Product> GetAll();
    }
}
