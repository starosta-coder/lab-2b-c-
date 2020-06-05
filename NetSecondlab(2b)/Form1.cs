using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Laba4_13var
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            textBoxResult.Text= GetTringale().ToString();
        }

        private Triangle GetTringale()
        {
            double a = 0, b = 0, c = 0;
            try
            {
                a = Double.Parse(textboxFirstSide.Text);
                b = Double.Parse(textBoxSecondSide.Text);
                c = Double.Parse(textBoxThirdSide.Text);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            return new Triangle(a, b, c);
        }

        private void buttonUpload_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            FileStream file1 = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
            // Создаем двоичный поток для записи
            BinaryReader binery = new BinaryReader(file1, System.Text.Encoding.UTF8);
            string result = binery.ReadString();
            binery.Close();
            file1.Close();
            Triangle triangle = GetFromString(result);
            textboxFirstSide.Text = triangle.A.ToString();
            textBoxSecondSide.Text = triangle.B.ToString();
            textBoxThirdSide.Text = triangle.C.ToString();
            textBoxResult.Text = GetTringale().ToString();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        { 
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            FileStream file = new FileStream(saveFileDialog1.FileName, FileMode.OpenOrCreate, FileAccess.Write);
            // Создаем двоичный поток для записи
            BinaryWriter bw = new BinaryWriter(file, System.Text.Encoding.UTF8);
            string result = GetTringale().BineryWrite();
            bw.Write(result);
            bw.Close();
            file.Close();
        }
        private Triangle GetFromString(string result)
        {
            char temp = ' ';
            int[] indexes = new int[3];
            string temptemp = result;
            for (int i = 0; i < 2; i++)
            {
                indexes[i] = temptemp.IndexOf(temp);
                temptemp = temptemp.Substring(temptemp.IndexOf(temp) + 1);
            }

            double b = Double.Parse(result.Substring(0, indexes[0]));
            result = result.Substring(indexes[0] + 1);
            double a = double.Parse(result.Substring(0, indexes[1]));
            result = result.Substring(indexes[1] + 1);
            double c = Double.Parse(result.Substring(0));

            return new Triangle(b,a,c);
        }
    }
}
