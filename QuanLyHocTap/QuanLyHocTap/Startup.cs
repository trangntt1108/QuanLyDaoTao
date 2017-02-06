using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(QuanLyHocTap.Startup))]
namespace QuanLyHocTap
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
