using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace HelloWord.Web;

[Dependency(ReplaceServices = true)]
public class HelloWordBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "HelloWord";
}
