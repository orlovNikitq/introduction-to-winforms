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

namespace D3_2
{
    public partial class Form1 : Form
    {
        private int count = 0;
        public Form1()
        {
            InitializeComponent();
            Load += ran;
        }
        private void ran(object sender, EventArgs e)
        {
            Random random = new Random();
            
            int rand = random.Next(1, 10);
            if (MessageBox.Show("Вашим числом является: " + rand + "?", "Результат", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show(count.ToString());
            }
            else
            {
                count++; 
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ran(sender, e);
        }
    }
}
