namespace SimulationLastLab
{
    public class Client
    {
        public static int idClient = 0;
        private double inTime;
        private double outTime;

        public Client(double inTime, double outTime)
        {
            this.inTime = inTime;
            this.outTime = outTime;
        }
    }
}