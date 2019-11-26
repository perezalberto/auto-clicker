using System;
using System.Drawing;
using System.Windows.Forms;

namespace AutoClicker
{
    public partial class Form1 : Form
    {
        private GlobalHotkey ghkLeft;
        private GlobalHotkey ghkRight;

        private Boolean isLeftActive = false;
        private Boolean isRightActive = false;

        public enum MouseButton
        {
            LEFT,
            RIGHT
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ghkLeft = new GlobalHotkey(GlobalHotkey.CTRL + GlobalHotkey.ALT, Keys.L, this);
            ghkRight = new GlobalHotkey(GlobalHotkey.CTRL + GlobalHotkey.ALT, Keys.R, this);
            ghkLeft.Register();
            ghkRight.Register();
        }

        private Keys GetKey(IntPtr LParam)
        {
            return (Keys)(LParam.ToInt32() >> 16);
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == GlobalHotkey.WM_HOTKEY_MSG_ID)
            {
                switch (GetKey(m.LParam))
                {
                    case Keys.L:
                        Lkey();
                        break;
                    case Keys.R:
                        RKey();
                        break;
                }
            }
            base.WndProc(ref m);
        }

        private void Lkey()
        {
            isLeftActive = !isLeftActive;
            if (isLeftActive)
            {
                if (cbxMantenerIzquierdo.Checked)
                {
                    SetClickState(GlobalMouse.MOUSEEVENTF_LEFTDOWN);
                }
                else
                {
                    timerIzquierdo.Start();
                }
                lblEstadoIzquierdo.Text = "Activo";
            }
            else
            {
                if (cbxMantenerIzquierdo.Checked)
                {
                    SetClickState(GlobalMouse.MOUSEEVENTF_LEFTUP);
                }
                else
                {
                    timerIzquierdo.Stop();
                }
                lblEstadoIzquierdo.Text = "Inactivo";
            }
        }
        private void RKey()
        {
            isRightActive = !isRightActive;
            
            if (isRightActive)
            {
                if (cbxMantenerDerecho.Checked)
                {
                    SetClickState(GlobalMouse.MOUSEEVENTF_RIGHTDOWN);
                }
                else
                {
                    timerDerecho.Start();
                }
                lblEstadoDerecho.Text = "Activo";
            }
            else
            {
                if (cbxMantenerDerecho.Checked)
                {
                    SetClickState(GlobalMouse.MOUSEEVENTF_RIGHTUP);
                }
                else
                {
                    timerDerecho.Stop();
                }
                lblEstadoDerecho.Text = "Inactivo";
            }
        }

        private void SetClickState(int clickState)
        {
            Point currect = new Point();
            GlobalMouse.GetCursorPos(ref currect);
            GlobalMouse.mouse_event(clickState, currect.X, currect.Y, 0, 0);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            ghkLeft.Unregiser();
            ghkRight.Unregiser();
            AutoClicker.Visible = false;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                AutoClicker.Visible = true;
            }
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            AutoClicker.Visible = false;
        }

        private int lCurrTicks = 0;

        private void timerIzquierdo_Tick(object sender, EventArgs e)
        {
            if(lCurrTicks == 0)
            {
                SetClickState(GlobalMouse.MOUSEEVENTF_LEFTDOWN);
            }
            else if(lCurrTicks == NudIzquierdoTiempoPorClicks.Value)
            {
                SetClickState(GlobalMouse.MOUSEEVENTF_LEFTUP);
            }
            else if(lCurrTicks == NudIzquierdoTiempoPorClicks.Value + NudIzquierdoTiempoEntreClicks.Value)
            {
                lCurrTicks = 0;
                return;
            }
            lCurrTicks += 1;
        }

        private int rCurrTicks = 0;

        private void timerDerecho_Tick(object sender, EventArgs e)
        {
            if (rCurrTicks == 0)
            {
                SetClickState(GlobalMouse.MOUSEEVENTF_RIGHTDOWN);
            }
            else if (rCurrTicks == NudDerechoTiempoPorClicks.Value)
            {
                SetClickState(GlobalMouse.MOUSEEVENTF_RIGHTUP);
            }
            else if (rCurrTicks == NudDerechoTiempoPorClicks.Value + NudDerechoTiempoEntreClicks.Value)
            {
                rCurrTicks = 0;
                return;
            }
            rCurrTicks += 1;
        }

        private void cbxMantenerDerecho_CheckedChanged(object sender, EventArgs e)
        {
            PanelDerecho.Enabled = !cbxMantenerDerecho.Checked;
        }

        private void cbxMantenerIzquierdo_CheckedChanged(object sender, EventArgs e)
        {
            PanelIzquierdo.Enabled = !cbxMantenerIzquierdo.Checked;
        }

        private void toolStripMenuRestore_Click(object sender, EventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            AutoClicker.Visible = false;
        }

        private void toolStripMenuClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
