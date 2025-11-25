using Microsoft.AspNetCore.Mvc;
using ShoeStoreAPI.Models;
using ShoeStoreAPI.Services;

namespace ShoeStoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShoeController : ControllerBase
    {
        private readonly ShoeService _service = new ShoeService();

        [HttpGet]
        public IActionResult GetAll() => Ok(_service.GetAll());

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var shoe = _service.GetById(id);
            if (shoe == null) return NotFound();
            return Ok(shoe);
        }

        [HttpPost]
        public IActionResult Create(Shoe shoe)
        {
            _service.Add(shoe);
            return CreatedAtAction(nameof(Get), new { id = shoe.Id }, shoe);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Shoe shoe)
        {
            var existing = _service.GetById(id);
            if (existing == null) return NotFound();
            _service.Update(shoe);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _service.Delete(id);
            return NoContent();
        }
    }
}
