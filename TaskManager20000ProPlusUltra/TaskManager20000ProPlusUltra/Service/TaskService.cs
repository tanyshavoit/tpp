using MathProCorporation.TaskManagerDatabase;

namespace MathProCorporation.Service
{
    public class TaskService : Service<Task>
    {
        public TaskService(CompanyContext context)
            : base(context)
        {
        }
    }
}