using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_10_House.Modules
{
    public class Stroika
    {
        public void StartSt()
        {
            House house = new House();
            house.CreateHousePlan();

            Team team = new Team();
            team.GenerateWorkers();

            while (house.PartsHouse.Count(c=>c.StartWork == null) > 0)
            {
                team.WorkJ(ref house.PartsHouse);
            }
        }
    }
}
