using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EducationWorkJournal.Startup))]
namespace EducationWorkJournal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
