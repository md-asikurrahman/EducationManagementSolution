using EducationManagementSolution.Application.AllOperations.AcademicSessions.AcademicSessionCommand;
using MediatR;

namespace EducationManagementSolution.Application.AllOperations.AcademicSessions.AcademicSessionCommandHandler;

public class CreateAcademicSessionCommandHandler : IRequestHandler<CreateAcademicSessionCommand, IList<string>>
{
    public async Task<IList<string>> Handle(CreateAcademicSessionCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
