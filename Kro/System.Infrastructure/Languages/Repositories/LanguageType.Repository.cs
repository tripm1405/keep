using System.Domain.Languages.Entities;
using System.Domain.Languages.Repositories;
using Core.Infrastructure.Repositories;

namespace System.Infrastructure.Languages.Repositories;

public class LanguageTypeRepository : KRepository<LanguageTypeEntity>, ILanguageTypeRepository
{
    public LanguageTypeRepository(IServiceProvider serviceProvider) : base(serviceProvider)
    {
    }
}