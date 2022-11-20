using HelloWord.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace HelloWord.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class HelloWordController : AbpControllerBase
{
    protected HelloWordController()
    {
        LocalizationResource = typeof(HelloWordResource);
    }
}
