using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_10_House.Interface
{
    interface IWorker
    {
        string Name  { get; set; }
        double Salary { get; set; }
        bool IsTeam { get; set; }
    }
}
