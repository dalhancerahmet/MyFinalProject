using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public IResult Add(Product product)
        {
            if (product.ProductName.Length < 2)
            {
                return ErrorResult("Ürün adı uzunluğu 2 karekterden daha fazla olmalıdır.");
            }
            _productDal.Add(product);
            return new SuccessResult(Messages.ProductAdded);
        }

        public IDataResult<List<Product>> GetAll()
        {
            //iş kodları
            //yetkisi var mı
            //similasyondan geçerse ürünleri dönderiyor.
            if (DateTime.Now.Hour==22)
            {
                return new ErrorDataResult();
            }
            return new DataResult<List<Product>>( _productDal.GetAll(),true,"ürünler listelendi.");
            
        }

        public Product GetById(int productId)
        {
            return _productDal.getT(p => p.ProductId == productId);
        }

        public List<Product> GetByProductId(int id)
        {
            return _productDal.GetAll(p => p.ProductId == id);
        }
        public List<Product> GetByUnitPrice(decimal min, decimal max)
        {
            return _productDal.GetAll(p => p.UnitPrice >= min && p.UnitPrice <= max);
        }
        public List<ProductDetailDto> getProductDetailsDto()
        {
            return _productDal.GetProductDetails();
        }
    }
}
