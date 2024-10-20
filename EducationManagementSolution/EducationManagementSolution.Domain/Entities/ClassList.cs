using EducationManagementSolution.Domain.Common;

namespace EducationManagementSolution.Domain.Entities;

public class ClassList : BaseEntity
{
    public int EducationLevelId { get; set; }
    public EducationLevel EducationLevel { get; set; } 
    public string ClassName { get; set; }
    public string Description { get; set; }
}
