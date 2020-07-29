using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Paper.Record.Pages
{
    public class Index_Tests : RecordWebTestBase
    {
        [Fact]
        public async Task Welcome_Page()
        {
            var response = await GetResponseAsStringAsync("/");
            response.ShouldNotBeNull();
        }
    }
}
