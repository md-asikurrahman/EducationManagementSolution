using EducationManagementSolution.Application.AllOperations.AcademicSessions.AcademicSessionCommand;
using MediatR;

namespace EducationManagementSolution.Application.AllOperations.AcademicSessions.AcademicSessionCommandHandler;

public class UpdateAcademicSessionCommandHandler : IRequestHandler<UpdateAcademicSessionCommand, IList<string>>
{
    public async Task<IList<string>> Handle(UpdateAcademicSessionCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
