namespace Sliit.MTIT.Product.Services
{
    public interface IProductService
    {
        List<Models.Product> GetProducts();
        Models.Product? GetProduct(int id);
        Models.Product? AddProduct(Models.Product product);
        Models.Product? UpdateProduct(Models.Product product);
        bool? DeleteProduct(int id);

    }
}
