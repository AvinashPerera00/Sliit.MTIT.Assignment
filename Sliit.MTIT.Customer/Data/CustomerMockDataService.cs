using System.Reflection;

namespace Sliit.MTIT.Customer.Data
{
    public class CustomerMockDataService
    {
        public static List<Models.Customer> Customers = new List<Models.Customer>()
        {
            new Models.Customer { Id = 1, Name = "Tim Curry", NIC = "1978345634567", Address = "23,Colombo." },
            new Models.Customer { Id = 2, Name = "John Smith", NIC = "2078345631324", Address = "42,Gampaha." },
            new Models.Customer { Id = 3, Name = "Ben Frank", NIC = "1878345635463", Address = "5,Kandy." },
            new Models.Customer { Id = 4, Name = "Will Fred", NIC = "201234563V", Address = "14,Colombo." },
            new Models.Customer { Id = 5, Name = "James Robert", NIC = "181232343V", Address = "65,Colombo." }
        };
    }
}
