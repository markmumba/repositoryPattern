using repositoryPattern.Models;

namespace repositoryPattern.Data.EFCore;

public class EfCoreStarRepository :EfCoreRepository<Star, repositoryPatternContext>
{
    public EfCoreStarRepository(repositoryPatternContext context) :base (context)
    {
        
    }
    
}