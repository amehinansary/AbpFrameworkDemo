using Volo.Abp.Modularity;

namespace GizaSystems.AbpDemo;

[DependsOn(
    typeof(AbpDemoApplicationModule),
    typeof(AbpDemoDomainTestModule)
    )]
public class AbpDemoApplicationTestModule : AbpModule
{

}
