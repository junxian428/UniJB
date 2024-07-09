using AppLevelAuthorization.Application;
using AppLevelAuthorization.Application.Queries.RoleQueries;
using AppLevelAuthorization.Application.Queries.TimeTableQueries;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Extensions;

namespace AppLevelAuthorization.Api.Controllers;

[ApiController]
[Authorize]
public class TimetableController : ControllerBase
{
    private readonly IMediator _mediator;

    public TimetableController(IMediator mediator)
    {
        _mediator = mediator;
    }
    
    
    [HttpGet(Routes.Timetable.User)]
    public async Task<IActionResult> GetTimetableForUser()
    {
        return Ok(await _mediator.Send(new UserQuery()));
    }
    
    [HttpGet(Routes.Timetable.Supervisor)]
    public async Task<IActionResult> GetTimetableForSupervisor()
    {
        return Ok(await _mediator.Send(new AdminTimeTableQuery()));
    }

    [HttpGet(Routes.Timetable.Manager)]
    public async Task<IActionResult> GetTimetableForManager()
    {
        return Ok(await _mediator.Send(new AdminTimeTableQuery()));
    }

    [HttpGet(Routes.Timetable.Admin)]
    public async Task<IActionResult> GetTimetableForAdmin()
    {
        return Ok(await _mediator.Send(new AdminTimeTableQuery()));
    }
}