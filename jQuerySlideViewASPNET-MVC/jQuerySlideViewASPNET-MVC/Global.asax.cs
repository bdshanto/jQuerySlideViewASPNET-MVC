using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using AutoMapper;
using jQuerySlideViewASPNET_MVC.Models;

namespace jQuerySlideViewASPNET_MVC
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            Mapper.Initialize(conf =>
            {
                conf.CreateMap<StudentInformation, StudentInformationVm>();
                conf.CreateMap<StudentInformationVm, StudentInformation>();

            });
        }
    }
}
