using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Paddle.Startup))]
namespace Paddle
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
