using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vTouchLauncher
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void cross_click(object sender , EventArgs e)
        {
            close.Start();
        }

        private void Form2_Load_1(object sender, EventArgs e)
        {
            this.Top = 30;
            this.Left = Screen.PrimaryScreen.Bounds.Width - this.Width - 60;
        }

        private void timeout_Tick(object sender, EventArgs e)
        {
            close.Start();
        }
        int interval = 0;
        private void show_Tick(object sender, EventArgs e)
        {
            if(this.Top < 60)
            {
                this.Top += interval;
                interval += 2;
            }
            else
            {
                show.Stop();
            }
        }

        private void close_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0)
                this.Opacity -= 0.2;
            else
                this.Close();
        }
    }
}
