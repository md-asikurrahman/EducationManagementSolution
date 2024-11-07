using EducationManagementSolution.Domain.Common;

namespace EducationManagementSolution.Domain.Entities;

public class Student : BaseEntity
{
    public string Name { get; set; }
    public string FatherName { get; set; }
    public string MotherName { get; set; }
    public string MobileNo { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string ImageUrl { get; set; }
    public string Signature { get; set; }
    
}
