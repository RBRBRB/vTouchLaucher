using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace vTouchLauncher
{

    public partial class Form1 : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public Form1()
        {
            InitializeComponent();
            //this.TransparencyKey = Color.White;
            //this.BackColor = Color.White;
            
            //this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;
            this.ShowInTaskbar = false;
            this.BackgroundImage = Properties.Resources.icon;
            this.TransparencyKey = Color.Magenta;
            this.BackColor = Color.Magenta;
            this.BackgroundImageLayout = ImageLayout.Center;
        }
        private void Form1_Load(object sender , EventArgs e)
        {


        }
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                
            }
        }
        private void panel1_MouseEnter(object sender, System.EventArgs e)
        {
            // Update the mouse event label to indicate the MouseEnter event occurred.
            Form2 newForm = new Form2();
            newForm.Show();
        }
        private void panel1_MouseLeave(object sender, System.EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.Show();
        }
    }
}
