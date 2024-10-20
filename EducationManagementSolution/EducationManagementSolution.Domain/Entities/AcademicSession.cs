using EducationManagementSolution.Domain.Common;

namespace EducationManagementSolution.Domain.Entities;

public class AcademicSession : BaseEntity
{
    public string SessionName {  get; set; }
    public string SessionDescription { get; set; }

}
