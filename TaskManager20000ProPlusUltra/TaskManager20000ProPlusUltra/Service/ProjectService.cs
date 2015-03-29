using MathProCorporation.TaskManagerDatabase;

namespace MathProCorporation.Service
{
    public class ProjectService : Service<Project>
    {
        public ProjectService(CompanyContext context)
            : base(context)
        {
        }
    }
}