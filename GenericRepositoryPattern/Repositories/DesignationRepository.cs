using GenericRepositoryPattern.Data;
using GenericRepositoryPattern.Model.EntityModel;

namespace GenericRepositoryPattern.Repositories
{
    public class DesignationRepository : Repository<Designation>, IDesignationRepository
    {
        public DesignationRepository(AppDbContext context) : base(context) { }
    
    }
}
