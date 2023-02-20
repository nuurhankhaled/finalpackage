using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace finalpackage
{
    
    private void lineDDA(int x0, int y0, int xEnd, int yEnd)
    {
        int dx = xEnd - x0;
        int dy = yEnd - y0;
        int steps;
        int k;
        float xIncrement;
        float yIncrement;
        float x = x0;
        float y = y0;
        Graphics g = panel1.Graphics;
        var n = Brushes.LightGray;
        if (Math.Abs(dx) > Math.Abs(dy))
        {
            steps = Math.Abs(dx);
        }
        else
        {
            steps = Math.Abs(dy);
        }
        xIncrement = (float)dx / (float)steps;
        yIncrement = (float)dy / (float)steps;

        g.FillRectangle(n, x, y, 1, 1);
        for (k = 0; k < steps; k++)
        {
            x += xIncrement;
            y += yIncrement;
            g.FillRectangle(n, x, y, 1, 1);
        }
    }
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

            
                base.OnPaint(e);
                using (Graphics g = e.Graphics)
                {
                    Pen p = new Pen(Color.White);
                    Point p1 = new Point(200, 0);
                    Point p2 = new Point(200, 400);//draw line p1 w p2
                    Point p3 = new Point(0, 200);
                    Point p4 = new Point(400, 200);
                    g.DrawLine(p, p1, p2);
                    g.DrawLine(p, p3, p4);
                
            }
        }
    }
}
