namespace shapeCalculatorForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_triangle = new Button();
            btn_rectangle = new Button();
            btn_circle = new Button();
            lbl_triangle_circumference = new Label();
            lbl_triangle_area = new Label();
            lbl_rectangle_circumference = new Label();
            lbl_rectangle_area = new Label();
            lbl_circle_circumference = new Label();
            lbl_circle_area = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            nud_triangle_a = new NumericUpDown();
            nud_triangle_b = new NumericUpDown();
            nud_triangle_c = new NumericUpDown();
            nud_rectangle_a = new NumericUpDown();
            nud_rectangle_b = new NumericUpDown();
            nud_circle_radius = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)nud_triangle_a).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_triangle_b).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_triangle_c).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_rectangle_a).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_rectangle_b).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_circle_radius).BeginInit();
            SuspendLayout();
            // 
            // btn_triangle
            // 
            btn_triangle.Location = new Point(142, 289);
            btn_triangle.Name = "btn_triangle";
            btn_triangle.Size = new Size(75, 23);
            btn_triangle.TabIndex = 0;
            btn_triangle.Text = "Calculate";
            btn_triangle.UseVisualStyleBackColor = true;
            btn_triangle.Click += button1_Click;
            // 
            // btn_rectangle
            // 
            btn_rectangle.Location = new Point(373, 289);
            btn_rectangle.Name = "btn_rectangle";
            btn_rectangle.Size = new Size(75, 23);
            btn_rectangle.TabIndex = 1;
            btn_rectangle.Text = "Calculate";
            btn_rectangle.UseVisualStyleBackColor = true;
            btn_rectangle.Click += btn_rectangle_Click;
            // 
            // btn_circle
            // 
            btn_circle.Location = new Point(608, 289);
            btn_circle.Name = "btn_circle";
            btn_circle.Size = new Size(75, 23);
            btn_circle.TabIndex = 2;
            btn_circle.Text = "Calculate";
            btn_circle.UseVisualStyleBackColor = true;
            btn_circle.Click += btn_circle_Click;
            // 
            // lbl_triangle_circumference
            // 
            lbl_triangle_circumference.AutoSize = true;
            lbl_triangle_circumference.Location = new Point(159, 347);
            lbl_triangle_circumference.Name = "lbl_triangle_circumference";
            lbl_triangle_circumference.Size = new Size(16, 15);
            lbl_triangle_circumference.TabIndex = 3;
            lbl_triangle_circumference.Text = "...";
            // 
            // lbl_triangle_area
            // 
            lbl_triangle_area.AutoSize = true;
            lbl_triangle_area.Location = new Point(159, 393);
            lbl_triangle_area.Name = "lbl_triangle_area";
            lbl_triangle_area.Size = new Size(16, 15);
            lbl_triangle_area.TabIndex = 4;
            lbl_triangle_area.Text = "...";
            lbl_triangle_area.Click += label2_Click;
            // 
            // lbl_rectangle_circumference
            // 
            lbl_rectangle_circumference.AutoSize = true;
            lbl_rectangle_circumference.Location = new Point(388, 347);
            lbl_rectangle_circumference.Name = "lbl_rectangle_circumference";
            lbl_rectangle_circumference.Size = new Size(16, 15);
            lbl_rectangle_circumference.TabIndex = 5;
            lbl_rectangle_circumference.Text = "...";
            // 
            // lbl_rectangle_area
            // 
            lbl_rectangle_area.AutoSize = true;
            lbl_rectangle_area.Location = new Point(388, 393);
            lbl_rectangle_area.Name = "lbl_rectangle_area";
            lbl_rectangle_area.Size = new Size(16, 15);
            lbl_rectangle_area.TabIndex = 6;
            lbl_rectangle_area.Text = "...";
            // 
            // lbl_circle_circumference
            // 
            lbl_circle_circumference.AutoSize = true;
            lbl_circle_circumference.Location = new Point(631, 347);
            lbl_circle_circumference.Name = "lbl_circle_circumference";
            lbl_circle_circumference.Size = new Size(16, 15);
            lbl_circle_circumference.TabIndex = 7;
            lbl_circle_circumference.Text = "...";
            // 
            // lbl_circle_area
            // 
            lbl_circle_area.AutoSize = true;
            lbl_circle_area.Location = new Point(631, 393);
            lbl_circle_area.Name = "lbl_circle_area";
            lbl_circle_area.Size = new Size(16, 15);
            lbl_circle_area.TabIndex = 8;
            lbl_circle_area.Text = "...";
            lbl_circle_area.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(108, 128);
            label7.Name = "label7";
            label7.Size = new Size(13, 15);
            label7.TabIndex = 16;
            label7.Text = "a";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(108, 179);
            label8.Name = "label8";
            label8.Size = new Size(14, 15);
            label8.TabIndex = 17;
            label8.Text = "b";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(108, 227);
            label9.Name = "label9";
            label9.Size = new Size(13, 15);
            label9.TabIndex = 18;
            label9.Text = "c";
            label9.Click += label9_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(343, 131);
            label10.Name = "label10";
            label10.Size = new Size(13, 15);
            label10.TabIndex = 19;
            label10.Text = "a";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(343, 179);
            label11.Name = "label11";
            label11.Size = new Size(14, 15);
            label11.TabIndex = 20;
            label11.Text = "b";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(550, 128);
            label12.Name = "label12";
            label12.Size = new Size(39, 15);
            label12.TabIndex = 21;
            label12.Text = "radius";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(149, 58);
            label13.Name = "label13";
            label13.Size = new Size(48, 15);
            label13.TabIndex = 22;
            label13.Text = "Triangle";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(380, 58);
            label14.Name = "label14";
            label14.Size = new Size(59, 15);
            label14.TabIndex = 23;
            label14.Text = "Rectangle";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(625, 58);
            label15.Name = "label15";
            label15.Size = new Size(37, 15);
            label15.TabIndex = 24;
            label15.Text = "Circle";
            // 
            // nud_triangle_a
            // 
            nud_triangle_a.Location = new Point(127, 128);
            nud_triangle_a.Name = "nud_triangle_a";
            nud_triangle_a.Size = new Size(120, 23);
            nud_triangle_a.TabIndex = 25;
            nud_triangle_a.ValueChanged += nud_triangle_a_ValueChanged;
            // 
            // nud_triangle_b
            // 
            nud_triangle_b.Location = new Point(127, 177);
            nud_triangle_b.Name = "nud_triangle_b";
            nud_triangle_b.Size = new Size(120, 23);
            nud_triangle_b.TabIndex = 26;
            // 
            // nud_triangle_c
            // 
            nud_triangle_c.Location = new Point(127, 225);
            nud_triangle_c.Name = "nud_triangle_c";
            nud_triangle_c.Size = new Size(120, 23);
            nud_triangle_c.TabIndex = 27;
            // 
            // nud_rectangle_a
            // 
            nud_rectangle_a.Location = new Point(362, 126);
            nud_rectangle_a.Name = "nud_rectangle_a";
            nud_rectangle_a.Size = new Size(120, 23);
            nud_rectangle_a.TabIndex = 28;
            // 
            // nud_rectangle_b
            // 
            nud_rectangle_b.Location = new Point(363, 177);
            nud_rectangle_b.Name = "nud_rectangle_b";
            nud_rectangle_b.Size = new Size(120, 23);
            nud_rectangle_b.TabIndex = 29;
            // 
            // nud_circle_radius
            // 
            nud_circle_radius.Location = new Point(595, 126);
            nud_circle_radius.Name = "nud_circle_radius";
            nud_circle_radius.Size = new Size(120, 23);
            nud_circle_radius.TabIndex = 30;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(nud_circle_radius);
            Controls.Add(nud_rectangle_b);
            Controls.Add(nud_rectangle_a);
            Controls.Add(nud_triangle_c);
            Controls.Add(nud_triangle_b);
            Controls.Add(nud_triangle_a);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(lbl_circle_area);
            Controls.Add(lbl_circle_circumference);
            Controls.Add(lbl_rectangle_area);
            Controls.Add(lbl_rectangle_circumference);
            Controls.Add(lbl_triangle_area);
            Controls.Add(lbl_triangle_circumference);
            Controls.Add(btn_circle);
            Controls.Add(btn_rectangle);
            Controls.Add(btn_triangle);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)nud_triangle_a).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_triangle_b).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_triangle_c).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_rectangle_a).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_rectangle_b).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_circle_radius).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_triangle;
        private Button btn_rectangle;
        private Button btn_circle;
        private Label lbl_triangle_circumference;
        private Label lbl_triangle_area;
        private Label lbl_rectangle_circumference;
        private Label lbl_rectangle_area;
        private Label lbl_circle_circumference;
        private Label lbl_circle_area;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private NumericUpDown nud_triangle_a;
        private NumericUpDown nud_triangle_b;
        private NumericUpDown nud_triangle_c;
        private NumericUpDown nud_rectangle_a;
        private NumericUpDown nud_rectangle_b;
        private NumericUpDown nud_circle_radius;
    }
}
