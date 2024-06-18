using System.Application.Languages.LanguageType.Commands;
using System.Application.Languages.LanguageType.Queries;
using Core.Web.Controllers;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace System.Web.Languages.Controllers;

[Route("/api/language-type")]
public class LanguageTypeController : KController
{
    public LanguageTypeController(IMediator mediator) : base(mediator)
    {
    }
    
    [HttpGet]
    public async Task<ListLanguageTypeQuery.Response> List()
    {
        var result = await Mediator.Send(new ListLanguageTypeQuery.Request {});
        return result;
    }
    
    [HttpGet("{id}")]
    public async Task<DetailLanguageTypeQuery.Response> Detail([FromRoute] Guid id)
    {
        var result = await Mediator.Send(new DetailLanguageTypeQuery.Request
        {
            Id = id,
        });
        return result;
    }
    
    [HttpPost]
    public async Task<Unit> Create([FromBody] CreateLanguageTypeCommand.Request body)
    {
        var result = await Mediator.Send(body);
        return Unit.Value;
    }
    
    [HttpPut("{id}")]
    public async Task<ListLanguageTypeQuery.Response> Update([FromRoute] Guid id)
    {
        var result = await Mediator.Send(new ListLanguageTypeQuery.Request {});
        return result;
    }
    
    [HttpDelete("{id}")]
    public async Task<Unit> Delete([FromRoute] Guid id, [FromBody] CreateLanguageTypeCommand.Request body)
    {
        var result = await Mediator.Send(body);
        return Unit.Value;
    }
}