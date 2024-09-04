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

        //public ProductController()
        //{
        //    _productRepository = new ProductRepository();
        //}
        //Get Endpoints
<<<<<<< HEAD

 
       // [Authorize(Roles ="Admin")]

/*        [Authorize(Roles ="Admin")]

        [Authorize(Roles ="Admin")]
=======
        [HttpGet,Route("GetProducts")]
        //[Authorize(Roles ="Admin")]
>>>>>>> 297c85361d2321bc18a63d485f60429f6bc5bad3
        public IActionResult GetAll() //Get All Product details
 904a1fe236f9c31d0d79a507a651ffe839aae96c
        {
            var products = _productRepository.GetAll();
            return StatusCode(200, products);
        }
        [HttpGet, Route("GetProduct/{id}")]
       // [Authorize(Roles ="Admin,User")]
/*        [Authorize(Roles ="Admin,User")]
*/        public IActionResult Get([FromRoute]int id) //Get a Product By Id
        {
            var product=_productRepository.GetProduct(id);
            return Ok(product);
            //if (product != null)
            //    return StatusCode(200, product);
            //else
            //    return StatusCode(404, "Invalid Id");
        }
        //Post Endpoint
        [HttpPost, Route("AddProduct")]
       // [Authorize(Roles ="Admin")]
/*        [Authorize(Roles ="Admin")]
*/        public IActionResult Add([FromBody]Product product) //add product details
        {
            _productRepository.Add(product);
            return StatusCode(200, product);
        }
        //Put Endpoint
        [HttpPut, Route("EditProduct")]
        //[Authorize(Roles = "Admin")]
/*        [Authorize(Roles = "Admin")]
*/        public IActionResult Edit([FromBody]Product product) //Edit product details
        {
            _productRepository.Update(product);
            return StatusCode(200, product);
        }
        //Delete Endpoint
        [HttpDelete, Route("DeleteProduct")]
        //[Authorize(Roles = "Admin")]
/*        [Authorize(Roles = "Admin")]
*/        public IActionResult Delete([FromQuery]int id) //Delete Product using id
        {
            _productRepository.Delete(id);
            return Ok(); //Empty Response
        }
    }
}
