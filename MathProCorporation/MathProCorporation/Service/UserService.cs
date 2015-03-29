using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using MathProCorporation.Models;
using MathProCorporation.TaskManagerDatabase;

namespace MathProCorporation.Service
{
    public class UserService : Service<ApplicationUser>
    {
        public UserService(CompanyContext context)
            : base(context)
        {
            UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new CompanyContext()));
        }

        internal UserManager<ApplicationUser> UserManager { get; private set; }

        public ApplicationUser FindUserById(string id)
        {
            return UserManager.FindById(id);
        }
    }
}