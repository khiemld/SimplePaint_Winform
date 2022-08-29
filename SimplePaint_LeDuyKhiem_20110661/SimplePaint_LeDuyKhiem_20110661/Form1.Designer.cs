
namespace SimplePaint_LeDuyKhiem_20110661
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.plMain = new System.Windows.Forms.Panel();
            this.plMenu = new System.Windows.Forms.Panel();
            this.btnSelect = new System.Windows.Forms.Button();
            this.cbxHatchStyle = new System.Windows.Forms.ComboBox();
            this.btnStrokeColor = new System.Windows.Forms.Button();
            this.btnFillColor = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxDashStyle = new System.Windows.Forms.ComboBox();
            this.ckbFill = new System.Windows.Forms.CheckBox();
            this.btnBezier = new System.Windows.Forms.Button();
            this.btnPolygon = new System.Windows.Forms.Button();
            this.btnCircle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.trbStroke = new System.Windows.Forms.TrackBar();
            this.btnElip = new System.Windows.Forms.Button();
            this.btnSquare = new System.Windows.Forms.Button();
            this.btnRect = new System.Windows.Forms.Button();
            this.btnLine = new System.Windows.Forms.Button();
            this.plMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbStroke)).BeginInit();
            this.SuspendLayout();
            // 
            // plMain
            // 
            this.plMain.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.plMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plMain.ForeColor = System.Drawing.SystemColors.Control;
            this.plMain.Location = new System.Drawing.Point(12, 140);
            this.plMain.Name = "plMain";
            this.plMain.Size = new System.Drawing.Size(1088, 371);
            this.plMain.TabIndex = 0;
            this.plMain.Click += new System.EventHandler(this.plMain_Click);
            this.plMain.Paint += new System.Windows.Forms.PaintEventHandler(this.plMain_Paint);
            this.plMain.MouseClick += new System.Windows.Forms.MouseEventHandler(this.plMain_MouseClick);
            this.plMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.plMain_MouseDown);
            this.plMain.MouseMove += new System.Windows.Forms.MouseEventHandler(this.plMain_MouseMove);
            this.plMain.MouseUp += new System.Windows.Forms.MouseEventHandler(this.plMain_MouseUp);
            // 
            // plMenu
            // 
            this.plMenu.BackColor = System.Drawing.Color.MidnightBlue;
            this.plMenu.Controls.Add(this.btnSelect);
            this.plMenu.Controls.Add(this.cbxHatchStyle);
            this.plMenu.Controls.Add(this.btnStrokeColor);
            this.plMenu.Controls.Add(this.btnFillColor);
            this.plMenu.Controls.Add(this.label3);
            this.plMenu.Controls.Add(this.label2);
            this.plMenu.Controls.Add(this.cbxDashStyle);
            this.plMenu.Controls.Add(this.ckbFill);
            this.plMenu.Controls.Add(this.btnBezier);
            this.plMenu.Controls.Add(this.btnPolygon);
            this.plMenu.Controls.Add(this.btnCircle);
            this.plMenu.Controls.Add(this.label1);
            this.plMenu.Controls.Add(this.trbStroke);
            this.plMenu.Controls.Add(this.btnElip);
            this.plMenu.Controls.Add(this.btnSquare);
            this.plMenu.Controls.Add(this.btnRect);
            this.plMenu.Controls.Add(this.btnLine);
            this.plMenu.Location = new System.Drawing.Point(12, 12);
            this.plMenu.Name = "plMenu";
            this.plMenu.Size = new System.Drawing.Size(1088, 122);
            this.plMenu.TabIndex = 1;
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.GhostWhite;
            this.btnSelect.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSelect.Location = new System.Drawing.Point(772, 13);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 38);
            this.btnSelect.TabIndex = 0;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // cbxHatchStyle
            // 
            this.cbxHatchStyle.FormattingEnabled = true;
            this.cbxHatchStyle.Items.AddRange(new object[] {
            "BackwardDiagonal",
            "Cross",
            "DarkDownwardDiagonal",
            "DarkHorizontal",
            "DarkUpwardDiagonal",
            "DarkVertical",
            "DashedDownwardDiagonal",
            "DashedHorizontal",
            "DashedUpwardDiagonal",
            "DashedVertical",
            "DiagonalBrick",
            "DiagonalCross",
            "Divot",
            "DottedDiamond",
            "SolidDiamond"});
            this.cbxHatchStyle.Location = new System.Drawing.Point(446, 75);
            this.cbxHatchStyle.Name = "cbxHatchStyle";
            this.cbxHatchStyle.Size = new System.Drawing.Size(121, 24);
            this.cbxHatchStyle.TabIndex = 9;
            this.cbxHatchStyle.Text = "Solid";
            this.cbxHatchStyle.SelectedIndexChanged += new System.EventHandler(this.cbxHatchStyle_SelectedIndexChanged);
            // 
            // btnStrokeColor
            // 
            this.btnStrokeColor.BackColor = System.Drawing.Color.GhostWhite;
            this.btnStrokeColor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStrokeColor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnStrokeColor.Location = new System.Drawing.Point(598, 64);
            this.btnStrokeColor.Name = "btnStrokeColor";
            this.btnStrokeColor.Size = new System.Drawing.Size(75, 47);
            this.btnStrokeColor.TabIndex = 2;
            this.btnStrokeColor.Text = "Stroke Color";
            this.btnStrokeColor.UseVisualStyleBackColor = false;
            this.btnStrokeColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnFillColor
            // 
            this.btnFillColor.BackColor = System.Drawing.Color.GhostWhite;
            this.btnFillColor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFillColor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnFillColor.Location = new System.Drawing.Point(679, 62);
            this.btnFillColor.Name = "btnFillColor";
            this.btnFillColor.Size = new System.Drawing.Size(65, 50);
            this.btnFillColor.TabIndex = 11;
            this.btnFillColor.Text = "Fill Color";
            this.btnFillColor.UseVisualStyleBackColor = false;
            this.btnFillColor.Click += new System.EventHandler(this.btnFillColor_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(368, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Hatch Style";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(368, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Dash Style";
            // 
            // cbxDashStyle
            // 
            this.cbxDashStyle.FormattingEnabled = true;
            this.cbxDashStyle.Items.AddRange(new object[] {
            "Dash",
            "DashDot",
            "DashDotDot",
            "Dot",
            "Solid"});
            this.cbxDashStyle.Location = new System.Drawing.Point(446, 20);
            this.cbxDashStyle.Name = "cbxDashStyle";
            this.cbxDashStyle.Size = new System.Drawing.Size(121, 24);
            this.cbxDashStyle.TabIndex = 8;
            this.cbxDashStyle.SelectedIndexChanged += new System.EventHandler(this.cbxDashStyle_SelectedIndexChanged);
            // 
            // ckbFill
            // 
            this.ckbFill.AutoSize = true;
            this.ckbFill.Location = new System.Drawing.Point(791, 79);
            this.ckbFill.Name = "ckbFill";
            this.ckbFill.Size = new System.Drawing.Size(46, 20);
            this.ckbFill.TabIndex = 7;
            this.ckbFill.Text = "Fill";
            this.ckbFill.UseVisualStyleBackColor = true;
            this.ckbFill.CheckedChanged += new System.EventHandler(this.ckbFill_CheckedChanged);
            // 
            // btnBezier
            // 
            this.btnBezier.BackColor = System.Drawing.Color.GhostWhite;
            this.btnBezier.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBezier.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBezier.Location = new System.Drawing.Point(15, 69);
            this.btnBezier.Name = "btnBezier";
            this.btnBezier.Size = new System.Drawing.Size(81, 35);
            this.btnBezier.TabIndex = 5;
            this.btnBezier.Text = "Curve";
            this.btnBezier.UseVisualStyleBackColor = false;
            this.btnBezier.Click += new System.EventHandler(this.btnBezier_Click);
            // 
            // btnPolygon
            // 
            this.btnPolygon.BackColor = System.Drawing.Color.GhostWhite;
            this.btnPolygon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPolygon.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPolygon.Location = new System.Drawing.Point(276, 14);
            this.btnPolygon.Name = "btnPolygon";
            this.btnPolygon.Size = new System.Drawing.Size(75, 35);
            this.btnPolygon.TabIndex = 0;
            this.btnPolygon.Text = "Polygon";
            this.btnPolygon.UseVisualStyleBackColor = false;
            this.btnPolygon.Click += new System.EventHandler(this.btnPolygon_Click);
            // 
            // btnCircle
            // 
            this.btnCircle.BackColor = System.Drawing.Color.GhostWhite;
            this.btnCircle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCircle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCircle.Location = new System.Drawing.Point(100, 15);
            this.btnCircle.Name = "btnCircle";
            this.btnCircle.Size = new System.Drawing.Size(82, 35);
            this.btnCircle.TabIndex = 0;
            this.btnCircle.Text = "Circle";
            this.btnCircle.UseVisualStyleBackColor = false;
            this.btnCircle.Click += new System.EventHandler(this.btnCircle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(594, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Width:";
            // 
            // trbStroke
            // 
            this.trbStroke.Location = new System.Drawing.Point(662, 14);
            this.trbStroke.Name = "trbStroke";
            this.trbStroke.Size = new System.Drawing.Size(104, 56);
            this.trbStroke.TabIndex = 0;
            this.trbStroke.Scroll += new System.EventHandler(this.trbStroke_Scroll);
            // 
            // btnElip
            // 
            this.btnElip.BackColor = System.Drawing.Color.GhostWhite;
            this.btnElip.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnElip.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnElip.Location = new System.Drawing.Point(188, 15);
            this.btnElip.Name = "btnElip";
            this.btnElip.Size = new System.Drawing.Size(82, 35);
            this.btnElip.TabIndex = 2;
            this.btnElip.Text = "Elippse";
            this.btnElip.UseVisualStyleBackColor = false;
            this.btnElip.Click += new System.EventHandler(this.btnElip_Click);
            // 
            // btnSquare
            // 
            this.btnSquare.BackColor = System.Drawing.Color.GhostWhite;
            this.btnSquare.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSquare.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSquare.Location = new System.Drawing.Point(224, 70);
            this.btnSquare.Name = "btnSquare";
            this.btnSquare.Size = new System.Drawing.Size(82, 35);
            this.btnSquare.TabIndex = 3;
            this.btnSquare.Text = "Square";
            this.btnSquare.UseVisualStyleBackColor = false;
            this.btnSquare.Click += new System.EventHandler(this.btnSquare_Click);
            // 
            // btnRect
            // 
            this.btnRect.BackColor = System.Drawing.Color.GhostWhite;
            this.btnRect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRect.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRect.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRect.Location = new System.Drawing.Point(101, 70);
            this.btnRect.Name = "btnRect";
            this.btnRect.Size = new System.Drawing.Size(118, 35);
            this.btnRect.TabIndex = 1;
            this.btnRect.Text = "Rectangle";
            this.btnRect.UseVisualStyleBackColor = false;
            this.btnRect.Click += new System.EventHandler(this.btnHCN_Click);
            // 
            // btnLine
            // 
            this.btnLine.BackColor = System.Drawing.Color.GhostWhite;
            this.btnLine.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLine.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLine.Location = new System.Drawing.Point(15, 15);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(81, 35);
            this.btnLine.TabIndex = 0;
            this.btnLine.Text = "Line";
            this.btnLine.UseVisualStyleBackColor = false;
            this.btnLine.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(1107, 523);
            this.Controls.Add(this.plMenu);
            this.Controls.Add(this.plMain);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simple Paint";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.plMenu.ResumeLayout(false);
            this.plMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbStroke)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel plMain;
        private System.Windows.Forms.Panel plMenu;
        private System.Windows.Forms.Button btnLine;
        private System.Windows.Forms.Button btnRect;
        private System.Windows.Forms.Button btnStrokeColor;
        private System.Windows.Forms.Button btnSquare;
        private System.Windows.Forms.Button btnElip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trbStroke;
        private System.Windows.Forms.Button btnCircle;
        private System.Windows.Forms.Button btnPolygon;
        private System.Windows.Forms.Button btnBezier;
        private System.Windows.Forms.CheckBox ckbFill;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxHatchStyle;
        private System.Windows.Forms.ComboBox cbxDashStyle;
        private System.Windows.Forms.Button btnFillColor;
        private System.Windows.Forms.Button btnSelect;
    }
}

