using Microsoft.AspNetCore.Mvc;
using repositoryPattern.Data;

namespace repositoryPattern.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public abstract class RepositoryController<TEntity, TRespository> : ControllerBase
        where TEntity : class, IEntity
        where TRespository : IRepository<TEntity>
    {
        private readonly TRespository repository;

        public RepositoryController(TRespository repository)
        {
            this.repository = repository;
        }

        // GET: api/[controller]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TEntity>>> GetAllData()
        {
            return await repository.GetAllData();
        }
        // GET: api/[controller]/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TEntity>> GetDataById(int id)
        {
            var movie = await repository.GetDataById(id);
            if (movie == null)
            {
                return NotFound();
            }
            return movie;
        }

        // PUT: api/[controller]/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateDataById(int id, TEntity movie)
        {
            if (id != movie.Id)
            {
                return BadRequest();
            }
            await repository.UpdateDataById(movie);
            return NoContent();
        }

        // POST: api/[controller]
        [HttpPost]
        public async Task<ActionResult<TEntity>> AddNewData(TEntity movie)
        {
            await repository.AddNewData(movie);
            return CreatedAtAction("Get", new { id = movie.Id }, movie);
        }

        // DELETE: api/[controller]/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TEntity>> DeleteData(int id)
        {
            var movie = await repository.DeleteData(id);
            if (movie == null)
            {
                return NotFound();
            }
            return movie;
        }

    }
}