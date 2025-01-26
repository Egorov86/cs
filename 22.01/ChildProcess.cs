using System;
using System.Diagnostics;

namespace ChildProcessExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Настройка процесса
            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe"; // Исполняемый файл
            process.StartInfo.Arguments = "/c ping 127.0.0.1 -n 4"; // Команда для выполнения запроса себе же (пинг localhost)

            try //обработка исключений try/catch на случай если произойдёт ошибка
            {
                // Запуск процесса
                process.Start();
                // Ожидание завершения процесса
                process.WaitForExit();

                // Получаем код завершения
                int exitCode = process.ExitCode;
                Console.WriteLine($"Дочерний процесс завершен с кодом: {exitCode}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
            }
        }
    }
}
