using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsoBufferedStream
{
    public interface IProductRepository
    {
        void Add(Product product);
        List<Product> GetAll();
    }
}
