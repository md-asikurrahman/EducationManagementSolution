using MediatR;

namespace EducationManagementSolution.Application.AllOperations.AcademicSessions.AcademicSessionCommand;

public class CreateAcademicSessionCommand : IRequest<IList<string>>
{
    public string SessionName { get; set; }
    public string SessionDescription { get; set; }
}

