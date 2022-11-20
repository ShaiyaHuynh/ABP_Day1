using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace HelloWord.Pages;

public class Index_Tests : HelloWordWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
