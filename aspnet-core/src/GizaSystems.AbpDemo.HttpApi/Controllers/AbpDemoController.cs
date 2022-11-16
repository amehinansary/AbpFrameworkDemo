using GizaSystems.AbpDemo.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace GizaSystems.AbpDemo.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class AbpDemoController : AbpControllerBase
{
    protected AbpDemoController()
    {
        LocalizationResource = typeof(AbpDemoResource);
    }
}
