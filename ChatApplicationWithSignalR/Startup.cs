using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ChatApplicationWithSignalR.Startup))]
namespace ChatApplicationWithSignalR
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
            ConfigureAuth(app);
        }
    }
}
