using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace прак18
{
    public partial class Form1 : Form
    {
        Bitmap p;
        Bitmap p1;
        string m;
        int x, y;
        int x1, y1;
        public Form1()
        {
            m = "Линия";
            InitializeComponent();
            p = new Bitmap(5000, 5000);
            p1 = new Bitmap(5000, 5000);
            x = y = 0;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            button7.BackColor = b.BackColor;

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "")
            p.Save(saveFileDialog1.FileName);
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName != "")
            {
                p =(Bitmap) Image.FromFile(openFileDialog1.FileName);
                pictureBox1.Image = p;

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            button7.BackColor = b.BackColor;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            button7.BackColor = b.BackColor;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            button7.BackColor = b.BackColor;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            button7.BackColor = b.BackColor;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            button7.BackColor = b.BackColor;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            button7.BackColor = b.BackColor;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            m = "Прямоугольник";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            m = "Круг";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            m = "Линия";
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            Pen k;
            k = new Pen(button7.BackColor, trackBar1.Value);
            Graphics g = Graphics.FromImage(p);
            if (m == "Прямоугольник")
            {
               
                g.DrawRectangle(k, x1, e.X - x1, y1, e.Y - y1);
            }
            if (m == "Круг")
            {
                g.DrawEllipse(k, x1, e.X - x1, y1, e.Y - y1);
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
           x1 = e.X;
           y1 = e.Y;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            Pen k;
            k = new Pen(button7.BackColor, trackBar1.Value);
            k.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            k.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            Graphics g = Graphics.FromImage(p);

            Graphics g1 = Graphics.FromImage(p1);
            if (e.Button == MouseButtons.Left)
            {
                if (m == "Линия")
                {
                    g.DrawLine(k, x, y, e.X, e.Y);
                }
                if (m == "Прямоугольник")
                {
                    g1.Clear(Color.White);
                    int x2, y2;
                    x2 = x1;
                    y2 = y1;
                    if (x2 > e.X) x2 = e.X;
                    if (y2 > e.Y) y2 = e.Y;
                    g1.DrawRectangle(k,x1,Math.Abs(e.X-x1),y1,Math.Abs(e.Y-y1));
                }
                if (m == "Круг")
                {
                    g1.Clear(Color.White);
                    g1.DrawEllipse(k, x1, e.X - x1, y1, e.Y - y1);
                }
                g1.DrawImage(p,0,0);

               pictureBox1.Image = p1;

            }
               x = e.X;
               y = e.Y;
        }
    }
}
