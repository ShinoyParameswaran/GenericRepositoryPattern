using GenericRepositoryPattern.Repositories;

namespace GenericRepositoryPattern.UnitOfWork
{
    namespace EmployeeService.Infrastructure.UnitOfWork
    {
        public interface IUnitOfWork
        {
            IEmployeeRepository Employees { get; }
            IDesignationRepository Designation { get; }

            int Complete();
        }

    }

}
