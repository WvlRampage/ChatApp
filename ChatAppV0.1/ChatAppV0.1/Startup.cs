﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ChatAppV0._1.Startup))]
namespace ChatAppV0._1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            app.MapSignalR();
        }
    }
}
