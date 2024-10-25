using Microsoft.AspNetCore.Identity;

namespace EducationManagementSolution.Domain.Entities;

public class ApplicationUser : IdentityUser
{
    public string FullName { get; set; }
    public int ReferenceId { get; set; }
    public string MobileNo { get; set; }
    public DateTime UpdatedAt { get; set; }
    public string UpdatedBy { get; set; }
}
