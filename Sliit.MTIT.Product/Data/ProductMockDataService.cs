namespace Sliit.MTIT.Product.Data
{
    public class ProductMockDataService
    {
        public static List<Models.Product> Products = new List<Models.Product>()
        {
            new Models.Product { Id = 1, Name = "Bag", Description = "A handmade hand bag from Sri Lanka", Price = 2000 },
            new Models.Product { Id = 2, Name = "Bottle", Description = "An aluminium premium quality water bottle", Price = 1000 },
            new Models.Product { Id = 3, Name = "Pen", Description = "Atlas chooty ball point pen", Price = 120 },
            new Models.Product { Id = 4, Name = "Ball", Description = "FIFA foot ball for kids", Price = 1200 },
            new Models.Product { Id = 5, Name = "Kettle", Description = "Electric kettle", Price = 1900 }
        };

    }
}
