using InMemoeryApp.Presentation.Data.Entities;
using InMemoeryApp.Presentation.Mediaters.Commands;
using InMemoeryApp.Presentation.Mediaters.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace InMemoeryApp.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMediator _mediator;

        /*
        //https://localhost:7034/
        //domain/api/Product
        [HttpGet]
        public string Products()
        {
            return "Merhaba arkdaşlar";
        }
        */

        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }



        //https://localhost:7034/
        [HttpGet]
        public async Task<IActionResult> GetaLLProducts()
        {
            var request = new GetAllProductsQuery();
            var products = await _mediator.Send(request);
            return Ok(products);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var request = new GetProductByIdQuery() { Id = id };
            var _product = await _mediator.Send(request);
            return Ok(_product);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Product product)
        {
            var request = new CreateProductCommand() { Product = product };
            var _product = await _mediator.Send(request);
            return Ok(_product);
        }



        [HttpPut("{id}")]
        public async Task<IActionResult> Create(Guid id, [FromBody] Product product)
        {
            //if (id !=)
            //{
            //    BadRequest();
            //}
            var request = new UpdateProductCommand() { Product = product };
            var _product = await _mediator.Send(request);
            return Ok(_product);
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _mediator.Send(new DeleteProductCommand() { Id = id });
            return NoContent();
        }
    }
}

//asenkron'un 3 temel kuralı 
/*
 //Metod imzasında 
 1)async
 2)Task 

 //Gövde kısmında
 3)await
 */