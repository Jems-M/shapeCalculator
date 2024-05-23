using shapeCalculator;

namespace shapeCalculatorForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Triangle triangle = new Triangle();
            triangle.a = (double)nud_triangle_a.Value;
            triangle.b = (double)nud_triangle_b.Value;
            triangle.c = (double)nud_triangle_c.Value;

            lbl_triangle_area.Text = "Area: " + triangle.getArea().ToString();
            lbl_triangle_circumference.Text = "Circumference: " + triangle.getCircumference().ToString();

        }

        private void nud_triangle_a_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_rectangle_Click(object sender, EventArgs e)
        {
            shapeCalculator.Rectangle rectangle = new shapeCalculator.Rectangle();
            rectangle.a = (double)nud_rectangle_a.Value;
            rectangle.b = (double)nud_rectangle_b.Value;

            lbl_rectangle_area.Text = "Area: " + rectangle.getArea().ToString();
            lbl_rectangle_circumference.Text = "Circumference: " + rectangle.getCircumference().ToString();
        }

        private void btn_circle_Click(object sender, EventArgs e)
        {
            Circle circle = new Circle();
            circle.radius = (double)nud_circle_radius.Value;

            lbl_circle_area.Text = "Area: " + circle.getArea().ToString();
            lbl_circle_circumference.Text = "Circumference: " + circle.getCircumference().ToString();
        }
    }
}
