using System;
using System.Drawing;
using System.Windows.Forms;

namespace Uian
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (button1.Width < 250)
            {
                button1.Width += 4;
                button1.Height += 2;
                var ll = new Point(button1.Location.X - 2, button1.Location.Y - 1);
                button1.Location = ll;
            }
            else
            {
                timer1.Stop();
                if (!_flag)
                    timer2.Start();
            }
        }

        private bool _flag;
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (button1.Width > 200)
            {
                button1.Width -= 4;
                button1.Height -= 2;
                var ll = new Point(button1.Location.X + 2, button1.Location.Y + 1);
                button1.Location = ll;
            }
            else
            {
                timer2.Stop();
                timer1.Start();
                _flag = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _flag = false;
            button1.Width = 75;
            button1.Height = 23;
            button1.Location = new Point(381, 188);
            timer1.Start();
        }
    }
}
