using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using Microsoft.AspNetCore.Mvc;
using Sliit.MTIT.Product.Data;
using Sliit.MTIT.Product.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Sliit.MTIT.Product.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService ?? throw new ArgumentNullException(nameof(productService));
        }


        /// <summary>
        /// Get all students
        /// </summary>
        /// <returns>return the list of students</returns>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_productService.GetProducts());
        }

        /// <summary>
        /// Get student by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Return the student with the passed ID</returns>
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return _productService.GetProduct(id) != null ? Ok(_productService.GetProduct(id)) : NoContent();
        }

        /// <summary>
        /// Add students
        /// </summary>
        /// <param name="student"></param>
        /// <returns>Return the added student</returns>
        [HttpPost]
        public IActionResult Post([FromBody] Models.Product product)
        {
            return Ok(_productService.AddProduct(product));
        }

        /// <summary>
        /// Update the student
        /// </summary>
        /// <param name="student"></param>
        /// <returns>Return the updated student</returns>
        [HttpPut]
        public IActionResult Put([FromBody] Models.Product product)
        {
            return Ok(_productService.UpdateProduct(product));
        }

        /// <summary>
        /// Delete the student with the passed ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _productService.DeleteProduct(id);

            return result.HasValue & result == true ? Ok($"product with ID:{id} got deleted successfully.")
                : BadRequest($"Unable to delete the product with ID:{id}.");
        }
    }
}
