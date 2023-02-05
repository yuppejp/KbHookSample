using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KbHookSample
{
    public partial class Form1 : Form
    {
        KeyboardHook keyboardHook = new KeyboardHook();

        public Form1()
        {
            InitializeComponent();

            labelKey.Text = "";
            labelShift.Text = "";
            labelCtrl.Text = "";
            labelAlt.Text = "";
        }

        protected override void OnLoad(EventArgs e)
        {
            keyboardHook.KeyDownEvent += KeyboardHook_KeyDownEvent;
            keyboardHook.KeyUpEvent += KeyboardHook_KeyUpEvent;
            keyboardHook.Hook();
        }

        // A-Zキーが押されているときは非0が入る
        int AtoZ = 0;

        private bool KeyboardHook_KeyDownEvent(object sender, KeyEventArg e)
        {
            KeysConverter kc = new KeysConverter();

            if (e.KeyCode >= 65 && e.KeyCode <= 90)
            {
                AtoZ = e.KeyCode;
                labelKey.Text = kc.ConvertToString(e.KeyCode);
            }
            else if (e.KeyCode == 160 || e.KeyCode == 161)
                labelShift.Text = "Shift";
            else if (e.KeyCode == 162 || e.KeyCode == 163)
                labelCtrl.Text = "Ctrl";
            else if (e.KeyCode == 164 || e.KeyCode == 165)
                labelAlt.Text = "Alt";
            else
                labelKey.Text = kc.ConvertToString(e.KeyCode);


            StringBuilder sb = new StringBuilder(1024);
            User32.GetWindowText(User32.GetForegroundWindow(), sb, 1024);
            Console.WriteLine("Foreground" + sb);

            IntPtr hWnd = User32.GetFocus();
            User32.GetWindowText(hWnd, sb, 1024);
            Console.WriteLine("Focus: " + sb);

            if (labelKey.Text == "Enter")
            {
                return true;
            } else
            {
                return false;
            }
        }

        private bool KeyboardHook_KeyUpEvent(object sender, KeyEventArg e)
        {
            KeysConverter kc = new KeysConverter();

            if (e.KeyCode >= 65 && e.KeyCode <= 90 && AtoZ == e.KeyCode)
            {
                AtoZ = 0;
                labelKey.Text = "";
            }
            else if (e.KeyCode == 160 || e.KeyCode == 161)
                labelShift.Text = "";
            else if (e.KeyCode == 162 || e.KeyCode == 163)
                labelCtrl.Text = "";
            else if (e.KeyCode == 164 || e.KeyCode == 165)
                labelAlt.Text = "";
            else if (AtoZ == 0)
                labelKey.Text = "";
            else
                labelKey.Text = kc.ConvertToString(AtoZ);

            if (labelKey.Text == "Enter")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            keyboardHook.UnHook();
        }
    }
}
