using Volo.Abp.Modularity;

namespace HelloWord;

[DependsOn(
    typeof(HelloWordApplicationModule),
    typeof(HelloWordDomainTestModule)
    )]
public class HelloWordApplicationTestModule : AbpModule
{

}
