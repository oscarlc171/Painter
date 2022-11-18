using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Painter
{
    public partial class PainterForm : Form

    {
        bool ShouldPaint { get; set; } = false;
        Color newColor { get; set; }
        int newSize { get; set; }

        
        public PainterForm()
        {
            InitializeComponent();
        }

        private void PainterForm_MouseDown(object sender, MouseEventArgs e)
        {
            ShouldPaint = true;
        }

        private void PainterForm_MouseUp(object sender, MouseEventArgs e)
        {
            ShouldPaint = false;
        }

        private void PainterForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (ShouldPaint)
            {
                using (Graphics graphics = paintPanel.CreateGraphics())
                {
                    graphics.FillEllipse(new SolidBrush(newColor), e.X, e.Y, newSize, newSize);
                }
            }
        }

        private void PainterForm_ChangeColor(object sender, EventArgs e)
        {
            if (sender == redButton)
            {
                newColor = Color.Red;
            }

            else if (sender == blueButton)
            {
                newColor = Color.Blue;
            }

            else if (sender == greenButton)
            {
                newColor = Color.Green;
            }

            else
            {
                newColor = Color.Black;
            }
        }

        private void PainterForm_ChangeSize(object sender, EventArgs e)
        {
            if (sender == smallButton)
            {
                newSize = 2;
            }

            else if (sender == mediumButton)
            {
                newSize = 4;
            }

            else
            {
                newSize = 6;
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
             paintPanel.Refresh();
        }
    }
}
