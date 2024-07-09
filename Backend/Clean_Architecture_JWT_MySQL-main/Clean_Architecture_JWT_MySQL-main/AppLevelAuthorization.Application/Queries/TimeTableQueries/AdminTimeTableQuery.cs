using AppLevelAuthorization.Application.Identity;
using MediatR;

namespace AppLevelAuthorization.Application.Queries.TimeTableQueries;

[Authorize(Role = EnRole.Admin)]
public record AdminTimeTableQuery() : IRequest<string>;

public class AdminTimeTableQueryHandler : IRequestHandler<AdminTimeTableQuery, string>
{
    public Task<string> Handle(AdminTimeTableQuery request, CancellationToken cancellationToken) 
        => Task.FromResult("Admin Timetable Query");
}

