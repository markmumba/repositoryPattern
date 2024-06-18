using Microsoft.AspNetCore.Mvc;
using repositoryPattern.Data.EFCore;
using repositoryPattern.Models;

namespace repositoryPattern.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StarsController : RepositoryController<Star,EfCoreStarRepository>
    {
        public StarsController(EfCoreStarRepository repository) : base(repository)
        {

        }

    }
}
