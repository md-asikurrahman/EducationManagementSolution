using EducationManagementSolution.Domain.Common;

namespace EducationManagementSolution.Domain.Entities;

public class Designation : BaseEntity
{
    public string DesignationName { get; set; }
    public string DesignationDescription { get; set; }
    public ICollection<Employee> Employees { get; set; }
}
