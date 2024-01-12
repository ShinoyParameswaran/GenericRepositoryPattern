using GenericRepositoryPattern.Data;
using GenericRepositoryPattern.Model.EntityModel;

namespace GenericRepositoryPattern.Repositories
{
    public class CityRepository : Repository<City>, ICityRepository
    {
        public CityRepository(AppDbContext context) : base(context) { }
    
    }
}
