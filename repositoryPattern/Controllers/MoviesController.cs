using Microsoft.AspNetCore.Mvc;
using repositoryPattern.Data.EFCore;
using repositoryPattern.Models;

namespace repositoryPattern.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : RepositoryController<Movie, EfCoreMovieRepository>
    {
        public MoviesController(EfCoreMovieRepository repository) : base(repository)
        {

        }
    }

}
