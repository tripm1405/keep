using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Core.Web.Controllers;

[ApiController]
public abstract class KController : ControllerBase
{
    protected readonly IMediator Mediator;

    protected KController(IMediator mediator)
    {
        Mediator = mediator;
    }
}