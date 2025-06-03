namespace SimulationLastLab
{
    public class QueueClient
    {
        public int countClients { get; private set; }  
        
        public QueueClient()
        {
            countClients = 0;
        }
        
        public void addClient()
        {
            countClients++;
        }

        public void removeClient()
        {
            countClients--;
        }
    }
}