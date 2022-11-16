using GizaSystems.AbpDemo.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace GizaSystems.AbpDemo.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(AbpDemoEntityFrameworkCoreModule),
    typeof(AbpDemoApplicationContractsModule)
    )]
public class AbpDemoDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
