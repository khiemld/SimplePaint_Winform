using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePaint_LeDuyKhiem_20110661.Shape
{
    public abstract class cShape
    {
        public Point p1 { get; set; }
        public Point p2 { get; set; }
        public Pen myPen { get; set; }
        public Brush myBrush { get; set; }
        public bool isFill { get; set; }
        public bool isSelected { get; set; }
        public bool isCurve { get; set; }
        public bool isPolygon { get; set; }

        public int width { get; set;}

        public bool isDraw {get; set; }

        public cShape()
        {
            this.isCurve = false;
            this.isPolygon = false;
            this.isFill = false;
        }

        public abstract void Draw(Graphics gp);

        public abstract bool HitTest(Point p);
        public abstract void Move(Point d);

        public abstract void DrawSelectArea(Graphics gp);

    }
}
