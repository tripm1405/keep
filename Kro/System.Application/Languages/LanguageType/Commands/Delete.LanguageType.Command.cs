using System.Domain.Languages.Entities;
using AutoMapper;
using Core.Application.Handlers;
using Core.Application.Requests;
using Core.Domain.Repositories;

namespace System.Application.Languages.LanguageType.Commands;

public class DeleteLanguageTypeCommand
{
    public class Request : KDeleteRequest
    {
    }
    
    public class Handler : KDeleteHandler<Request, LanguageTypeEntity>
    {
        public Handler(IMapper mapper, IKRepository<LanguageTypeEntity> repository) : base(mapper, repository)
        {
        }
    }
}