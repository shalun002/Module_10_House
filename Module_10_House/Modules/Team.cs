using Module_10_House.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_10_House.Modules
{
    public class Team
    {
        public List<Worker> Workers { get; set; } = new List<Worker>();

        private Random rnd = new Random();

        public void GenerateWorkers()
        {
            for (int i = 0; i < rnd.Next(1, 10); i++)
            {
                Worker wr = new Worker()
                {
                    Name = i.ToString()
                };
                Workers.Add(wr);
            }
        }

        public void WorkJ(ref List<IPart> parts)
        {
            foreach (IPart item in parts)
            {
                if (item.StartWork == null)
                {
                    item.StartWork = DateTime.Now;
                    item.EndWork = DateTime.Now.AddDays(rnd.Next(1, 30));
                    Workers[rnd.Next(0, Workers.Count)].jobs.Add(item);
                    break;
                }
            }
        }
    }
}
