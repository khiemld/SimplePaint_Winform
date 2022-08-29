using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePaint_LeDuyKhiem_20110661.Shape
{
    public class Square : cShape
    {
        public Point P1 { get; set; }
        public Point P2 { get; set; }

        Point Location;

        public GraphicsPath Path { get; set; }

        public int diameter { get; set; }

        public Point X;
        public Point Y;

        int w;
        int wShape;
        public override void Draw(Graphics gp)
        {
            if (isDraw == false)
            {
                setShape();
            }
            if (this.isFill == true)
            {
                 gp.FillRectangle(myBrush, Location.X, Location.Y, w, w);
            }
            else
            {
                gp.DrawRectangle(myPen, Location.X, Location.Y, w, w);
            }

        }


    
        public override bool HitTest(Point p)
        {
            X = p;
            P1 = new Point(Location.X - (wShape / 2), Location.Y - (wShape / 2));
            P2 = new Point(Location.X + w + (wShape / 2), Location.Y + w + (wShape / 2));
            Path = new GraphicsPath();
            System.Drawing.Rectangle rect = new System.Drawing.Rectangle(Location.X, Location.Y, w, w);
            Path.AddRectangle(rect);
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
            Location = new Point(Location.X + dx, Location.Y + dy);
            p1 = Location;
            P1 = new Point(P1.X + dx, P1.Y + dy);
            P2 = new Point(P2.X + dx, P2.Y + dy);
            X = Y;
        }

        public override void DrawSelectArea(Graphics gp)
        {
            Pen p = new Pen(Color.Blue, 2);
            p.DashStyle = DashStyle.Dash;
            gp.DrawRectangle(p, P1.X, P1.Y, w, w);
        }

        public void setShape() {
            Location = p1;
            w = Math.Min(Math.Abs(p1.X - p2.X), Math.Abs(p1.Y - p2.Y));
            if (p1.X > p2.X && p1.Y > p2.Y)
            {
                Location.Y = p1.Y - w;
                Location.X = p1.X - w;
            }
            if (p1.X < p2.X && p1.Y > p2.Y)
            {
                Location.Y = p1.Y - w;
            }
            if (p1.X > p2.X && p1.Y < p2.Y)
            {
                Location.X = p1.X - w;
            }
        }
    }
}
