using System;
using System.Threading;

namespace ClockFunc
{
    // 声明一个委托类型，定义事件处理函数的格式
    public delegate void ClockHandler(object sender, DateTime dateTime);

    public class Clock
    {
        // 定义事件，相当于创建一个委托实例
        public event ClockHandler clockHandler;
        private DateTime clockTime;     // 闹钟响铃时间

        public Clock(DateTime clockTime)
        {
            this.clockTime = clockTime;
        }

        public void Start()     // 启动闹钟
        {
            while(true)
            {
                clockHandler(this, clockTime);
                Thread.Sleep(1000);
            }
        }
    }

    public class ClockSimulation
    {
        public Clock clock;
        public ClockSimulation(DateTime dateTime)
        {
            clock = new Clock(dateTime);
            clock.clockHandler += Tick;
            clock.clockHandler += Alarm;
        }

        public void Tick(object sender, DateTime dateTime)
        {
            if (!(DateTime.Now.Hour == dateTime.Hour && DateTime.Now.Minute == dateTime.Minute))
                Console.WriteLine("tick");
        }

        public void Alarm(object sender, DateTime dateTime)
        {
            if (DateTime.Now.Hour == dateTime.Hour && DateTime.Now.Minute == dateTime.Minute)
                Console.WriteLine("ring");
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            ClockSimulation simulateClock = 
                new ClockSimulation(new DateTime(2020, 3, 13, 18, 00, 00));     // 设置闹钟响铃时间
            simulateClock.clock.Start();
        }
    }
}
