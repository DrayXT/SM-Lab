using System.Diagnostics;
using para_lab14;
using System.Data;

//var inputFlow = new InputFlow(new Bank(2));
//inputFlow.newEvent(0);
//Model.run(inputFlow.bank); // для ссылки пришлось сделать public bank

namespace para_lab14
{
    public partial class Form1 : Form
    {
        private const double SIMULATION_MAX_TIME = 100.0; // Максимальное время симуляции

        private InputFlow currentInputFlow; // Будем хранить текущий InputFlow

        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 10;
            serviceIntensity.Value = 2; // Устанавливаем начальное значение интенсивности обслуживания
            arrivalIntensity.Value = 2; 
            nOperators.Value = 3;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Выполняем один шаг симуляции
            bool simulationRunning = Model.StepSimulation(SIMULATION_MAX_TIME);

            if (!simulationRunning)
            {
                timer1.Stop();
                Debug.WriteLine("Симуляция завершена.");
                DisplayFinalStatistics(Model.GetFinalStatistics(), Model.Time);
            }

            currentClientCountLabel.Text = $"Кол-во клиентов: {Model.currentBankInstance.clientCount}";

            lQueue.Text = $"Очередь: {Model.currentBankInstance.clientQueue.Count}";

            currentTimeLabel.Text = $"Время: {Model.Time:F2}";
        }

        private void bStart_Click(object sender, EventArgs e)
        {
            // Очищаем DataGridView
            statisticsDataGridView.DataSource = null;
            statisticsDataGridView.Rows.Clear();
            statisticsDataGridView.Columns.Clear();
            maxTimeStateLabel.Text = "Самое долгое состояние:";
            double serviceIn = (double)serviceIntensity.Value; // Получаем интенсивность обслуживания из NumericUpDown
            double arrivalIn = (double)arrivalIntensity.Value;
            int numberOfOperators = 3;
            if (nOperators.Value > 0)
                numberOfOperators = (int)nOperators.Value;

            // Инициализация новой симуляции
            Bank bank = new Bank(serviceIn, numberOfOperators);
            currentInputFlow = new InputFlow(bank, arrivalIn);

            Model.InitializeSimulation(bank); // Инициализируем модель
            currentInputFlow.newEvent(0); // Запускаем первое событие прибытия

            timer1.Start();
        }

