using GenericRepositoryPattern.Model.APIModel;
using GenericRepositoryPattern.Model.EntityModel;
using GenericRepositoryPattern.UnitOfWork.EmployeeService.Infrastructure.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepositoryPattern.Services
{
    // MyApiProject.Application.Services
    public class EmployeeService : IEmployeeService
    {
        private readonly IUnitOfWork _unitOfWork;

        public EmployeeService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<EmployeeDto> GetEmployees()
        {
            
            var employees = _unitOfWork.Employees.GetAll();
            return MapToEmployeeDtoList(employees);
        }

        public EmployeeDto GetEmployeeById(int id)
        {
            var employee = _unitOfWork.Employees.GetById(id);
            return MapToEmployeeDto(employee);
        }

        public void CreateEmployee(EmployeeDto employeeDto)
        {
            var employee = MapToEmployee(employeeDto);
            _unitOfWork.Employees.Add(employee);
            _unitOfWork.Complete();
        }

        public void UpdateEmployee(int id, EmployeeDto employeeDto)
        {
            var existingEmployee = _unitOfWork.Employees.GetById(id);

            if (existingEmployee == null)
            {
                // Handle not found scenario
                return;
            }

            // Update properties based on employeeDto
            existingEmployee.Name = employeeDto.Name;
            existingEmployee.CityId = employeeDto.CityId;
            existingEmployee.DesignationId = employeeDto.DesignationId;
            existingEmployee.EducationId = employeeDto.EducationId;
            existingEmployee.DepartmentId = employeeDto.DepartmentId;

            _unitOfWork.Complete();
        }

        public void DeleteEmployee(int id)
        {
            var employee = _unitOfWork.Employees.GetById(id);

            if (employee == null)
            {
                // Handle not found scenario
                return;
            }

            _unitOfWork.Employees.Delete(employee);
            _unitOfWork.Complete();
        }

        private EmployeeDto MapToEmployeeDto(Employee employee)
        {
            return new EmployeeDto
            {
                Id = employee.Id,
                Name = employee.Name,
                CityId = employee.CityId,
                DesignationId = employee.DesignationId,
                EducationId = employee.EducationId,
                DepartmentId = employee.DepartmentId
            };
        }

        private IEnumerable<EmployeeDto> MapToEmployeeDtoList(IEnumerable<Employee> employees)
        {
            return employees.Select(MapToEmployeeDto);
        }

        private Employee MapToEmployee(EmployeeDto employeeDto)
        {
            return new Employee
            {
                Name = employeeDto.Name,
                CityId = employeeDto.CityId,
                DesignationId = employeeDto.DesignationId,
                EducationId = employeeDto.EducationId,
                DepartmentId = employeeDto.DepartmentId
            };
        }

    }

}
