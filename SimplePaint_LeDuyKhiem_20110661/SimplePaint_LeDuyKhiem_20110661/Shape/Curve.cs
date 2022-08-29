using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePaint_LeDuyKhiem_20110661.Shape
{
    public class Curve : cShape
    {
        public Point P1;
        public Point P2;

        public GraphicsPath Path { get; set; }



        public Point X;
        public Point Y;

        int w;
        public Curve()
        {
            this.isCurve = true;
        }
        public List<Point> ListPoint = new List<Point>();

        public override void Draw(Graphics gp)
        {
            if (ListPoint.Count > 1)
                gp.DrawCurve(myPen, ListPoint.ToArray());

        }

        public Point Center { get; set; }
        public int Radious { get; set; }

        public void setShape() { }


        public override bool HitTest(Point p)
        {
            X = p;
            Path = new GraphicsPath();
            Path.AddCurve(ListPoint.ToArray());
            var result = false;

            result = Path.IsOutlineVisible(p, myPen);
            return result;
        }

        public override void Move(Point d)
        {
            Y = d;
            int dx = Y.X - X.X, dy = Y.Y - X.Y;
            for (int i = 0; i < ListPoint.Count; i++)
            {
                ListPoint[i] = new Point(ListPoint[i].X + dx, ListPoint[i].Y + dy);
            }
            P1 = new Point(P1.X + dx, P1.Y + dy);
            P2 = new Point(P2.X + dx, P2.Y + dy);
            X = Y;
        }

        public override void DrawSelectArea(Graphics gp)
        {
            SolidBrush b = new SolidBrush(Color.BlueViolet);
            P1 = ListPoint[0];
            P2 = P1;
            for (int i = 0; i < ListPoint.Count; i++)
            {
                if (P1.X > ListPoint[i].X)
                {
                    P1.X = ListPoint[i].X;
                }
                if (P1.Y > ListPoint[i].Y)
                {
                    P1.Y = ListPoint[i].Y;
                }
                if (P2.X < ListPoint[i].X)
                {
                    P2.X = ListPoint[i].X;
                }
                if (P2.Y < ListPoint[i].Y)
                {
                    P2.Y = ListPoint[i].Y;
                }
                gp.FillEllipse(b, ListPoint[i].X - 4 - width / 2, ListPoint[i].Y - 4 - width / 2, 8 + width, 8 + width);
            }
        }
    }
}
