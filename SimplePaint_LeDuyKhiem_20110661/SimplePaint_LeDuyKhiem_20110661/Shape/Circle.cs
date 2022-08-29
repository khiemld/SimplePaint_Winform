using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePaint_LeDuyKhiem_20110661.Shape
{
    public class Circle : cShape
    {
        public Point P1 { get; set; }
        public Point P2 { get; set; }
        
        Point Location;
     
        public GraphicsPath Path { get; set; }

        public int diameter { get; set; }

        public Point X;
        public Point Y;

        public override void Draw(Graphics gp)
        {

            if(isDraw == false)
            {
                setShape();
            }

            if (this.isFill == true)
            {
                
                gp.FillEllipse(myBrush, Location.X, Location.Y, diameter, diameter);
            }
            else
            {
                
                gp.DrawEllipse(myPen, Location.X, Location.Y, diameter, diameter);
            }
        }


        public void setShape()
        {
            if (Math.Abs(p1.X - p2.X) < Math.Abs(p1.Y - p2.Y))
            {
                diameter = Math.Abs(p1.X - p2.X);
            }
            else
            {
                diameter = Math.Abs(p1.Y - p2.Y);
            }
            Location = p1;
            if (p1.X > p2.X && p1.Y > p2.Y)
            {
                Location.Y = p1.Y - diameter;
                Location.X = p1.X - diameter;
            }
            if (p1.X < p2.X && p1.Y > p2.Y)
            {
                Location.Y = p1.Y - diameter;
            }
            if (p1.X > p2.X && p1.Y < p2.Y)
            {
                Location.X = p1.X - diameter;
            }
        }

        public override bool HitTest(Point p)
        {
            
            X = p;
            P1 = Location;
            P2 = new Point(p1.X + (p2.X - p1.X), p2.Y + p2.X - p1.X);
            Path = new GraphicsPath();
            Path.AddEllipse(Location.X, Location.Y, diameter, diameter);
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
            P1 = new Point(P1.X + dx, P1.Y + dy);
            P2 = new Point(P2.X + dx, P2.Y + dy);
            X = Y;
        }

        public override void DrawSelectArea(Graphics gp) 
        {
            Pen p = new Pen(Color.Black, 1);
            p.DashStyle = DashStyle.Dash;
            gp.DrawRectangle(p, Location.X, Location.Y, diameter, diameter);
        }

    }
}
