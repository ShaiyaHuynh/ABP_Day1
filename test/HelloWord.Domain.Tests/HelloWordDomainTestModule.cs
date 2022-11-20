using HelloWord.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace HelloWord;

[DependsOn(
    typeof(HelloWordEntityFrameworkCoreTestModule)
    )]
public class HelloWordDomainTestModule : AbpModule
{

}
