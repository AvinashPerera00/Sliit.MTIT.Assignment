using Sliit.MTIT.Customer.Data;
using Sliit.MTIT.Customer.Models;
using System.Reflection;

namespace Sliit.MTIT.Customer.Services
{
    public class CustomerService : ICustomerService
    {
        public List<Models.Customer> GetCustomers()
        {
            return CustomerMockDataService.Customers;
        }

        public Models.Customer? GetCustomer(int id)
        {
            return CustomerMockDataService.Customers.FirstOrDefault(x => x.Id == id);
        }

        public Models.Customer? AddCustomer(Models.Customer customer)
        {
            CustomerMockDataService.Customers.Add(customer);
            return customer;
        }

        public Models.Customer? UpdateCustomer(Models.Customer customer)
        {
            Models.Customer selectedCustomer = CustomerMockDataService.Customers.FirstOrDefault(x => x.Id == customer.Id);
            if (selectedCustomer != null)
            {
                selectedCustomer.Name = customer.Name;
                selectedCustomer.NIC = customer.NIC;
                selectedCustomer.Address = customer.Address;
                return selectedCustomer;
            }

            return selectedCustomer;
        }

        public bool? DeleteCustomer(int id)
        {
            Models.Customer selectedCustomer = CustomerMockDataService.Customers.FirstOrDefault(x => x.Id == id);
            if (selectedCustomer != null)
            {
                CustomerMockDataService.Customers.Remove(selectedCustomer);
                return true;
            }
            return false;
        }
    }
}