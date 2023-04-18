using Sliit.MTIT.Product.Data;
using Sliit.MTIT.Product.Models;

namespace Sliit.MTIT.Product.Services
{
    public class ProductService:IProductService
    {
        public List<Models.Product> GetProducts()
        {
            return ProductMockDataService.Products;
        }

        public Models.Product? GetProduct(int id)
        {
            return ProductMockDataService.Products.FirstOrDefault(x => x.Id == id);
        }

        public Models.Product? AddProduct(Models.Product product)
        {
            ProductMockDataService.Products.Add(product);
            return product;
        }

        public Models.Product? UpdateProduct(Models.Product product)
        {
            Models.Product selectedProduct = ProductMockDataService.Products.FirstOrDefault(x => x.Id == product.Id);
            if (selectedProduct != null)
            {
                selectedProduct.Price = product.Price;
                selectedProduct.Description = product.Description;
                selectedProduct.Name = product.Name;
                return selectedProduct;
            }

            return selectedProduct;
        }

        public bool? DeleteProduct(int id)
        {
            Models.Product selectedProduct = ProductMockDataService.Products.FirstOrDefault(x => x.Id == id);
            if (selectedProduct != null)
            {
                ProductMockDataService.Products.Remove(selectedProduct);
                return true;
            }
            return false;
        }
    }
}
