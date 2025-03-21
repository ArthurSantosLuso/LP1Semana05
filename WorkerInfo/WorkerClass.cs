using System;

namespace WorkerInfo
{
    public class WorkerClass
    {
        public WorkerClass()
        {
            Id = 0;
            Name = "";
            Job = "";
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Job { get; set; }
    }
}
