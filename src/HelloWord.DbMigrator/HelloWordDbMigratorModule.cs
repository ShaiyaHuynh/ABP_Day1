using HelloWord.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace HelloWord.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(HelloWordEntityFrameworkCoreModule),
    typeof(HelloWordApplicationContractsModule)
    )]
public class HelloWordDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
