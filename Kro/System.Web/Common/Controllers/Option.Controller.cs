using Core.Web.Controllers;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace System.Web.Common.Controllers;

[Route("/api/option")]
public class OptionController : KController
{
    public OptionController(IMediator mediator) : base(mediator)
    {
    }
}