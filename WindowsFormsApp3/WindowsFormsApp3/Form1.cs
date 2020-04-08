using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }
    Rectangle[] rectangles = new Rectangle[50];
    Pen pen = new Pen(Color.Black, 2);
    Point[] points = new Point[50];
    Size size = new Size(70, 120);
    

    private void Form1_Paint(object sender, PaintEventArgs e)
        {
           Graphics g = e.Graphics; // Объявляется объект Graphics
      g.Clear(Color.White);
      for (int i = 0; i < 20; i++)
      {
        int xPos;
        if (i % 2 == 0)
        {
          xPos = 10;
        }
        else
        {
          xPos = 400;
        }

        points[i] = new Point(xPos, 10 * i);

        rectangles[i] = new Rectangle(points[i], size);
      }
      for (int i = 20; i < 40; i++)
      {
        int xPos;
        if (i % 2 == 0)
        {
          xPos = 200;
        }
        else
        {
          xPos = 700;
        }
        points[i] = new Point(xPos, 10 * i);
        rectangles[i] = new Rectangle(points[i], size);
      }
      Rectangle rectangle = new Rectangle(130, 140, 200, 400);
      g.DrawRectangles(pen, rectangles);
      g.DrawEllipse(pen, rectangle);

      // Далее вставляется код рисования

    }
  }
}
