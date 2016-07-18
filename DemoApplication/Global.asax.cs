﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using DemoApplication.Filters;

namespace DemoApplication
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
		
			GlobalFilters.Filters.Add(new LoggingFilter());

            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
