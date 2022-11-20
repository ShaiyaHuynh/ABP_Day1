using System;
using System.Collections.Generic;
using System.Text;
using HelloWord.Localization;
using Volo.Abp.Application.Services;

namespace HelloWord;

/* Inherit your application services from this class.
 */
public abstract class HelloWordAppService : ApplicationService
{
    protected HelloWordAppService()
    {
        LocalizationResource = typeof(HelloWordResource);
    }
}
