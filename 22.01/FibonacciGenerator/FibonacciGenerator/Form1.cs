using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FibonacciGenerator
{
    public partial class Form1 : Form
    {
        private Thread fibonacciThread;
        private volatile bool running = false; // Переменная для контроля потока

        public Form1()
        {
            InitializeComponent();
        }
        // Метод запуска генерации чисел Фибоначчи
        private void StartFibonacciGeneration(int lower, int upper)
        {
            List<int> fibonacciNumbers = new List<int> { 0, 1 }; // Список для хранения чисел Фибоначчи

            while (running)
            {
                int next = fibonacciNumbers[fibonacciNumbers.Count - 1] + fibonacciNumbers[fibonacciNumbers.Count - 2];

                // Проверка верхней границы
                if (upper != -1 && next > upper)
                {
                    break;
                }

                // Добавляем число Фибоначчи в список, если оно больше или равно нижней границе
                if (next >= lower)
                {
                    listBoxFibonacci.Invoke((MethodInvoker)delegate {
                        listBoxFibonacci.Items.Add(next);
                    });
                }

                fibonacciNumbers.Add(next);
                Thread.Sleep(400); // Задержка для визуализации пол секунды
            }
        }

        // Обработчик события для кнопки "Начать"
        private void buttonStart_Click(object sender, EventArgs e)
        {
                if (fibonacciThread != null && fibonacciThread.IsAlive)
                {
                    MessageBox.Show("Генерация уже запущена.");
                    return;
                }
                // lower и upper делаем тернарником
                int lower = string.IsNullOrWhiteSpace(textBoxLower.Text)
                    ? 2
                    : int.Parse(textBoxLower.Text);

                int upper = string.IsNullOrWhiteSpace(textBoxUpper.Text)
                    ? -1
                    : int.Parse(textBoxUpper.Text);

                running = true; // Запускаем поток
                fibonacciThread = new Thread(() => StartFibonacciGeneration(lower, upper));
                fibonacciThread.Start();
            }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            running = false; // Останавливаем поток
            fibonacciThread = null; // Обнуляем поток
        }
    }
}
