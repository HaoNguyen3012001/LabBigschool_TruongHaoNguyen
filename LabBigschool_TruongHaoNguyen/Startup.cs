using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LabBigschool_TruongHaoNguyen.Startup))]
namespace LabBigschool_TruongHaoNguyen
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
