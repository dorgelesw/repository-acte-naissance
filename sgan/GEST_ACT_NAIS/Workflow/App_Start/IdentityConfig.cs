using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(P7GestAct.IdentityConfig))]
namespace P7GestAct
{
    public class IdentityConfig
    {
        public void Configuration(IAppBuilder app) { }

    }


}