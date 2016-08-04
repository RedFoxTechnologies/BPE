using System.Threading.Tasks;
using BPE.Web.Controllers;
using Shouldly;
using Xunit;

namespace BPE.Web.Tests.Controllers
{
    public class HomeController_Tests: BPEWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            //Act
            var response = await GetResponseAsStringAsync(
                               GetUrl<HomeController>(nameof(HomeController.Index))
                           );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}
