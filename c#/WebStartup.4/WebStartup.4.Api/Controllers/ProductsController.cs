using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebStartup._4.Api.Repositories;
using WebStartup._4.Api.Models;
using WebStartup._4.Api.Repositories.Fake;
using Microsoft.AspNetCore.Authorization;

namespace WebStartup._4.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/product")]
    public class ProductsController : Controller
    {
        // GET: api/Product
        [Authorize("Bearer")]
        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            var repository = new ProductsRepository();
            var result = await repository.GetAllAsync();

            if (result == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(result);
            }
        }

        // GET: api/Product/5
        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(int id)
        {
            var repository = new ProductsRepository();
            var result = repository.Get(id);

            if (result==null)
            {
                return NotFound();
            } else
            {
                return Ok(result);
            }
        }

        // POST: api/Product
        [HttpPost()]
        public IActionResult Post([FromBody]Product value)
        {
            var repository = new ProductsRepository();
            repository.Add(value);

            return CreatedAtAction(nameof(Get), new { id = value.ID }, value);

        }

        // PUT: api/Product/5
        [HttpPut()]
        public IActionResult Put([FromBody]Product product)
        {
            var repository = new ProductsRepository();
            repository.Update(product);

            return NoContent();
        }

        // DELETE: api/product/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var repository = new ProductsRepository();
            repository.Delete(id);

            return NoContent();
        }
    }
}
