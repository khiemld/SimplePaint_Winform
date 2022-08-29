using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePaint_LeDuyKhiem_20110661.Shape
{
    public class Line : cShape
    {
        public Point P1;
        public Point P2;

        public GraphicsPath Path { get; set; }



        public Point X;
        public Point Y;

        
  
        public override void Draw(Graphics gp)
        {
            gp.DrawLine(myPen, p1, p2);
        }


        public override bool HitTest(Point p)
        {
            X = p;
            Path = new GraphicsPath();
            Path.AddLine(p1, p2);
            bool result = false;
            result = Path.IsOutlineVisible(p, myPen);
            return result;
        }

        public override void Move(Point d)
        {
            Y = d;
            int dx = Y.X - X.X, dy = Y.Y - X.Y;
            p1 = new Point(p1.X + dx, p1.Y + dy);
            p2 = new Point(p2.X + dx, p2.Y + dy);
            p1 = new Point(p1.X + dx, p1.Y + dy);
            p2 = new Point(p2.X + dx, p2.Y + dy);
            X = Y;
        }

     

        public override void DrawSelectArea(Graphics gp)
        {
            if (p1.X < p2.X)
            {
                P1.X = p1.X;
                P2.X = p2.X;
            }
            else
            {
                P1.X = p2.X;
                P2.X = p1.X;
            }
            if (p1.Y < p2.Y)
            {
                P1.Y = p1.Y;
                P2.Y = p2.Y;
            }
            else
            {
                P1.Y = p2.Y;
                P2.Y = p1.Y;
            }
            SolidBrush b = new SolidBrush(Color.BlueViolet);
            gp.FillEllipse(b, p1.X - 4 - width / 2, p1.Y - 4 - width / 2, 8 + width, 8 + width);
            gp.FillEllipse(b, p2.X - 4 - width / 2, p2.Y - 4 - width / 2, 8 + width, 8 + width);
        }


    }
}
