namespace tasker
{
    public static class TaskFactory
    {
        public static TaskBase CreateTask(string name, string description, string deadline, int priority)
        {
            return new TaskModel
            {
                Name = name,
                Description = description,
                Deadline = deadline,
                Priority = priority
            };
        }
    }
}

