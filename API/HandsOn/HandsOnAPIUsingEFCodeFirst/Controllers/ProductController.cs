using HandsOnAPIUsingEFCodeFirst.Entities;
using HandsOnAPIUsingEFCodeFirst.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HandsOnAPIUsingEFCodeFirst.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        // Specify that this is a GET method
        [HttpGet("{id}")]  // Define route with id parameter
        public IActionResult Get(int id) // Get a Product By Id
        {
            var product = _productRepository.GetProduct(id);
            return Ok(product);
        }

        [HttpPost, Route("AddProduct")]
        public IActionResult Add([FromBody] Product product) // Add product details
        {
            _productRepository.Add(product);
            return StatusCode(200, product);
        }

        [HttpPut, Route("EditProduct")]
        public IActionResult Edit([FromBody] Product product) // Edit product details
        {
            _productRepository.Update(product);
            return StatusCode(200, product);
        }

        [HttpDelete, Route("DeleteProduct")]
        public IActionResult Delete([FromQuery] int id) // Delete Product using id
        {
            _productRepository.Delete(id);
            return Ok(); // Empty Response
        }
    }
}
