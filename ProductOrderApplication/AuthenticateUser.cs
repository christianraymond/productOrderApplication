﻿using System;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security.Cookies;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(ProductOrderApplication.AuthenticateUser))]

namespace ProductOrderApplication
{
    public class AuthenticateUser
    {
        public void Configuration(IAppBuilder app)
        {
            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=316888
            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                LoginPath = new PathString("/Login")
            });
        }
    
    }
}
