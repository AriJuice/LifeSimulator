using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeSimulator
{
    internal class Job
    {
        public string JobName { get; set; }
        public int Index { get; set; }

        public Job(string jobName, int index)
        {
            JobName = jobName;
            Index = index;
        }

    }
}
