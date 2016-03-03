﻿using System;
using System.Web.Http;


namespace KakiHooks
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            GlobalConfiguration.Configure(WebHookConfig.Register);
        }
    }
}