using GizaSystems.AbpDemo.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace GizaSystems.AbpDemo;

[DependsOn(
    typeof(AbpDemoEntityFrameworkCoreTestModule)
    )]
public class AbpDemoDomainTestModule : AbpModule
{

}
