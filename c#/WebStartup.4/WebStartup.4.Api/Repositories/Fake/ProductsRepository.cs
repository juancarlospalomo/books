using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStartup._4.Api.Models;

namespace WebStartup._4.Api.Repositories.Fake
{
    public class ProductsRepository
    {

        private static List<Product> _productsEntity = new List<Product>()
        {
            new Product() {ID=1, Name="First Product"},
            new Product() {ID=2, Name="Second Product"}
        };

        public void Add(Product item)
        {
            _productsEntity.Add(item);
        }

        public Product Get(int id)
        {
            return _productsEntity.Where(p => p.ID == id).SingleOrDefault();
        }

        public List<Product> GetAll()
        {
            return _productsEntity;
        }

        public Task<List<Product>> GetAllAsync()
        {
            return Task.Run(() => GetAll());
        }

        public void Update(Product item)
        {
            var product = _productsEntity.Where(p => p.ID == item.ID).First();

            if (product != null)
            {
                product.Name = item.Name;
                product.ShortDescription = item.ShortDescription;
                product.Price = item.Price;
            }
        }

        public void Delete(int id)
        {
            var product = _productsEntity.Where(p => p.ID == id).FirstOrDefault();
            _productsEntity.Remove(product);
        }

    }
}
