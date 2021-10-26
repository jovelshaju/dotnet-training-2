using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAppFilterExercise.Startup))]
namespace WebAppFilterExercise
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
