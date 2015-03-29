using MathProCorporation.TaskManagerDatabase;

namespace MathProCorporation.Service
{
    public class TeamService : Service<Team>
    {
        public TeamService(CompanyContext context)
            : base(context)
        {
        }
    }
}