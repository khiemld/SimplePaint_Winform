using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePaint_LeDuyKhiem_20110661.Shape
{
    public class Polygon : cShape
    {
        public Point P1;
        public Point P2;

        public GraphicsPath Path { get; set; }



        public Point X;
        public Point Y;

        public Polygon()
        {
            this.isPolygon = true;
        }
        public List<Point> ListPoint = new List<Point>();

        public override void Draw(Graphics gp)
        {
            if (this.isFill == true)
            {
                if (ListPoint.Count > 1)
                    gp.FillPolygon(myBrush, ListPoint.ToArray());
            }
            else
            {
                if (ListPoint.Count > 1)
                    gp.DrawPolygon(myPen, ListPoint.ToArray());
            }

        }


        public override bool HitTest(Point p)
        {
            X = p;
            P1 = P2 = ListPoint[0];
            for (int i = 0; i < ListPoint.Count; i++)
            {
                if (ListPoint[i].X < P1.X)
                    P1.X = ListPoint[i].X;
                if (ListPoint[i].Y < P1.Y)
                    P1.Y = ListPoint[i].Y;
                if (ListPoint[i].X > P2.X)
                    P2.X = ListPoint[i].X;
                if (ListPoint[i].Y > P2.Y)
                    P2.Y = ListPoint[i].Y;
            }
            Path = new GraphicsPath();
            Path.AddPolygon(ListPoint.ToArray());
            bool result = false;
            
            if (isFill == false)
                result = Path.IsOutlineVisible(p, myPen);
            else
                result = Path.IsVisible(p);
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
            Pen p = new Pen(Color.Blue, 2);
            p.DashStyle = DashStyle.Dash;
            gp.DrawRectangle(p, P1.X, P1.Y, P2.X - P1.X, P2.Y - P1.Y);
        }

        public void setShape() { }

    }
}
