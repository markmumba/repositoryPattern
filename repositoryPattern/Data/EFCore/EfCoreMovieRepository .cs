using repositoryPattern.Models;

namespace repositoryPattern.Data.EFCore
{
    public class EfCoreMovieRepository :EfCoreRepository<Movie , repositoryPatternContext>
    {
        public EfCoreMovieRepository(repositoryPatternContext context ) :base (context)
        {

        }

    }
}


