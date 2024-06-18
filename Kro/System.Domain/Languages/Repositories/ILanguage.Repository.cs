using System.Domain.Languages.Entities;
using Core.Domain.Repositories;

namespace System.Domain.Languages.Repositories;

public interface ILanguageRootRepository : IKRepository<LanguageEntity>
{
}