using System;
using System.Drawing;
using System.Windows.Forms;

namespace ChatApp.Controls
{
    public class LoadingPictureBox : PictureBox
    {
        private Timer timer = new Timer();
        private int index;

        public LoadingPictureBox()
        {
            timer.Interval = 150;
            Bitmap[] bitmaps = new Bitmap[]
            {
                ChatApp.Properties.Resources.loading_1,
                ChatApp.Properties.Resources.loading_2,
                ChatApp.Properties.Resources.loading_3,
                ChatApp.Properties.Resources.loading_4,
                ChatApp.Properties.Resources.loading_5,
            };
            timer.Tick += delegate(object sender, EventArgs e)
            {
                Image = bitmaps[index];

                if (index < bitmaps.Length - 1)
                {
                    index++;
                }
                else
                {
                    index = 0;
                }
            };
        }

        public void Start()
        {
            Image = ChatApp.Properties.Resources.loading_1;
            index = 1;
            timer.Start();
        }

        public void Pause()
        {
            timer.Stop();
        }

        public void Resume()
        {
            timer.Start();
        }

        public void Stop()
        {
            timer.Stop();
        }
    }
}