        private void bPause_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Stop();
                bPause.Text = "Resume";
            }
            else
            {
                timer1.Start();
                bPause.Text = "Pause";
            }
        }
        public void DisplayFinalStatistics(double[] statistics, double totalTime)
        {
            // Если этот метод будет вызван из другого потока (например, если симуляция в Task.Run),
            // то потребуется Invoke. Но так как он вызывается из simulationTimer_Tick,
            // который сам выполняется в UI-потоке, Invoke не нужен.
            // Однако, это хорошая практика для методов, которые могут быть вызваны из разных потоков.
            if (statisticsDataGridView.InvokeRequired)
            {
                statisticsDataGridView.Invoke(new Action(() => DisplayFinalStatistics(statistics, totalTime)));
                return;
            }

            DataTable dt = new DataTable();
            dt.Columns.Add("Кол-во клиентов", typeof(int));
            dt.Columns.Add("Доля времени", typeof(double));
            //dt.Columns.Add("Очередь (макс.)", typeof(int));
            //dt.Columns.Add("Занято операторов (макс.)", typeof(int));

            double maxProportion = 0.0;
            int stateWithMaxProportion = -1;

            for (int i = 0; i < statistics.Length; i++)
            {
                // Выводим только те строки, где есть какая-то статистика
                if (statistics[i] > 0 || i < 5)
                {
                    dt.Rows.Add(i, statistics[i]);
                }
                // Находим максимальную долю времени
                if (statistics[i] > maxProportion)
                {
                    maxProportion = statistics[i];
                    stateWithMaxProportion = i;
                }
            }

            statisticsDataGridView.DataSource = dt;

            // форматирование столбца
            if (statisticsDataGridView.Columns.Contains("Доля времени"))
            {
                statisticsDataGridView.Columns["Доля времени"].DefaultCellStyle.Format = "F4"; // 4 знака после запятой
            }
            statisticsDataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            if (stateWithMaxProportion != -1)
            {
                maxTimeStateLabel.Text = $"Самое долгое состояние: кол-во клиентов {stateWithMaxProportion} ({maxProportion:P2})"; // P2 для процентного формата
            }
            else
            {
                maxTimeStateLabel.Text = "Самое долгое состояние: Нет данных";
            }

            maxQueueLengthLabel.Text = $"Макс. длина очереди: {Model.MaxQueueLengthRecorded}";
            maxOperatorsLabel.Text = $"Макс. занятых операторов: {Model.MaxBusyOperatorsRecorded}";

        }
    }


    class Model
    {
        static public double Time { get; set; } = 0.0;
        public static Random random = new Random();
        static double[] statistics = new double[500];
        internal static Bank currentBankInstance;
        public static int MaxQueueLengthRecorded { get; private set; }
        public static int MaxBusyOperatorsRecorded { get; private set; }

        public static double getRND()
        {
            return random.NextDouble();
        }
        
        static PriorityQueue<Event, double> eventQueue = new PriorityQueue<Event, double>();

        internal static void NewEvent(Agent agent, double time)
        {
            Event e = new Event(agent, time);
            eventQueue.Enqueue(e, time);
        }

        internal static void InitializeSimulation(Bank bankInstance)
        {
            Time = 0;
            MaxQueueLengthRecorded = 0;
            MaxBusyOperatorsRecorded = 0;
            // Очищаем очередь событий и статистику для новой симуляции
            eventQueue.Clear();
            for (int i = 0; i < statistics.Length; i++)
            {
                statistics[i] = 0;
            }
            currentBankInstance = bankInstance; // Сохраняем ссылку на банк
        }

        internal static bool StepSimulation(double maxTime)
        {
            if (Time >= maxTime) // Условие завершения симуляции
            {
                if (Time > 0) // Избегаем деления на ноль, если симуляция не началась
                {
                    for (int i = 0; i < statistics.Length; i++)
                    {
                        statistics[i] /= Time; // Нормализуем статистику
                    }
                }
                return false; // Симуляция завершена
            }

            if (eventQueue.Count == 0) // Если событий больше нет, но время еще не вышло
            {
                Debug.WriteLine("Очередь событий пуста до достижения максимального времени.");
                return false;
            }

            var e = eventQueue.Dequeue();
            Debug.WriteLine(e.agent + " : " + e.time);

            // Накапливаем статистику
            statistics[currentBankInstance.clientCount] += e.time - Time;
            e.agent.processEvent(e);
            Time = e.time;

            MaxQueueLengthRecorded = Math.Max(MaxQueueLengthRecorded, currentBankInstance.clientQueue.Count);
            MaxBusyOperatorsRecorded = Math.Max(MaxBusyOperatorsRecorded, currentBankInstance.busyOperators);

            return true; // Симуляция продолжается
        }
        public static double[] GetFinalStatistics()
        {
            return statistics;
        }

        /*internal static void run(Bank bankInstance) // добавили ссылку на банк
        {
            Time = 0;
            while (Time < 100)
            {
                var e = eventQueue.Dequeue();
                Debug.WriteLine(e.agent + " : " + e.time);
                statistics[bankInstance.clientCount] += e.time - Time; // ссылка на банк есть
                e.agent.processEvent(e);
                Time = e.time;
            }

            for (int i = 0; i < statistics.Count(); i++)
            {
                //if (statistics[i] != 0)
                //{
                    statistics[i] /= Time;
                    Debug.WriteLine($"Клиентов {i} - {statistics[i]}");
                //}
            }
        }*/
    }

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

    abstract class Agent
    {
        //public abstract string Name { get; }
        public abstract void processEvent(Event e);
    }

    class InputFlow : Agent
    {
        public Bank bank { get; set; } // пришлось сделать public
        public double intensity { get; private set; }

        public InputFlow(Bank bank, double arrivalIntensity)
        {
            this.bank = bank;
            this.intensity = arrivalIntensity;
        }

        private double generateNextArrival()
        {
            //return -Math.Log(Model.random.NextDouble()) / intensity; // две точки нехорошо
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

    class Bank : Agent
    {
        public int clientCount { get; set; }
        public double intensity { get; private set; }
        public int totalOperators { get; private set; }
        public int busyOperators { get; private set; }

        // Очередь для клиентов, которые ждут свободного оператора
        // Мы не храним сами объекты клиентов, так как они не имеют состояния,
        // но можем использовать int для отслеживания их количества
        public Queue<int> clientQueue;

        public Bank (double intensity, int totalOperators)
        {
            this.intensity = intensity;
            this.totalOperators = totalOperators;
            this.busyOperators = 0; // Изначально все операторы свободны
            this.clientCount = 0; // Изначально клиентов нет
            this.clientQueue = new Queue<int>(); // Инициализация очереди
        }
        public override void processEvent(Event e)
        {
            // Событие ProcessEvent означает, что оператор закончил обслуживание клиента
            busyOperators--; // Освобождаем оператора
            clientCount--; // Уменьшаем общее количество клиентов в банке
            Debug.WriteLine($"Время: {e.time:F2}, Клиент обслужен. Занято операторов: {busyOperators}, В очереди: {clientQueue.Count}");

            //if (clientCount > 0) newEvent(e.time);

            if (clientQueue.Count > 0 && busyOperators < totalOperators)
            {
                clientQueue.Dequeue(); // Удаляем клиента из очереди
                busyOperators++; // Занимаем оператора
                newEvent(e.time); // Планируем новое событие обслуживания для этого клиента
            }
        }
        
        internal void newClient(double arrivalTime)
        {
            /*if (clientCount == 0)
            {
                clientCount++;
                newEvent(time);
            }
            else clientCount++;*/

            clientCount++; // Увеличиваем общее количество клиентов в банке

            Debug.WriteLine($"Время: {arrivalTime:F2}, Новый клиент прибыл. Всего клиентов: {clientCount}");

            // Если есть свободный оператор
            if (busyOperators < totalOperators)
            {
                busyOperators++; // Занимаем оператора
                newEvent(arrivalTime); // Планируем событие завершения обслуживания для этого клиента
            }
            else
            {
                clientQueue.Enqueue(1); // Добавляем "единицу" в очередь, чтобы просто отметить наличие клиента
                Debug.WriteLine($"Время: {arrivalTime:F2}, Клиент встал в очередь. Текущая очередь: {clientQueue.Count}");
            }
        }
        public void newEvent(double time)
        {
            Model.NewEvent(this, time + generateNextArrival());
        }
        private double generateNextArrival()
        {
            //return -Math.Log(Model.random.NextDouble()) / intensity; // две точки нехорошо
            return -Math.Log(Model.getRND()) / intensity;
        }
    }
}

