using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AssessmentTest.Startup))]
namespace AssessmentTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
