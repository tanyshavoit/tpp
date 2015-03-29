using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MathProCorporation.Domain
{
    public class TurboTeam
    {
        public string TeamId { get; set; }

        public TurboManager Manager { get; set; }

        public List<TurboEmployee> Employees { get; set; }

        public List<TurboProject> Projects { get; set; }
    }
}