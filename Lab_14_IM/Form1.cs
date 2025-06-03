using System;
using System.Windows.Forms;

namespace Lab_14
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        // Параметры
        private double lambda, mu, currentTime; // Интенсивность потока клиентов, интенсивность обслуживания, текущее время
        private int queue, busy, served, n; // Очередь, занятые консультанты, обслуженные клиенты, количество консультантов
        private readonly Random random = new Random();

        // Генерация случайного времени по экспоненциальному распределению
        private double ExpRandomValue(double rate)
        {
            return -Math.Log(random.NextDouble()) / rate; // Формула экспоненциального распределения
        }

        // Определение следующего события в системе
        private double NextEventTime(double currentTime)
        {
            double nextArrival = ExpRandomValue(lambda); // Время до следующего прибытия клиента
            double nextService = (busy > 0) ? ExpRandomValue(mu * busy) : double.MaxValue; // Время до окончания обслуживания

            // Определяем какое событие наступит раньше - приход клиента или окончание обслуживания
            if (nextArrival < nextService)
            {
                // Если пришел новый клиент
                if (busy < n)
                    busy++; // Если есть свободный консультант - занять его
                else
                    queue++; // Иначе добавить клиента в очередь

                return currentTime + nextArrival; // Возвращаем новое время (текущее + время до прихода)
            }
            else
            {
                // Если завершилось обслуживание
                if (queue > 0)
                    queue--; // Если есть очередь - взять следующего клиента
                else
                    busy--; // Иначе освободить консультанта
                served++; // Cчетчик обслуженных клиентов
                return currentTime + nextService; // Возвращаем новое время (текущее + время обслуживания)
            }
        }

        public void UpdateView()
        {
            // Обновление интерфейса
            ServeLabel.Text = served.ToString(); // Количество обслуженных клиентов
            QueueLabel.Text = queue.ToString(); // Текущая длину очереди
            TimeLabel.Text = Math.Round(currentTime, 2).ToString(); // Текущее время

            // Очистка и настройка таблицы для отображения состояния
            stateGridView.Rows.Clear();
            stateGridView.ColumnCount = 2;
            stateGridView.Columns[0].HeaderText = "Косультант"; // Заголовок первого столбца
            stateGridView.Columns[1].HeaderText = "Клиент"; // Заголовок второго столбца

            // Отображение состояния консультантов
            for (int i = 0; i < n; i++)
            {
                stateGridView.Rows.Add(); // Добавление строки
                stateGridView.Rows[i].Cells[0].Value = "Косультант " + Convert.ToString(i + 1); // Номер консультанта
                stateGridView.Rows[i].Cells[1].Value = (i < busy) ? "Занят" : "Свободен"; // Состояние (Занят/Свободен)
            }

            // Отображение клиентов в очереди
            for (int i = 0; i < queue; i++)
            {
                stateGridView.Rows.Add();
                stateGridView.Rows[n + i].Cells[1].Value = "В очереди"; // Отметка "В очереди"
            }
        }

        // Обработчик тика таймера (обновление состояния системы)
        private void Timer_Tick(object sender, EventArgs e)
        {
            currentTime = NextEventTime(currentTime); // Переход к следующему событию
            UpdateView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Timer.Enabled)
            {
                lambda = (double)ClientFlow.Value;
                mu = (double)ServiceIntensity.Value;
                n = (int)NumOfConsultants.Value;
                Timer.Start();
            }
            else
                Timer.Stop();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            queue = 0; busy = 0; served = 0; currentTime = 0;
            UpdateView();
            Timer.Stop();
        }
    }
}