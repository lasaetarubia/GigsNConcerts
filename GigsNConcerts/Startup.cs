using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GigsNConcerts.Startup))]
namespace GigsNConcerts
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
