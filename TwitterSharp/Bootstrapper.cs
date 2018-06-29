using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Unity.Mvc3;
using TwitterSharp.Services.Services;
using TwitterSharp.Controllers;

namespace TwitterSharp
{
    public static class Bootstrapper
    {
        public static void Initialise()
        {
            var container = BuildUnityContainer();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }

        private static IUnityContainer BuildUnityContainer()
        {
            var container = new UnityContainer();
            container.RegisterType<AccountController>(new InjectionConstructor());
            container.RegisterType<ManageController>(new InjectionConstructor());
            container.RegisterType<ITweetService, TweetService>();
            container.RegisterType<IUserService, UserService>();

            return container;
        }
    }
}