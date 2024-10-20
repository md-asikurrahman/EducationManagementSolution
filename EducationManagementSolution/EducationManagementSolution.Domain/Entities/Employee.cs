using EducationManagementSolution.Domain.Common;

namespace EducationManagementSolution.Domain.Entities;

public class Employee: BaseEntity
{
    public int DepartmentId { get; set; }
    public Department Department { get; set; }
    public string Name { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string NidNo { get; set; }
    public string FatherName { get; set; }
    public string MotherName { get; set; }
    public string SpouseName { get; set; }
    public string ImageUrl { get; set; }
    public string NidImageUrl { get; set; }
    public string Signature { get; set; }
    public string Email {  get; set; }
    public string MobileNo { get; set; }
    public string AlternateMobile {  get; set; }
    public ICollection<AcademicQualification> AcademicQualifications { get; set; }

}
