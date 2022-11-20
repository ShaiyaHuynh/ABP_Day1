using HelloWord.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace HelloWord.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class HelloWordPageModel : AbpPageModel
{
    protected HelloWordPageModel()
    {
        LocalizationResourceType = typeof(HelloWordResource);
    }
}
