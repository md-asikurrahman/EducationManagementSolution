using EducationManagementSolution.Domain.Common;

namespace EducationManagementSolution.Domain.Entities;

public class AcademicQualification: BaseEntity
{
    public string EducationLevelName { get; set; }
    public string RollNo { get; set; }
    public string RegistrationNo { get; set; }
    public string DegreeTitle { get; set; }
    public string Group { get; set; }
    public string InstituteName { get; set; }
    public string Result { get; set; }
    public int PassingYear { get; set; }
    public string Achievement { get; set; }
    public string Scale { get; set; }
    public string Certificate { get; set; }
    public string MarkSheet { get; set; }
    public int EmployeeId { get; set; }
    public Employee Employee { get; set; }

}
