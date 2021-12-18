using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoWaterFarmer
{
    public partial class Form1 : Form
    {
        private Point mousePos1 = new Point();
        private Point mousePos2 = new Point();

        private Point hotbarTopLeft = new Point();
        private Point hotbarBottomRight = new Point();

        [DllImport("user32.dll")]
        static extern bool GetCursorPos(ref Point lpPoint);

        [DllImport("user32.dll",CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, uint dwExtraInfo);
        const uint KEYEVENTF_KEYUP = 0x0002;
        const uint KEYEVENTF_EXTENDEDKEY = 0x0001;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Thread.Sleep(3000);
            SendKeys.Send("1");
        }

        private void tmrMouse_Tick(object sender, EventArgs e)
        {
            Point p = new Point();

            GetCursorPos(ref p);

            lblMouse.Text = p.ToString();
        }

        private void btnPossitions_Click(object sender, EventArgs e)
        {
            mousePos1.X = Convert.ToInt32(tbx1x.Text);
            mousePos1.Y = Convert.ToInt32(tbx1y.Text);
            mousePos2.X = Convert.ToInt32(tbx2x.Text);
            mousePos2.Y = Convert.ToInt32(tbx2y.Text);

            hotbarTopLeft.X = Convert.ToInt32(tbxHbTLX.Text);
            hotbarTopLeft.Y = Convert.ToInt32(tbxHbTLY.Text);
            hotbarBottomRight.X = Convert.ToInt32(tbxHbBRX.Text);
            hotbarBottomRight.Y = Convert.ToInt32(tbxHbBRY.Text);

            Thread.Sleep(2000);

            farmWater();

        }

        public void farmWater()
        {
            for(int i = 0; i < 2; i++)
            {

                SendKeys.Send("1");

                for (int x = 0; x < 10; x++)
                {
                    leftClick();
                    Thread.Sleep(25);
                }

                SendKeys.Send("E");
                Thread.Sleep(100);
                craftClearWater();
                Thread.Sleep(100);
                prepareHotbar();
                Thread.Sleep(100);
                SendKeys.Send("E");
            }
        }

        public void prepareHotbar()
        {
            int posY = hotbarBottomRight.Y - hotbarTopLeft.Y + hotbarTopLeft.Y;

            int posX = (int) Math.Floor((hotbarBottomRight.X - hotbarTopLeft.X) / 18d) + hotbarTopLeft.X;

            Cursor.Position = new Point(posX, posY);

            shiftKlick();
            SendKeys.Send("2");
        }

        public void craftClearWater()
        {
            for (int i = 0;i < 10; i++)
            {
                Cursor.Position = mousePos1;
                Thread.Sleep(100);
                SendKeys.Send(Convert.ToString(i+1));
                Thread.Sleep(100);

                Cursor.Position = mousePos2;
                Thread.Sleep(100);

                shiftKlick();
                Thread.Sleep(100);
            }
        }

        public void rightClick()
        {
            mouse_event(0x0004, 0, 0, 0, 0);
            mouse_event(0x0002, 0, 0, 0, 0);
        }

        public void leftClick()
        {
            mouse_event(0x0008, 0, 0, 0, 0);
            mouse_event(0x0010, 0, 0, 0, 0);
        }

        public void shiftKlick()
        {
            pressShift();
            Thread.Sleep(100);
            rightClick();
            Thread.Sleep(100);
            releaseShift();
        }

        public void pressShift()
        {
            keybd_event((byte)0x10, 0x2A, 1, 0);
        }

        public void releaseShift()
        {
            keybd_event((byte)0x10, 0x2A, 3, 0);
        }
    }
}
