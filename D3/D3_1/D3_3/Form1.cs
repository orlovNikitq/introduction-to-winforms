using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D3_3
{
    public partial class Form1 : Form
    {
        private Rectangle rectangle;

        public Form1()
        {
            InitializeComponent();

            rectangle = new Rectangle(10, 10, this.ClientSize.Width - 2 * 10, this.ClientSize.Height - 2 * 10);

             MouseMove += Form1_MouseMove2;
             MouseClick += MainForm_MouseClick;
             MouseMove += Form1_MouseMove;
        }
        private void Form1_MouseMove2(object sender, MouseEventArgs e)
        {
            if (Control.ModifierKeys == Keys.Control && e.Button == MouseButtons.Left)
            {
                this.Close();
            }
        }


        private void MainForm_MouseClick(object sender, MouseEventArgs e)
        {
            Point clickPoint = e.Location;

            if (e.Button == MouseButtons.Left)
            {
                if (rectangle.Contains(clickPoint))
                {
                    MessageBox.Show("Точка внутри прямоугольника");
                }
                else if (IsNearRectangleBorder(clickPoint, 3))
                {
                    MessageBox.Show("Точка рядом с границей прямоугольника");
                }
                else
                {
                    MessageBox.Show("Точка снаружи прямоугольника");
                }
                 
            }
            else if (e.Button == MouseButtons.Right)
            {
                MessageBox.Show($"Ширина = {ClientSize.Width}, Высота = {ClientSize.Height}");
            }
        }


        private bool IsNearRectangleBorder(Point point, int distance)
        {
            Rectangle expandedRectangle = new Rectangle(
                rectangle.Left - distance,
                rectangle.Top - distance,
                rectangle.Width + 2 * distance,
                rectangle.Height + 2 * distance
            );

            return expandedRectangle.Contains(point) && !rectangle.Contains(point);
        }

        protected override void OnPaint(PaintEventArgs e)
        {

            e.Graphics.DrawRectangle(new Pen(Color.Black, 3), rectangle);
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = $"Координаты мыши: X = {e.X}, Y = {e.Y}";
        }
      
    }
}

