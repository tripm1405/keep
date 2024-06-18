using System.Domain.Languages.Entities;
using AutoMapper;
using Core.Application.Handlers;
using Core.Application.Requests;
using Core.Domain.Repositories;

namespace System.Application.Languages.Language.Commands;

public class LanguageDeleteCommand
{
    public class Request : KDeleteRequest
    {
        
    }
    
    public class Handler : KDeleteHandler<Request, LanguageEntity>
    {
        public Handler(IMapper mapper, IKRepository<LanguageEntity> repository) : base(mapper, repository)
        {
        }
    }
}