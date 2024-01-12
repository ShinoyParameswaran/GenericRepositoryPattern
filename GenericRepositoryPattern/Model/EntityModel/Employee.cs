namespace GenericRepositoryPattern.Model.EntityModel
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CityId { get; set; }
        public int DesignationId { get; set; }
        public int EducationId { get; set; }
        public int DepartmentId { get; set; }

        // Navigation properties
        public City? City { get; set; }
        public Designation? Designation { get; set; }
        public Education? Education { get; set; }
        public Department? Department { get; set; }
    }
}
