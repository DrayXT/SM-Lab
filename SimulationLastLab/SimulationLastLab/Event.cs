using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulationLastLab
{
    class Event
    {
        public Event(Agent agent, double time)
        {
            this.time = time;
            this.agent = agent;
        }
        public double time { get; set; }
        public Agent agent { get; set; }
    }
}
