using MediatR;

namespace EducationManagementSolution.Application.AllOperations.AcademicSessions.AcademicSessionQueries
{
    public record GetAllAcademicSessionsQuery : IRequest<IList<AcademicSessionDTO>>;

    public class GetAllAcademicSessionsQueryHandler : IRequestHandler<GetAllAcademicSessionsQuery, IList<AcademicSessionDTO>>
{
        public async Task<IList<AcademicSessionDTO>> Handle(GetAllAcademicSessionsQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
