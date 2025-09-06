using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

namespace DadsAwesomeAutoClicker
{ 
    
    public partial class DadsAutoClicker : Form
    {
        Thread trackingThread;
        int trackMode;        
        int msBetweenClicks;
        Stopwatch measureDeltaTime;

       [DllImport("user32.dll")]
        private static extern int RegisterHotKey(IntPtr hwnd, int id, int fsModifiers, int vk);
        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        public DadsAutoClicker()
        {
            InitializeComponent();
        }     
        
        
        private void DadsAutoClicker_Load(object sender, EventArgs e)
        {
            Process.GetCurrentProcess().PriorityClass = ProcessPriorityClass.RealTime;
            trackingThread = new Thread(TrackMouse);
            trackingThread.Priority = ThreadPriority.Highest;
            trackMode = 0;            
            msBetweenClicks = -1;
            measureDeltaTime = new Stopwatch();            

            RegisterHotKey(this.Handle, 0, 4, Keys.A.GetHashCode());
            trackingThread.Start();            
            measureDeltaTime.Start();
            SelPos.Text = "Set CPS";
            dtLbl.Text = "Click Speed: ";
            UpdateStatusText();

        }

       public void unRegisterKeys()
        {
            UnregisterHotKey(this.Handle, 0);
            trackMode = 4;
        }

        public delegate void UpdateLabelsNotify(int pos);
        public delegate void UpdateCursorLocationNotify(Point cursorLoc);
        public delegate void UpdateDeltaTime(double dt);

        private void TrackMouse()
        {
            while (trackMode != 4)
            {
                //find mouse position
                int x = Cursor.Position.X;
                int y = Cursor.Position.Y;
                UpdateXpos(x);
                UpdateYpos(y);
                measureDeltaTime.Stop();
                TimeSpan dt = measureDeltaTime.Elapsed;                
                UpdateDtTime(dt.TotalMilliseconds);
                measureDeltaTime.Reset();

                if (trackMode == 1)
                {

                    measureDeltaTime.Start();                    
                    Thread.Sleep(15); // 60Hz update
                }
                else if(trackMode == 3)
                {
                    measureDeltaTime.Start();
                    Stopwatch rtc = new Stopwatch();
                    rtc.Start();

                    Win32.mouse_event(Win32.MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
                    Win32.mouse_event(Win32.MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);                    
                   
                    while (rtc.ElapsedTicks < (msBetweenClicks-1)*10000);
                }              
            }
        }

        public void UpdateXpos(int pos)
        {
            if (XPos.InvokeRequired)
            {
                var d = new UpdateLabelsNotify(UpdateXpos);
                XPos.Invoke(d, new object[] { pos });
            }
            else
            {
                XPos.Text = pos.ToString();
            }
        }

        public void UpdateYpos(int pos)
        {
            if (YPos.InvokeRequired)
            {
                var d = new UpdateLabelsNotify(UpdateYpos);
                YPos.Invoke(d, new object[] { pos });
            }
            else
            {
                YPos.Text = pos.ToString();
            }
        }
        
        public void UpdateDtTime(double dt)
        {
            if(dtVal.InvokeRequired)
            {
                var d = new UpdateDeltaTime(UpdateDtTime);
                dtVal.Invoke(d, new object[] { dt });
            }
            else if (trackMode == 3)
            {
                if((int)dt > msBetweenClicks)
                {
                    dtVal.Text = "Not Real Time";
                }
                else
                {
                    //dtVal.Text = dt.ToString();
                    dtVal.Text = "Real Time";
                }
                
            }
            else
            {
                dtVal.Text = "Not Clicking";
            }
        }
        

        private void SelPos_Click(object sender, EventArgs e)
        {           
            UpdateTrackingMode();
        }

        private void UpdateTrackingMode()
        {
            switch (trackMode)
            {
                case 0:                   
                    SelPos.Text = "Shift-A to Start Clicking";
                    UpdateCps();
                    trackMode++;
                    SelPos.Enabled = false;
                    break;
                case 1:
                    UpdateCps();
                    break;
                case 2:                
                    
                    break;
                case 3:
                    break;
                default:
                    break;
            }
            UpdateStatusText();

        }

        private void UpdateStatusText()
        {
            string trackModeString = trackMode switch
            {
                0 => "Init",
                1 => "Ready",
                2 => "Undef",
                3 => "Clicking",
                4 => "Done",
                _ => "Unk",
            };

            StatusLabel.Text = trackModeString;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private bool UpdateCps()
        {
            try
            {
                double cpsTxt = Convert.ToDouble(CpsTextBx.Text);
                msBetweenClicks = (int)((1.0f / cpsTxt)*1000.0f);
            }
            catch
            {
                msBetweenClicks = -1;
            }

            MsVal.Text = msBetweenClicks.ToString();


            return true;
        }
       protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == 0x0312)
            {
               if(msBetweenClicks != -1)
                {
                    if(trackMode!=3)
                    {
                        SelPos.Text = "Clicking...";
                        SelPos.Enabled = false;
                        CpsTextBx.Enabled = false;
                        UpdateCps();
                        trackMode = 3;
                    }
                    else
                    {
                        SelPos.Text = "Set New CPS\nShift-A to Start";
                        dtVal.Text = "Not Clicking";
                        trackMode = 1;
                        SelPos.Enabled = true;
                        CpsTextBx.Enabled = true;
                        UpdateCps();
                    }
                }

                UpdateStatusText();
            }                
        }


    }

    public class Win32
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);
        //Mouse actions
        public const int MOUSEEVENTF_LEFTDOWN = 0x02;
        public const int MOUSEEVENTF_LEFTUP = 0x04;
        public const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        public const int MOUSEEVENTF_RIGHTUP = 0x10;
        public const int MOUSEEVENTF_ABSOLUTE = 0x8000;
        public const int MOUSEEVENTF_MOVE = 0x0001;

        

    }
}
