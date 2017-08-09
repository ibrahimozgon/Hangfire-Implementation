using System;
using Hangfire;
using Hangfire.Redis;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(HangfireImpl.Startup))]

namespace HangfireImpl
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            GlobalConfiguration.Configuration.UseRedisStorage("127.0.0.1", new RedisStorageOptions { Db = 2 });

            app.UseHangfireDashboard("");
            app.UseHangfireServer();

            var jobBuilder = new JobBuilder();
            jobBuilder.Build();
        }
    }
}
