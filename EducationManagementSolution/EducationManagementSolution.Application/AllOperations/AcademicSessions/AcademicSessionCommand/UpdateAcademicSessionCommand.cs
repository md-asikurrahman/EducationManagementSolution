using MediatR;

namespace EducationManagementSolution.Application.AllOperations.AcademicSessions.AcademicSessionCommand;

public class UpdateAcademicSessionCommand : IRequest<IList<string>>
{
    public int Id { get; set; }
    public string SessionName { get; set; }
    public string SessionDescription { get; set; }
}
