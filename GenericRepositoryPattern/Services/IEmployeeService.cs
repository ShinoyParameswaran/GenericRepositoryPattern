

using GenericRepositoryPattern.Model.APIModel;

namespace GenericRepositoryPattern.Services
{
    public interface IEmployeeService
    {
        IEnumerable<EmployeeDto> GetEmployees();
        EmployeeDto GetEmployeeById(int id);
        void CreateEmployee(EmployeeDto employeeDto);
        void UpdateEmployee(int id, EmployeeDto employeeDto);
        void DeleteEmployee(int id);
    }
}
