using GenericRepositoryPattern.Model.EntityModel;


namespace GenericRepositoryPattern.Repositories
{
    public interface IEmployeeRepository : IRepository<Employee>
    {
        // Define specific methods for Employee if needed.
    }
}
