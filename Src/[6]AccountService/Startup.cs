﻿
using Microsoft.Owin;

[assembly: OwinStartup(typeof(AccountService.Startup))] 
namespace AccountService
{
    using Microsoft.Owin.Extensions;

    using Owin;

    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseNancy();
            app.UseStageMarker(PipelineStage.MapHandler);
        }
    }
}