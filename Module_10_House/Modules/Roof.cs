using Module_10_House.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_10_House.Modules
{
    public class Roof : IPart
    {
        public string Name { get; set; }
        public DateTime StartWork { get; set; }
        public DateTime EndWork { get; set; }
        public string Material { get; set; }
        public int Priority { get; set; }
    }
}
