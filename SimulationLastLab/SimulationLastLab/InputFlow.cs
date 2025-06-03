using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulationLastLab
{
    class InputFlow : Agent
    {
        public Bank bank { get; set; } // пришлось сделать public
        public double intensity { get; private set; }

        public InputFlow(Bank bank, int lambda)
        {
            this.bank = bank;
            this.intensity = lambda; // этого не хватало
        }

        private double generateNextArrival()
        {
            return -Math.Log(Model.getRND()) / intensity;
        }
        public override void processEvent(Event e)
        {
            bank.newClient(e.time);
            newEvent(e.time);
        }
        public void newEvent(double time)
        {
            Model.NewEvent(this, time + generateNextArrival());
        }
    }
}
