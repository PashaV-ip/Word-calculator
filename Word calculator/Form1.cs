using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Abstractions;

namespace Word_calculator
{
    public partial class WordCalculator : Form
    {
        static DateTime dateTime = DateTime.Now;
        StreamWriter writFileLog, writeFileResult;
        string nameLog = $@"logs {dateTime.ToShortDateString()}.txt";
        string nameResult = @"Results\result.txt";
        int numClickButtonConnect;
        public WordCalculator()
        {
            InitializeComponent();
        }

        private void connect_Click(object sender, EventArgs e)
        {
            if (firstWord.Text == "" || secondWord.Text == "")
            {
                MessageBox.Show("Вы оставили поле пустым!", "Ошибка..", MessageBoxButtons.OK, MessageBoxIcon.Error);
                numClickButtonConnect++;
                writFileLog = new StreamWriter(nameLog, true);
                dateTime = DateTime.Now;
                writFileLog.WriteLine($"[{dateTime.ToShortTimeString()}] - Пользователь не заполнил поля и получил сообщение об ошибке");
                writFileLog.Close();
            }
            else
            {
                numClickButtonConnect++;
                resultWord.Text = firstWord.Text + secondWord.Text;
                writeFileResult = new StreamWriter(nameResult, true);
                writFileLog = new StreamWriter(nameLog, true);
                dateTime = DateTime.Now;
                writeFileResult.WriteLine($"[{dateTime.ToShortTimeString()}] - При сложении: {firstWord.Text} и {secondWord.Text} = {resultWord.Text}");
                writFileLog.WriteLine($"[{dateTime.ToShortTimeString()}] - Произведено сложение слов: {firstWord.Text} и {secondWord.Text}");
                writFileLog.Close();
                writeFileResult.Close();
            }
        }

        private void WordCalculator_Load(object sender, EventArgs e)
        {
            numClickButtonConnect = 0;
            //resultWord.Text = nameLog;
            writFileLog = new StreamWriter(nameLog, true);
            writeFileResult = new StreamWriter(nameResult, true);
            dateTime = DateTime.Now;
            writFileLog.WriteLine($"Начало сеанса в: {dateTime.ToShortTimeString()}");
            writFileLog.Close();
            writeFileResult.Close();
        }

        private void WordCalculator_FormClosing(object sender, FormClosingEventArgs e)
        {
            writFileLog = new StreamWriter(nameLog, true);
            dateTime = DateTime.Now;
            writFileLog.WriteLine($"За сеанс пользователь нажал на кнопку: {numClickButtonConnect} раз(а).");
            writFileLog.WriteLine($"Конец сеанса в: {dateTime.ToShortTimeString()}\n" +
                $"________________________________________________");
            writFileLog.Close();
            FileInfo fileInfo = new FileInfo(@"Results\result.txt");
            string newNameResult = $@"Results\result {dateTime.ToString($"hh.mm.ss")} {dateTime.ToShortDateString()}.txt";
            fileInfo.MoveTo(newNameResult);
        }

        private void firstWord_TextChanged(object sender, EventArgs e)
        {
            writFileLog = new StreamWriter(nameLog, true);
            dateTime = DateTime.Now;
            writFileLog.WriteLine($"[{dateTime.ToShortTimeString()}] - Изменение в первом поле: {firstWord.Text}");
            writFileLog.Close();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            firstWord.Text = "";
            secondWord.Text = "";
            resultWord.Text = "";
        }

        private void secondWord_TextChanged(object sender, EventArgs e)
        {
            writFileLog = new StreamWriter(nameLog, true);
            dateTime = DateTime.Now;
            writFileLog.WriteLine($"[{dateTime.ToShortTimeString()}] - Изменение во втором поле: {secondWord.Text}");
            writFileLog.Close();
        }
    }
}
