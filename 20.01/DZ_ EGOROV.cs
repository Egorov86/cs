using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MessageBoxExample
{
    public partial class MainForm : Form
    {
        // Импортируем функцию MessageBox из User32.dll
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int MessageBox(IntPtr hWnd, String text, String caption, int options);

        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonShowInfo_Click(object sender, EventArgs e)
        {
            // Отображаю информацию о себе в нескольких MessageBox
            MessageBox(this.Handle, "Добрый вечер! Меня зовут Евгений.", "я из г.Магнитогорска", 0);
            MessageBox(this.Handle, "Я увлекаюсь гонками с препядствиями.", "Бегом по горным местностям", 0);
            MessageBox(this.Handle, "Я люблю слушать спокойную музыку.", "Люблю фильмы ужасов", 0);
            MessageBox(this.Handle, "Мне 38 лет", "Спасибо за ваше внимание!", 0);
        }
    }
}
