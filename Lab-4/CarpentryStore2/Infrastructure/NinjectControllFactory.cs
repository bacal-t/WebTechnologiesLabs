using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ninject;
using System.Web.Routing;
using System.Web.Mvc;
using CarpentyStore2.Domain.Abstract;
using CarpentyStore2.Domain.Concrete;

namespace CarpentryStore2.Infrastructure
{
    public class NinjectControlFactory : DefaultControllerFactory
    {
        private IKernel ninjectKernel;
        public NinjectControlFactory()
        {
            ninjectKernel = new StandardKernel();
            AddBindings();
        }

        protected override IController GetControllerInstance(
            RequestContext requestContext, Type controllerType)
        {
            return controllerType == null
                ? null
                : (IController)ninjectKernel.Get(controllerType);

        }

        private void AddBindings()
        {
            ninjectKernel.Bind<IDoorRepository>().To<EFDoorRepository>();
        }
    }
}