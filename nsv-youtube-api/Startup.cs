using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(nsv_youtube_api.Startup))]
namespace nsv_youtube_api
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
