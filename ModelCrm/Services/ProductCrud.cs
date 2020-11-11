using ModelCrm.CrmDbContext;
using ModelCrm.Models;
using ModelCrm.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace ModelCrm.Services
{
    public class ProductCrud : IProductCrud
    {
        private CrmAppDbContext dbContext = new CrmAppDbContext();
        public Product CreateProduct(ProductOptions productOptions)
        {
            Product product = new Product {  Code= productOptions.Code, 
                Description=productOptions.Description,
             Name=productOptions.Name,
             Price= productOptions.Price,
             Quantity=productOptions.Quantity};
            dbContext.Products.Add(product);
            dbContext.SaveChanges();

            return product;
        }

        public bool DeleteProduct(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllProduct()
        {
            throw new NotImplementedException();
        }

        public Product GetProductById(int id)
        {
            throw new NotImplementedException();
        }

        public Product UpdateProduct(ProductOptions productOption, int id)
        {
            throw new NotImplementedException();
        }
    }
}
