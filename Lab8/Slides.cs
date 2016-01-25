using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8
{
    public partial class Slides : Form
    {
        public Slides()
        {
            InitializeComponent();
        }
        public int slide;
        protected override void OnPaint(PaintEventArgs e)
        {
            if ((slide + 1) > ((SlideViewer)Owner).FileList.Items.Count)
            {
                this.Close();
                return;
            }

            string currentItem = (string)((SlideViewer)Owner).FileList.Items[slide];

            try
            {
                Image image = Image.FromFile(currentItem);
                float fill = Math.Min(ClientSize.Height / (float)image.Height, ClientSize.Width / (float)image.Width);
                e.Graphics.DrawImage(image, (ClientSize.Width - (float)image.Width * fill) / 2f, (ClientSize.Height - (float)image.Height * fill) / 2f, (float)image.Width * fill, (float)image.Height * fill);
            }

            catch
            {
                e.Graphics.DrawString("Not an image file!", new Font("Arial", 30), Brushes.Red, 25, 25);
            }
        }

        private void Slides_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape) this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            slide += 1;
            this.Invalidate();
        }

        private void Slides_Activated(object sender, EventArgs e)
        {
            this.timer1.Interval = ((SlideViewer)Owner).interval * 1000;
            this.timer1.Enabled = true;
        }
    }
}
