using System.Threading.Tasks;

namespace GizaSystems.AbpDemo.Data;

public interface IAbpDemoDbSchemaMigrator
{
    Task MigrateAsync();
}
