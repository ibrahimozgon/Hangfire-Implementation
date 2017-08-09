using System;
using Hangfire;

namespace HangfireImpl
{
    public class JobBuilder
    {
        public void Build()
        {
            RecurringJob.AddOrUpdate("EmailNotificationJob", () => EmailNotificationJob.Execute(), Cron.Minutely,
                TimeZoneInfo.Local);
        }
    }
}