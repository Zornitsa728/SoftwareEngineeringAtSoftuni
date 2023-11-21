namespace P04.Recharge
{
    using System;

    public class Employee : ISleeper
    {
        IWorker worker;
        public Employee(IWorker worker)
        {
            this.worker = worker;
        }
        
        public void Sleep()
        {
            // sleep...
        }
    }
}
