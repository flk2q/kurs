using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace TaskManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Process[] procs;
        private void GetProcesses()
        {
            procs = Process.GetProcesses();
            if (Convert.ToInt32(label2.Text) != procs.Length) // Проверяем, были ли запущены или завершены новые процессы
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("ID Процесса"+
                       "    \t    \t      \t Ответ процесса: " +
                       " \t   \t   \t         Объем выделяемой памяти в " + " байтах" +
                       " \t   \t   \t Имя процесса: ");
                for (int i = 0; i < procs.Length; i++)
                {
                    listBox1.Items.Add((i+1)+") " + procs[i].Id + 
                        "          \t    \t    | \t \t " +procs[i].Responding +
                        "          \t    \t    | \t \t " + procs[i].WorkingSet64 + 
                        "          \t    \t    | \t \t " + procs[i].ProcessName);
                    // Добавить имя процесса в список
                    
                    //listBox1.Items.Add(procs[i].Id);
                    // listBox1.Items.Add(procs[i].WorkingSet64);
                }
                label2.Text = procs.Length.ToString();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            GetProcesses();
        }

        // Проверяем каждую секунду  изменениями в списке процессов
        private void timer1_Tick(object sender, EventArgs e)
        {
            GetProcesses();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            DialogResult result = MessageBox.Show(
          "Завершить данный процесс?",
          "Предупреждение",
          MessageBoxButtons.YesNo,
          MessageBoxIcon.Information,
          MessageBoxDefaultButton.Button1,
          MessageBoxOptions.DefaultDesktopOnly);

            if (result == DialogResult.Yes)
                 procs[listBox1.SelectedIndex-1].Kill(); // Завершаем процесс, соответствующий выбранному индексу в списке;

           
        }

        private void kIllProcessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            procs[listBox1.SelectedIndex-1].Kill();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            listBox1.SelectedItems.Clear();
            for (int i = listBox1.Items.Count - 1; i >= 0;i--)
            {
                if (listBox1.Items[i].ToString().ToLower().Contains(txtsearch.Text.ToLower()))
                    listBox1.SetSelected(i, true);

            }
            DialogResult result = MessageBox.Show(
         "Найдено результатов поиска: " + listBox1.SelectedItems.Count.ToString(),
         "Поиск завершен",
         MessageBoxButtons.OKCancel,
         MessageBoxIcon.Information,
         MessageBoxDefaultButton.Button1,
         MessageBoxOptions.DefaultDesktopOnly);
           // label3.Text = "Найдено результатов поиска: "+ listBox1.SelectedItems.Count.ToString();
               }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}

