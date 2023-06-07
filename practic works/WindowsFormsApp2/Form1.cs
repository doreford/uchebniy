using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Dynamic;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        private int x = 200;
        private int y = 200;
        private int size = 100;
        public Form1()
        {
            InitializeComponent();
            this.ClientSize = new Size(600, 600);
            this.BackColor = Color.White;
        }
        Graphics g;

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g = CreateGraphics();

            // Рисуем тело куклы
            g.FillEllipse(Brushes.Red, x, y, size, size);
            g.DrawEllipse(Pens.Black, x, y, size, size);

            // Рисуем глаза
            g.FillEllipse(Brushes.White, x + 30, y + 30, 20, 20);
            g.FillEllipse(Brushes.White, x + 50, y + 30, 20, 20);
            g.FillEllipse(Brushes.Black, x + 35, y + 35, 10, 10);
            g.FillEllipse(Brushes.Black, x + 55, y + 35, 10, 10);

            // Рисуем руки
            g.FillRectangle(Brushes.Red, x - 20, y + 40, 20, 40);
            g.DrawRectangle(Pens.Black, x - 20, y + 40, 20, 40);
            g.FillRectangle(Brushes.Red, x + size, y + 40, 20, 40);
            g.DrawRectangle(Pens.Black, x + size, y + 40, 20, 40);

            // Рисую ноги
            g.FillRectangle(Brushes.Red, x + 20, y + size, 20, 40);
            g.DrawRectangle(Pens.Black, x + 20, y + size, 20, 40);
            g.FillRectangle(Brushes.Red, x + 60, y + size, 20, 40);
            g.DrawRectangle(Pens.Black, x + 60, y + size, 20, 40);
        }
    }
}
