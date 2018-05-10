using Module_10_House.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_10_House.Modules
{
    public class TeamLeader : IWorker
    {
        public string Name { get; set; }
        public double Salary { get; set; }
        public bool IsTeam { get; set; } = true;
    }
}
