using Microsoft.AspNetCore.Mvc;
using UniqueFood.API.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace UniqueFood.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BaseController<T> : ControllerBase where T : class
    {
        private readonly IGenericRepository<T> _repository;

        public BaseController(IGenericRepository<T> repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<T>>> GetAll()
        {
            var items = await _repository.GetAllAsync();
            return Ok(items);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<T>> GetById(int id)
        {
            var item = await _repository.GetByIdAsync(id);
            if (item == null)
                return NotFound();
            return Ok(item);
        }

        [HttpPost]
        public async Task<ActionResult<T>> Create(T entity)
        {
            var created = await _repository.AddAsync(entity);
            return CreatedAtAction(nameof(GetById), new { id = GetId(created) }, created);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, T entity)
        {
            var existing = await _repository.GetByIdAsync(id);
            if (existing == null)
                return NotFound();

            await _repository.UpdateAsync(entity);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _repository.DeleteAsync(id);
            if (!result)
                return NotFound();
            return NoContent();
        }

        // Helper method to get ID dynamically (optional for CreatedAtAction)
        private int GetId(T entity)
        {
            var prop = typeof(T).GetProperty("Id");
            return prop != null ? (int)(prop.GetValue(entity) ?? 0) : 0;
        }
    }
}
