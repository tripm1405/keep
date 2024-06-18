using Core.Application.DTOs;

namespace Core.Application.Extensions;

public static class KListExtension
{
    public static int GetSkip<TRequest>(this TRequest request) where TRequest : IKListQuery
    {
        return (request.Page - 1) * request.Size;
    }
}