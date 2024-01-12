using GenericRepositoryPattern.Data;
using GenericRepositoryPattern.Model.EntityModel;

namespace GenericRepositoryPattern.Repositories
{
    public class EmployeeRepository : Repository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(AppDbContext context) : base(context) { }
    }
}
