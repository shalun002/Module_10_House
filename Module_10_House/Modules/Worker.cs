using Module_10_House.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_10_House.Modules
{
    public class Worker : IWorker
    {
        public string Name { get; set; }
        public double Salary { get; set; }
        public bool IsTeam { get; set; } = false;
        public List<IPart> jobs { get; set; } = new List<IPart>();
        public void PrintReport(List<IPart> parts)
        {
            foreach (IPart item in parts.OrderBy(o => o.Priority))
            {
                Console.WriteLine("Name : {0} Start: {1} End : {2}", item.Name, item.StartWork, item.EndWork);
            }
        }
    }
}
