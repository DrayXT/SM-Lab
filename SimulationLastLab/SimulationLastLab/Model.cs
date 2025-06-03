using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace SimulationLastLab
{
    internal class Model
    {
        public static Random random = new Random();

        public static double getRND()
        {
            return random.NextDouble();
        }


        static SortedList<double, Event> eventQueue = new SortedList<double, Event>();

        internal static void NewEvent(Agent agent, double time)
        {
            Event e = new Event(agent, time);
            eventQueue.Add(time, e); // Key = время (приоритет), Value = событие
        }

        public static Event getEvent()
        {
            var e = eventQueue.Values[0];
            eventQueue.RemoveAt(0);
            return e;
        }
    }
}
