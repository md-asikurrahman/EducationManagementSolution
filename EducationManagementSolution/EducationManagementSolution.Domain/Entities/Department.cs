using EducationManagementSolution.Domain.Common;

namespace EducationManagementSolution.Domain.Entities;

public class Department : BaseEntity
{
    public int EducationLevelId { get; set; }
    public EducationLevel EducationLevel { get; set; }
    public string DepartmentName { get; set; }
    public string DepartmentDescription { get; set; }
    public ICollection<Employee> Employees { get; set; }
}
