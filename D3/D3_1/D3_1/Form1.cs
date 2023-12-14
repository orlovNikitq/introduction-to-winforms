using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D3_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Load += res;
        }
        private void res(object sender, EventArgs e)
        {
            string[] resume = { "Меня зовут Никита", "Я учусь", "мне 16" };
            int avr = resume.Sum(s => s.Length) / resume.Length;
            MessageBox.Show(resume[0]);
            MessageBox.Show(resume[1]);
            MessageBox.Show(resume[2]);
            MessageBox.Show($"{avr}");
            Application.Exit();

        }
    }
}
