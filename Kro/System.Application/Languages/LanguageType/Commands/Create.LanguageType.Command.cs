﻿using System.Domain.Languages.Entities;
using AutoMapper;
using Core.Application.Handlers;
using Core.Application.Requests;
using Core.Domain.Repositories;

namespace System.Application.Languages.LanguageType.Commands;

public class CreateLanguageTypeCommand
{
    public class Request : KCreateRequest
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public bool IsDefault { get; set; } = false;
    }
    
    public class Handler : KCreateHandler<Request, LanguageTypeEntity>
    {
        public Handler(IMapper mapper, IKRepository<LanguageTypeEntity> repository) : base(mapper, repository)
        {
        }
    }
}