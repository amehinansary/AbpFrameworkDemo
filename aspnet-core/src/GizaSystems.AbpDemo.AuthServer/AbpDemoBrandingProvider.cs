using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace GizaSystems.AbpDemo;

[Dependency(ReplaceServices = true)]
public class AbpDemoBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "AbpDemo";
}
