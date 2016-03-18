using System;
using System.Drawing;
using System.Windows.Forms;

namespace ChatApp.Controls
{
    public partial class Page : UserControl
    {
        public const int SWITCH_LEFT = -1;
        public const int SWITCH_RIGHT = 1;
        private static SwitchTimer switchTimer;

        public Page()
        {
            InitializeComponent();
        }

        public void SwitchTo(Page page, int direction)
        {
            if (switchTimer != null && switchTimer.Enabled)
            {
                switchTimer.Stop();
                switchTimer.Dispose();
            }

            Size size = Size;
            Dock = DockStyle.None;
            Size = size;
            Anchor = AnchorStyles.None;

            page.Anchor = AnchorStyles.None;
            page.Location = new Point(Width * -direction, 0);
            page.Size = size;
            ParentForm.Controls.Add(page);

            switchTimer = new SwitchTimer(this, page, direction);
            switchTimer.Start();
        }

        private class SwitchTimer : Timer
        {
            private const int INTERVAL = 17;
            private const int TIME = 250;
            private Page fromPage, toPage;
            private int elapsedTime;

            public SwitchTimer(Page fromPage, Page toPage, int direction)
            {
                this.fromPage = fromPage;
                this.toPage = toPage;

                Interval = INTERVAL;
                Tick += delegate(object sender, EventArgs e)
                {
                    elapsedTime += INTERVAL;

                    int offset = (int)(fromPage.Width * direction * (0.5f + Math.Cos(((float)elapsedTime / TIME + 1.0f) * Math.PI) / 2.0f));
                    Point location = fromPage.Location;
                    location.X = offset;
                    fromPage.Location = location;

                    location = toPage.Location;
                    location.X = toPage.Width * -direction + offset;
                    toPage.Location = location;

                    if (elapsedTime >= TIME)
                    {
                        Stop();
                    }
                };
            }

            public new void Stop()
            {
                base.Stop();

                fromPage.ParentForm.Controls.Remove(fromPage);
                fromPage.Dispose();

                toPage.Dock = DockStyle.Fill;
            }
        }
    }
}
