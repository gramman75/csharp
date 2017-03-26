using Quartz;
using Quartz.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GScheduler
{
    class Program
    {
        static void Main(string[] args)
        {
            Common.Logging.LogManager.Adapter = new Common.Logging.Simple.ConsoleOutLoggerFactoryAdapter {
                Level = Common.Logging.LogLevel.Info };

            IScheduler scheduler = StdSchedulerFactory.GetDefaultScheduler();

            scheduler.Start();

            IJobDetail job = JobBuilder.Create<GJob>()
                .WithIdentity("job1", "group1")
                .UsingJobData("ServiceId", "BR_SST10_101")
                .Build();

            ITrigger trigger = TriggerBuilder.Create()
                .WithIdentity("trigger1", "group1")
                //.StartNow()
                .WithCronSchedule("0 38 23 23 3 ?")
                //.WithSimpleSchedule(x =>
                //   x.WithIntervalInSeconds(10)
                //   .RepeatForever())
                   //.ForJob(job)
                   .Build();

            scheduler.ScheduleJob(job, trigger);
           // scheduler.ScheduleJob(trigger);
            Thread.Sleep(TimeSpan.FromSeconds(100));

            scheduler.Shutdown();
        }
    }

    public class GJob :IJob
    {
        public void Execute(IJobExecutionContext context)
        {
            JobKey key = context.JobDetail.Key;
            JobDataMap dataMap = context.JobDetail.JobDataMap;

            Console.WriteLine($"Key = {key}, Service ID = {dataMap.GetString("ServiceId")}, Time={DateTime.Now}");
        }
    }
}
