using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetSecondlab_2b_
{
    public partial class Form1 : Form
    {
        Triangls triangls;
        int i = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void savePointBtn_Click(object sender, EventArgs e)
        {
            i = i + 1;
            try 
            {
                Point point1 = new Point(x2NameBox.Text, Int32.Parse(x2TextBox.Text), Int32.Parse(y2TextBox.Text));
                Point point3 = new Point(x3NameBox.Text, Int32.Parse(x3TextBox.Text), Int32.Parse(y3TextBox.Text));
                Point point2 = new Point(x1NameBox.Text, Int32.Parse(x1TextBox.Text), Int32.Parse(y1TextBox.Text));

                Triangle triangle = new Triangle(i, point1, point2, point3);


                TriangleNumBox.Clear();
                TriangleNumBox.AppendText(i + "");

                if (triangle.IsTriangle())
                    triangls.addTriangle(i, triangle.getS(), triangle.IsOrthogonal());
                else
                {
                    i = i - 1;
                    if (i < 1)
                    {
                        TriangleNumBox.Clear();
                        TriangleNumBox.AppendText("1");
                    }

                }

                richTextTriengleInfo.AppendText(triangle.ToString());

                if (i == Int32.Parse(AmoutTextBox.Text))
                {
                    x1NameBox.Enabled = false;
                    x1TextBox.Enabled = false;
                    y1TextBox.Enabled = false;

                    x2NameBox.Enabled = false;
                    x2TextBox.Enabled = false;
                    y2TextBox.Enabled = false;

                    x3NameBox.Enabled = false;
                    x3TextBox.Enabled = false;
                    y3TextBox.Enabled = false;

                    savePointBtn.Enabled = false;
                    TriangleNumBox.Enabled = false;

                    richTextTriengleInfo.AppendText(triangls.ReturnResult());
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
                i = i - 1;
            }

            x1NameBox.Clear();
            x1TextBox.Clear();
            y1TextBox.Clear();

            x2NameBox.Clear();
            x2TextBox.Clear();
            y2TextBox.Clear();

            x3NameBox.Clear();
            x3TextBox.Clear();
            y3TextBox.Clear();
        }
        private void InitAmoutBtn_Click(object sender, EventArgs e)
        {
            try
            {
                triangls = new Triangls(Int32.Parse(AmoutTextBox.Text));

                x1NameBox.Enabled = true;
                x1TextBox.Enabled = true;
                y1TextBox.Enabled = true;

                x2NameBox.Enabled = true;
                x2TextBox.Enabled = true;
                y2TextBox.Enabled = true;

                x3NameBox.Enabled = true;
                x3TextBox.Enabled = true;
                y3TextBox.Enabled = true;

                savePointBtn.Enabled = true;
                TriangleNumBox.Enabled = true;

                AmoutLabel.Enabled = false;
                InitAmoutBtn.Enabled = false;

                ResetBtn.Enabled = true;

                TriangleNumBox.AppendText(1 + "");
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void RndFillBtn_Click(object sender, EventArgs e)
        {
            ResetBtn.Enabled = true;

            triangls = new Triangls(4);

            Point point1 = new Point("A", 2, 3);
            Point point2 = new Point("B", -1, 5);
            Point point3 = new Point("C", 2, 4);

            Triangle triangle1 = new Triangle(1, point1, point2, point3);

            triangls.addTriangle(1, triangle1.getS(), triangle1.IsOrthogonal());

            richTextTriengleInfo.AppendText(triangle1.ToString());

            Point point4 = new Point("D", 23, 4);
            Point point5 = new Point("E", 3, 45);
            Point point6 = new Point("F", 3, 2);

            Triangle triangle2 = new Triangle(2, point4, point5, point6);

            triangls.addTriangle(2, triangle2.getS(), triangle2.IsOrthogonal());

            richTextTriengleInfo.AppendText(triangle2.ToString());

            Point point7 = new Point("G", -3, 4);
            Point point8 = new Point("H", -1, 0);
            Point point9 = new Point("I", 0, 3);

            Triangle triangle3 = new Triangle(3, point7, point8, point9);

            triangls.addTriangle(3, triangle3.getS(), triangle3.IsOrthogonal());

            richTextTriengleInfo.AppendText(triangle3.ToString());

            Point point10 = new Point("J", -3, 4);
            Point point11 = new Point("K", -1, 0);
            Point point12 = new Point("L", 0, 3);

            Triangle triangle4 = new Triangle(4, point10, point11, point12);

            triangls.addTriangle(4, triangle4.getS(), triangle4.IsOrthogonal());

            richTextTriengleInfo.AppendText(triangle4.ToString());


            richTextTriengleInfo.AppendText(triangls.ReturnResult());
        }
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.webmath.ru/poleznoe/table_cosinus.php");
        }
        private void ResetBtn_Click_1(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
