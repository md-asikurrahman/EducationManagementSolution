using EducationManagementSolution.Domain.Common;

namespace EducationManagementSolution.Domain.Entities;

public class Subject : BaseEntity
{
    public string SubjectName { get; set; }
    public string Description { get; set; }
    public string SubjectCode { get; set; }
    public string? SubjectCodePair { get; set; }
}
