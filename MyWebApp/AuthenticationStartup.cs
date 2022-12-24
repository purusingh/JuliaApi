using Microsoft.Owin;
using Microsoft.Owin.Security.OAuth;
using MyWebApp.Controllers.Authorizations;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
//[assembly: OwinStartup(typeof(AuthenticationStartup))]
namespace MyWebApp
{

    public class AuthenticationStartup
    {
        public void Configuration(IAppBuilder app)
        {
           
        }
    }

}