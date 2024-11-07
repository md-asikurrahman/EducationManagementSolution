using MediatR;

namespace EducationManagementSolution.Application.AllOperations.AcademicSessions.AcademicSessionQueries;

public record GetAcademicSessionByIdQuery(int Id) : IRequest<AcademicSessionDTO>;

public class GetAcademicSessionByIdQueryHandler : IRequestHandler<GetAcademicSessionByIdQuery, AcademicSessionDTO>
{
    public async Task<AcademicSessionDTO> Handle(GetAcademicSessionByIdQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
