using System;

namespace tasker
{
    public abstract class TaskBase
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Deadline { get; set; }
        public int Priority { get; set; }

        public abstract void DisplayDetails();
    }

    public class TaskModel : TaskBase
    {
        public override void DisplayDetails()
        {
            Console.WriteLine($"Task: {Name}, Description: {Description}, Deadline: {Deadline}, Priority: {Priority}");
        }
    }
}


//namespace tasker
//{
//    public class TaskModel
//    {
//        public string Name { get; set; }
//        public string Description { get; set; }
//        public string Deadline { get; set; }
//        public int Priority { get; set; }
//    }
//}

