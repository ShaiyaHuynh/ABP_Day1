using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Volo.Abp;

namespace HelloWord;

public class HelloWordWebTestStartup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddApplication<HelloWordWebTestModule>();
    }

    public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
    {
        app.InitializeApplication();
    }
}
