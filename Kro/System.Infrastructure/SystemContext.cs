using System.Reflection;
using Microsoft.EntityFrameworkCore;

namespace System.Infrastructure;

public class SystemContext: DbContext
{
    public SystemContext(DbContextOptions<SystemContext> options) : base(options) { }
    
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}