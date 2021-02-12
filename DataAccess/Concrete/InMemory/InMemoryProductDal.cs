using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product> { 
            new Product{ProductId=1,CategoryId=1,ProductName="Bardak",UnitPrice=15,UnitsInStock=15},
            new Product{ProductId=2,CategoryId=1,ProductName="Kamera",UnitPrice=150,UnitsInStock=20},
            new Product{ProductId=3,CategoryId=2,ProductName="Telefon",UnitPrice=3000,UnitsInStock=46},
            new Product{ProductId=4,CategoryId=2,ProductName="Klavye",UnitPrice=35,UnitsInStock=5},
            new Product{ProductId=5,CategoryId=3,ProductName="Fare",UnitPrice=35,UnitsInStock=1}
            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            Product productToDelete=null;
            productToDelete = _products.SingleOrDefault(p=>p.ProductId==product.ProductId);
            _products.Remove(productToDelete);
        }
         
        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
           return _products.Where(p => p.CategoryId == categoryId).ToList();
        }

        public Product getT(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            Product updateToProduct = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            updateToProduct.ProductName = product.ProductName;
            updateToProduct.CategoryId = product.CategoryId;
            updateToProduct.UnitsInStock = product.UnitsInStock;
            updateToProduct.UnitPrice = product.UnitPrice;
        }
    }
}