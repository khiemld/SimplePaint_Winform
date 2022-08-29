using SimplePaint_LeDuyKhiem_20110661.Shape;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace SimplePaint_LeDuyKhiem_20110661
{
    public partial class frmMain : Form
    {
    
        bool bLine = false, bRect = false, bSquare = false, bElip = false, bCircle = false, bCurve = false, bPolygon = false;

        Pen myPen;
        Color strokeColor = Color.Black;
        Color fillColor = Color.Black;
        Polygon polygon;
        Curve curve;

        bool isStart = false;//cờ xác định đang vẽ
        bool isCurvePol = false;

        List<Point> lPoint = new List<Point>();
        List<cShape> lShape = new List<cShape>();

        bool bMove = false;
        Point previousPoint = Point.Empty;
        bool bSelect = false;
      
        List<int> lSelectedIndex = new List<int>();
        
        public frmMain()
        {
            InitializeComponent();
            this.plMain.SetDoubleBuffered();
            myPen = new Pen(strokeColor, trbStroke.Value);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

            trbStroke.Value = 3;
        }

        public HatchStyle PickHatchStyle()
        {
            switch (cbxHatchStyle.SelectedIndex)
            {
                case 0:
                    return HatchStyle.BackwardDiagonal;
                case 1:
                    return HatchStyle.Cross;
                case 2:
                    return HatchStyle.DarkDownwardDiagonal;
                case 3:
                    return HatchStyle.DarkHorizontal;
                case 4:
                    return HatchStyle.DarkUpwardDiagonal;
                case 5:
                    return HatchStyle.DarkVertical;
                case 6:
                    return HatchStyle.DashedDownwardDiagonal;
                case 7:
                    return HatchStyle.DashedHorizontal;
                case 8:
                    return HatchStyle.DashedUpwardDiagonal;
                case 9:
                    return HatchStyle.DashedVertical;
                case 10:
                    return HatchStyle.DiagonalBrick;
                case 11:
                    return HatchStyle.DiagonalCross;
                case 12:
                    return HatchStyle.Divot;
                case 13:
                    return HatchStyle.DottedDiamond;
                case 14:
                    return HatchStyle.SolidDiamond;

            }
            return HatchStyle.SolidDiamond;
        }

        public Pen PickDashStyle(Pen myPen)
        {
            switch (cbxDashStyle.SelectedIndex)
            {
                case 0:
                    myPen.DashStyle = DashStyle.Dash;
                    break;
                case 1:
                    myPen.DashStyle = DashStyle.DashDot;
                    break;
                case 2:
                    myPen.DashStyle = DashStyle.DashDotDot;
                    break;
                case 3:
                    myPen.DashStyle = DashStyle.Dot;
                    break;
                case 4:
                    myPen.DashStyle = DashStyle.Solid;
                    break;
            }
            return myPen;
        }
        public Brush PickBrush()
        {
            if (cbxHatchStyle.Text == "Solid")
            {
                return new SolidBrush(this.fillColor);
            }
            return new HatchBrush(this.PickHatchStyle(), this.fillColor, this.strokeColor);
        }

        #region Button
        private void button1_Click(object sender, EventArgs e)
        {
            bLine = true;
            bRect = false;
            bSquare = false;
            bElip = false;
            bCurve = false;
            bCircle = true;
            bPolygon = false;
            bSelect = false;
            plMain.Cursor = Cursors.Cross;
        }

        private void btnHCN_Click(object sender, EventArgs e)
        {
            bRect = true;
            bLine = false;
            bSquare = false;
            bElip = false;
            bCurve = false;
            bCircle = true;
            bPolygon = false;
            bSelect = false;
            plMain.Cursor = Cursors.Cross;
        }

        private void btnSquare_Click(object sender, EventArgs e)
        {
            bRect = false;
            bLine = false;
            bSquare = true;
            bElip = false;
            bCurve = false;
            bCircle = true;
            bPolygon = false;
            bSelect = false;
            plMain.Cursor = Cursors.Cross;
        }

        private void btnElip_Click(object sender, EventArgs e)
        {
            bRect = false;
            bLine = false;
            bSquare = false;
            bElip = true;
            bCurve = false;
            bCircle = true;
            bPolygon = false;
            bSelect = false;
            plMain.Cursor = Cursors.Cross;
        }

        private void btnCircle_Click(object sender, EventArgs e)
        {
            bRect = false;
            bLine = false;
            bSquare = false;
            bElip = false;
            bCircle = true;
            bCurve = false;
            bPolygon = false;
            bSelect = false;
            plMain.Cursor = Cursors.Cross;
        }

        private void btnPolygon_Click(object sender, EventArgs e)
        {
            bRect = false;
            bLine = false;
            bSquare = false;
            bElip = false;
            bCircle = false;
            bCurve = false;
            bPolygon = true;
            bSelect = false;
            plMain.Cursor = Cursors.Cross;
            polygon = new Polygon();
            if (ckbFill.Checked == true)
            {
                polygon.myBrush = this.PickBrush();
                polygon.isFill = true;
            }
            polygon.myPen = myPen;
            polygon.myPen = this.PickDashStyle(polygon.myPen);
            this.lShape.Add(polygon);

        }

        private void btnBezier_Click(object sender, EventArgs e)
        {
            bRect = false;
            bLine = false;
            bSquare = false;
            bElip = false;
            bCircle = false;
            bCurve = true;
            bPolygon = false;
            bSelect = false;
            plMain.Cursor = Cursors.Cross;
            this.lPoint = new List<Point>();
            curve = new Curve();
            curve.myPen = myPen;
            curve.myPen = this.PickDashStyle(curve.myPen);
            this.lShape.Add(curve);
        }
        #endregion


        #region Mouse Event
        private void plMain_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.bLine)
            {
                cShape myLine = new Line();
                myLine.p1 = e.Location;
                myLine.p2 = e.Location;
                myLine.width = trbStroke.Value;
                myLine.myPen = new Pen(strokeColor, trbStroke.Value);
                myLine.myPen = this.PickDashStyle(myLine.myPen);
                this.lShape.Add(myLine);
                this.isStart = true;
            }
            else if (this.bRect)
            {
                cShape myRect = new Shape.Rectangle();
                if (ckbFill.Checked == true)
                {
                    myRect.myBrush = this.PickBrush();
                    myRect.isFill = true;
                }
                myRect.p1 = e.Location;
                myRect.p2 = e.Location;
                myRect.myPen = myPen;
                myRect.myPen = this.PickDashStyle(myRect.myPen);
                this.lShape.Add(myRect);
                this.isStart = true;
            }
            else if (this.bSquare)
            {
                cShape mySquare = new Square();
                if (ckbFill.Checked == true)
                {
                    mySquare.myBrush = this.PickBrush();
                    mySquare.isFill = true;
                }
                mySquare.p1 = e.Location;
                mySquare.p2 = e.Location;
                mySquare.myPen = myPen;
                mySquare.myPen = this.PickDashStyle(mySquare.myPen);
                this.lShape.Add(mySquare);
                this.isStart = true;
            }
            else if (this.bElip)
            {
                cShape myElip = new Ellipse();
                if (ckbFill.Checked == true)
                {
                    myElip.myBrush = this.PickBrush();
                    myElip.isFill = true;
                }
                myElip.p1 = e.Location;
                myElip.p2 = e.Location;
                myElip.myPen = myPen;
                myElip.myPen = this.PickDashStyle(myElip.myPen);
                this.lShape.Add(myElip);
                this.isStart = true;
            }
            else if (this.bCircle)
            {
                cShape myCircle = new Circle();
                if (ckbFill.Checked == true)
                {
                    myCircle.myBrush = this.PickBrush();
                    myCircle.isFill = true;
                }
                myCircle.p1 = e.Location;
                myCircle.p2 = e.Location;
                myCircle.myPen = myPen;
                myCircle.myPen = this.PickDashStyle(myCircle.myPen);
                this.lShape.Add(myCircle);
                this.isStart = true;
            }
            if (bSelect == true)
            {
                for (int i = lShape.Count - 1; i >= 0; i--)
                {
                    if (lShape[i].HitTest(e.Location))
                    {

                        lSelectedIndex.Add(i);
                        
                        bMove = true;

                        return;
                    }
                }

            }
        } 

        private void plMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.isStart)
            {
                lShape[lShape.Count - 1].p2 = e.Location;
              
            }
            else if (this.isCurvePol)
            {
                if (this.bPolygon)
                {
                    polygon.ListPoint[polygon.ListPoint.Count - 1] = e.Location;
                    this.lShape[lShape.Count - 1] = polygon;
                    
                }
                else
                {
                    curve.ListPoint[curve.ListPoint.Count - 1] = e.Location;
                    this.lShape[lShape.Count - 1] = curve;
                }
            }
            if (bSelect == true)
            {
                plMain.Cursor = Cursors.Arrow;
                if (bMove == true)
                {
                    for (int i = 0; i < lSelectedIndex.Count; i++)
                        lShape[lSelectedIndex[i]].Move(e.Location);
                    plMain.Refresh();
                }
                for (int i = 0; i < lShape.Count; i++)
                {
                    if (lShape[i].HitTest(e.Location))
                        plMain.Cursor = Cursors.Hand;
                }

            }
             this.Refresh();
        }

        private void plMain_MouseUp(object sender, MouseEventArgs e)
        {
            if (this.isStart)
            {
                lShape[lShape.Count - 1].p2 = e.Location;
                lShape[lShape.Count - 1].isDraw = true;
                this.Refresh();
            }
            if (bSelect == true)
            {
                if (bMove == true)
                {
                    for (int i = 0; i < lSelectedIndex.Count; i++)
                        lShape[lSelectedIndex[i]].Move(e.Location);
                    plMain.Invalidate();
                    bMove = false;
                }
              
            }
           
            this.isStart = false;
            this.bLine = false;
            this.bRect = false; 
            this.bSquare = false;
            this.bElip = false;
            this.bCircle = false;
            lSelectedIndex.Clear();
        }

        private void plMain_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (bPolygon == true)
                {
                    polygon.ListPoint.Add(e.Location);
                    if (polygon.ListPoint.Count < 2)
                    {
                        polygon.ListPoint.Add(e.Location);
                        polygon.p1 = e.Location;
                        polygon.p2 = e.Location;
                    }
                    if (e.Location.X < polygon.p1.X)
                        polygon.p1 = new Point(e.X, polygon.p1.Y);
                    if (e.Location.Y < polygon.p1.Y)
                        polygon.p1 = new Point(polygon.p1.X, e.Y);
                    if (e.Location.X > polygon.p2.X)
                        polygon.p2 = new Point(e.X, polygon.p2.Y);
                    if (e.Location.Y > polygon.p2.Y)
                        polygon.p2 = new Point(polygon.p2.X, e.Y);
                    this.isCurvePol = true;
                }
                if (bCurve == true)
                {
                    curve.ListPoint.Add(e.Location);
                    curve.width = trbStroke.Value;
                    if (curve.ListPoint.Count < 2)
                    {
                        curve.ListPoint.Add(e.Location);
                        curve.p1 = e.Location;
                        curve.p2 = e.Location;
                    }
                    if (e.Location.X < curve.p1.X)
                        curve.p1 = new Point(e.X, curve.p1.Y);
                    if (e.Location.Y < curve.p1.Y)
                        curve.p1 = new Point(curve.p1.X, e.Y);
                    if (e.Location.X > curve.p2.X)
                        curve.p2 = new Point(e.X, curve.p2.Y);
                    if (e.Location.Y > curve.p2.Y)
                        curve.p2 = new Point(curve.p2.X, e.Y);
                    this.isCurvePol = true;
                }
               
            }
            else
            {

                this.bPolygon = false;
                this.isCurvePol = false;
                this.bCircle = false;
                lSelectedIndex.Clear();

            }
        }
        #endregion

        private void plMain_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < this.lShape.Count; i++)
            {
                this.lShape[i].Draw(e.Graphics);


            }


            if (bSelect == true)
            {
                for (int j = 0; j < lSelectedIndex.Count; j++)
                {
                    lShape[lSelectedIndex[j]].DrawSelectArea(e.Graphics);
                }
            }  

        }

        private void ckbStroke_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnFillColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDlg = new ColorDialog();
            if (colorDlg.ShowDialog() == DialogResult.OK)
            {
                fillColor = colorDlg.Color;
                myPen = new Pen(fillColor, trbStroke.Value);
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (bSelect == false)
            {
                plMain.Cursor = Cursors.Default;
                bSelect = true;
                bCurve = false;
                bPolygon = false;
                btnSelect.BackColor = Color.LightGreen;
                btnSelect.ForeColor = Color.Black;
                
            }
            else
            {
                plMain.Cursor = Cursors.Default;
                bSelect = false;
                lSelectedIndex.Clear();
                plMain.Invalidate();
                isStart = false;
                bCurve = false;
                bPolygon = false;
                btnSelect.BackColor = Color.GhostWhite;
            }
        }
                
        

        private void cbxHatchStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
           
           
        }

        private void cbxDashStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        

        private void ckbFill_CheckedChanged(object sender, EventArgs e)
        {
                
            
        }

       

      
       

        private void btnColor_Click(object sender, EventArgs e)
        {
                ColorDialog colorDlg = new ColorDialog();
                if (colorDlg.ShowDialog() == DialogResult.OK)
                {
                    strokeColor = colorDlg.Color;
                    myPen = new Pen(strokeColor, trbStroke.Value);
                }
        }

        
      
        private void trbStroke_Scroll(object sender, EventArgs e)
        {
            myPen = new Pen(strokeColor, trbStroke.Value);
        }


        

        private void plMain_Click(object sender, EventArgs e)
        {
            
        }

        
       
    }
}
