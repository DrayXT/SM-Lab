using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulationLastLab
{
    class Bank : Agent
    {
        public int operators;
        public int busyOperators = 0;
        public int clientCount { get; set; }
        public double intensity { get; private set; }
        public Bank(double intensity, int opers)
        {
            this.intensity = intensity;
            this.operators = opers;
        }
        public override void processEvent(Event e)
        {
            if (busyOperators > 0)
            {
                busyOperators--;  // освобождаем оператора только если он был занят
            }

            if (clientCount > 0)
            {
                clientCount--;  // уменьшаем счетчик клиентов только если они есть
            }

            // Если есть клиенты в очереди и свободные операторы, создаем новое событие
            if (clientCount > busyOperators && busyOperators < operators)
            {
                busyOperators++;  // занимаем оператора
                newEvent(e.time);
            }
        }

        internal void newClient(double time)
        {
            clientCount++;
            if (clientCount <= operators)
            {
                busyOperators++;
                newEvent(time);
            }
        }
        public void newEvent(double time)
        {
            Model.NewEvent(this, time + generateNextArrival());
        }
        private double generateNextArrival()
        {
            return -Math.Log(Model.getRND()) / intensity;
        }

        public int getClients()
        {
            return clientCount;
        }
    }
}
