using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prutsen
{
    public partial class crosshairgen : Form
    {
        public crosshairgen()
        {
            InitializeComponent();

       
        }



        private void ch_Paint(object sender, PaintEventArgs e)
        {

            Graphics gObject = ch.CreateGraphics();
            Brush color = new SolidBrush(Color.Red);
            Pen redPen = new Pen(Color.Red, 8);

            gObject.DrawLine(redPen, 50, 50, 30, 50); //left
            gObject.DrawLine(redPen, 50, 50, 70, 50); //right
            gObject.DrawLine(redPen, 50, 50, 50, 30); //top
            gObject.DrawLine(redPen, 50, 50, 50, 70); //bottom
        }
    }
}
