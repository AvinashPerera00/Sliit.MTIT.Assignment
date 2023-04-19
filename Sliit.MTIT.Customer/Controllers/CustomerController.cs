using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using Microsoft.AspNetCore.Mvc;
using Sliit.MTIT.Customer.Data;
using Sliit.MTIT.Customer.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Sliit.MTIT.Customer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService ?? throw new ArgumentNullException(nameof(customerService));
        }


        /// <summary>
        /// Get all Customers
        /// </summary>
        /// <returns>return the list of Customers</returns>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_customerService.GetCustomers());
        }

        /// <summary>
        /// Get Customer by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Return the Customer with the passed ID</returns>
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return _customerService.GetCustomer(id) != null ? Ok(_customerService.GetCustomer(id)) : NoContent();
        }

        /// <summary>
        /// Add Customers
        /// </summary>
        /// <param name="customer"></param>
        /// <returns>Return the added Customer</returns>
        [HttpPost]
        public IActionResult Post([FromBody] Models.Customer customer)
        {
            return Ok(_customerService.AddCustomer(customer));
        }

        /// <summary>
        /// Update the Customer
        /// </summary>
        /// <param name="Customer"></param>
        /// <returns>Return the updated Customer</returns>
        [HttpPut]
        public IActionResult Put([FromBody] Models.Customer customer)
        {
            return Ok(_customerService.UpdateCustomer(customer));
        }

        /// <summary>
        /// Delete the Customer with the passed ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _customerService.DeleteCustomer(id);

            return result.HasValue & result == true ? Ok($"customer with ID:{id} got deleted successfully.")
                : BadRequest($"Unable to delete the customer with ID:{id}.");
        }
    }
}
