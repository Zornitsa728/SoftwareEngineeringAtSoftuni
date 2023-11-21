namespace P04.Recharge
{
    public abstract class Worker : IWorker, ISleeper, IRechargeable
    {
        public Worker(string id)
        {
            Id = id;
        }

        public string Id {get; private set;}

        public int WorkingHours { get; private set; }

        public void Work(int hours)
        {
            WorkingHours += hours;
        }

        public abstract void Sleep();

        public abstract void Recharge();
    }
}