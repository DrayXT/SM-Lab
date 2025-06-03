using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SimulationLastLab
{
    public partial class Form1 : Form
    {
        private int maxClients = 0;
        private InputFlow flow;
        private double Time = 0;
        private Random random = new Random();
        private Dictionary<int,double> counter = new Dictionary<int,double>();
        private Dictionary<int, double> stats = new Dictionary<int,double>();
        //private double[] counter = new double[50];
        //private double[] stats = new double[50];
        private SortedList<double, Event> eventQueue = new SortedList<double, Event>();
        private bool isStart = false;

        public Form1()
        {
            InitializeComponent();
            labelMaxClients.Text = string.Empty;
            labelAllTime.Text = string.Empty;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (!isStart)
            {
                int lambdaBank = (int)num_IntBank.Value;
                int operators = (int)num_CountOperators.Value;
                int lambdaFlow = (int)num_IntFlow.Value;
                flow = new InputFlow(new Bank(lambdaBank, operators), lambdaFlow);
                flow.newEvent(Time);
                timer1.Start();
                isStart = true;
            }
            else
            {
                timer1.Stop();
                isStart = false;


                for (int i = 0; i < counter.Count(); i++)
                {
                    stats.Add(i, counter[i] / Time);
                    DataPoint dataPoint = new DataPoint(i, stats[i]);
                    dataPoint.AxisLabel = $"{i}";
                    chart1.Series[0].Points.Add(dataPoint);
                }
                if (maxClients - flow.bank.operators < 0) maxClients = 0;
                else maxClients -= flow.bank.operators;
                labelMaxClients.Text = $"Максимум клиентов в очереди: {maxClients}";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var ev = Model.getEvent();
            //Debug.WriteLine(ev.agent + " : " + ev.time);
            if (maxClients < flow.bank.clientCount) maxClients = flow.bank.clientCount;
            if (!counter.ContainsKey(flow.bank.clientCount)) counter.Add(flow.bank.clientCount, 0);
            counter[flow.bank.clientCount] += ev.time - Time; // ссылка на банк есть
            ev.agent.processEvent(ev);
            Time = ev.time;
            labelBusyOper.Text = $"Занятых операторов: {flow.bank.busyOperators}";
            labelClients.Text = $"Клиентов: {flow.bank.clientCount}";
            labelAllTime.Text = $"Общее время моделирования: {Math.Round(Time, 3)}";
        }

        private void run(Bank bankInstance) // добавили ссылку на банк
        {
            Time = 0;
            while (true)
            {
                var e = Model.getEvent();
                eventQueue.RemoveAt(0);
                Debug.WriteLine(e.agent + " : " + e.time);
                stats[bankInstance.clientCount] += e.time - Time; // ссылка на банк есть
                e.agent.processEvent(e);
                Time = e.time;
            }
        }
    }
}
