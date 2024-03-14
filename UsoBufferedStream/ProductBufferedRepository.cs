using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsoBufferedStream
{
    public class ProductBufferedRepository : IProductRepository
    {
        private string _productsFile;

        public ProductBufferedRepository(string productsFile)
        {
            _productsFile = productsFile;
        }
        void IProductRepository.Add(Product product)
        {
            using(Stream fs = new FileStream(_productsFile,
                FileMode.Append))
                using(Stream bs = new BufferedStream(fs))
            using (StreamWriter sw = new StreamWriter(bs))
            {
                sw.WriteLine($"{product.Id},{product.Name},{product.Price}");
            }
        }

        List<Product> IProductRepository.GetAll()
        {
            List<Product> products = new List<Product>();
            using(Stream fs = new FileStream(_productsFile,
                FileMode.Open))
                using(Stream bs = new BufferedStream(fs))
            using (StreamReader reader = new StreamReader(bs))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    products.Add(new Product
                    {
                        Id = int.Parse(parts[0]),
                        Name = parts[1],
                        Price = decimal.Parse(parts[2]),
                    });
                }
            }
            return products;
        }
    }
}
