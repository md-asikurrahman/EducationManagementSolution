using EducationManagementSolution.Domain.Common;

namespace EducationManagementSolution.Domain.Entities;

public class EducationLevel : BaseEntity
{
    public string LevelName { get; set; }
    public string LevelDescription { get; set; } = string.Empty;
    public ICollection<ClassList> ClassList { get; set; }
    public ICollection<Department> Departments { get; set; } = new List<Department>();
}
