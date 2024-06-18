using System.Domain.Languages.Entities;
using System.Domain.Languages.Repositories;
using Core.Infrastructure.Repositories;

namespace System.Infrastructure.Languages.Repositories;

public class LanguageRootRepository : KRepository<LanguageEntity>, ILanguageRootRepository
{
    public LanguageRootRepository(IServiceProvider serviceProvider) : base(serviceProvider)
    {
    }
}