namespace GenericRepositoryPattern.Model.APIModel
{
    public class EmployeeDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CityId { get; set; }
        public int DesignationId { get; set; }
        public int EducationId { get; set; }
        public int DepartmentId { get; set; }
    }
}
