using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using GuideApp.Infrasructure;
using GuideApp.Repository;
using GuideApp.Service;
using System.Linq;
using System.Reflection;
using System.Web.Http;
using System.Web.Mvc;
using MultipartDataMediaFormatter;

namespace GuideApp.WebApi.App_Start
{
    public class Boostraper
    {
        public static void Run()
        {
            SetAutofacContainer();
        }
        public static void SetAutofacContainer()
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(Assembly.GetExecutingAssembly());
            builder.RegisterType<UnitOfWork>().As<IUnitofWork>().InstancePerRequest();
            builder.RegisterType<DbFactory>().As<IDbFactory>().InstancePerRequest();

            // Repositories
            builder.RegisterAssemblyTypes(typeof(TipRepository).Assembly)
                .Where(t => t.Name.EndsWith("Repository"))
                .AsImplementedInterfaces().InstancePerRequest();

            // Services
            builder.RegisterAssemblyTypes(typeof(TipService).Assembly)
               .Where(t => t.Name.EndsWith("Service"))
               .AsImplementedInterfaces().InstancePerRequest();

            // Register Web API controllers.
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            IContainer container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

            GlobalConfiguration.Configuration.DependencyResolver = new AutofacWebApiDependencyResolver(container);

            GlobalConfiguration.Configuration.Formatters.Add(new FormMultipartEncodedMediaTypeFormatter());
        }
    }
}