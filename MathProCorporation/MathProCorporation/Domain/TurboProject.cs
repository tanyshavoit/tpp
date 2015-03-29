using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using MathProCorporation.Domain.StatusAvailable;

namespace MathProCorporation.Domain
{
    public class TurboProject
    {
        public string ProjectId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public TurboStatus Status { get; set; }

        public TurboClient Client { get; set; }

        public TurboManager Manager { get; set; }

        public TurboTeam Team { get; set; }

        public List<TurboTask> CurrentTasks { get; set; }

        public List<TurboTask> CompletedTasks { get; set; }

        public DateTime Deadline { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }
    }
}