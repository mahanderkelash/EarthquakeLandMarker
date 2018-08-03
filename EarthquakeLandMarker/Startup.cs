using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EarthquakeLandMarker.Startup))]
namespace EarthquakeLandMarker
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
