using System.Runtime.InteropServices;

namespace AutoClicker
{
    public partial class Form1 : Form
    {
        [StructLayout(LayoutKind.Sequential)]
        protected struct Input
        {
            public int type;
            public MouseInput mi;
        }

        [StructLayout(LayoutKind.Sequential)]
        protected struct MouseInput
        {
            public int dx;
            public int dy;
            public int mouseData;
            public int dwFlags;
            public int time;
            public IntPtr dwExtraInfo;
        }

        [DllImport("user32.dll", SetLastError = true)]
        static extern uint SendInput(uint nInputs, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] Input[] pInputs, int cbSize);

        private Point cursorPosition;
        public Form1()
        {
            InitializeComponent();
        }

        private async void AutoClicker_Tick(object sender, EventArgs e)
        {
            AutoClicker.Interval = 1000 * 60 * CPMToolbar.Value; // Clicks per "Toolbar Value" minutes
            await Task.Delay(500);
            if (btnToggle.Text.Contains("disable"))
            {
                
                // Getting current cursor position
                cursorPosition = Cursor.Position;

                // Scaling coordinates for SendInput
                int scaledX = (int)Math.Round((double)cursorPosition.X / Screen.PrimaryScreen.Bounds.Width * 65535);
                int scaledY = (int)Math.Round((double)cursorPosition.Y / Screen.PrimaryScreen.Bounds.Height * 65535);

                // Creating INPUT struct
                Input[] inputs = new Input[1];
                inputs[0].type = 0;
                inputs[0].mi = new MouseInput
                {
                    dx = scaledX,
                    dy = scaledY,
                    dwFlags = 2 // MOUSEEVENTF_LEFTDOWN
                };

                _ = SendInput(1, inputs, Marshal.SizeOf(typeof(Input)));

                await Task.Delay(30);
                inputs[0].mi.dwFlags = 4; // MOUSEEVENTF_LEFTUP

                _ = SendInput(1, inputs, Marshal.SizeOf(typeof(Input)));

            }
        }

        private void btnToggle_Click(object sender, EventArgs e)
        {
            if (btnToggle.Text.Contains("enable")) { btnToggle.Text = "disable"; }
            else { btnToggle.Text = "enable"; }
        }

        private void btnToggle_TextChanged(object sender, EventArgs e)
        {
            if (btnToggle.Text.Contains("disable")) { AutoClicker.Start(); }
            else { AutoClicker.Stop(); }
        }

        private void CPM_Scroll(object sender, EventArgs e)
        {

            if (CPMToolbar.Value > 1)
            {
                CPMValue.Text = "1 click per " + CPMToolbar.Value.ToString() + " minutes";
            }
            else
            {
                CPMValue.Text = "1 click per minute";
            }
        }
    }
}