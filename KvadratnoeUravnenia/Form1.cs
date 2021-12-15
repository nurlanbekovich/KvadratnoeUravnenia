using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KvadratnoeUravnenia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            guna2TextBox1.Focus();
        }
        public static List<double> KvadU(double a,double b, double c)
        {
            if (a == 0)
            {
                throw new Exception("При нулевом значении первого коэффициента квадратного уравнения, оно становится линейным, измените значение первого коэффициента.");
            }
            
                List<double> ls = new List<double>();
                double d = b * b - 4 * a * c;
                if (d < 0)
                {
                    ls.Add(d);
                }
                else if (d == 0)
                {
                    double x = (-b / (2 * a));
                    ls.Add(d);
                    ls.Add(x);
                }
                else
                {
                    double x1 = ((-b - Math.Sqrt(d)) / (2 * a));
                    double x2 = ((-b + Math.Sqrt(d)) / (2 * a));
                    ls.Add(d);
                    ls.Add(x1);
                    ls.Add(x2);
                }
                return ls;
            
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(guna2TextBox1.Text) && string.IsNullOrEmpty(guna2TextBox2.Text) && string.IsNullOrEmpty(guna2TextBox3.Text))
            {
                label5.Visible = true;
                label5.Text = "Пожалуйста введите данные!";
                label5.ForeColor = Color.Red;
            }
            else if (string.IsNullOrEmpty(guna2TextBox1.Text))
            {
                label5.Visible = true;
                label5.Text = "Введите а!";
                label5.ForeColor = Color.Red;
            }
            else if (string.IsNullOrEmpty(guna2TextBox2.Text))
            {
                label5.Visible = true;
                label5.Text = "Введите b!";
                label5.ForeColor = Color.Red;
            }
            else if (string.IsNullOrEmpty(guna2TextBox3.Text))
            {
                label5.Visible = true;
                label5.Text = "Введите c!";
                label5.ForeColor = Color.Red;
            }
            else
            {
                if (guna2TextBox1.Text == "0")
                {
                    label3.ForeColor = Color.Red;
                    label3.Text = "Коэффициент при первом слагаемом (а)\n не может быть равным нулю\n измените его и попробуйте снова.";
                }
                else
                {
                    label5.Visible = false;

                    double a = Convert.ToDouble(guna2TextBox1.Text);
                    double b = Convert.ToDouble(guna2TextBox2.Text);
                    double c = Convert.ToDouble(guna2TextBox3.Text);
                    double d = b * b - 4 * a * c;
                    if (d < 0)
                    {
                        label3.Text = "D=" + d + "\nДискриминант меньше нуля.Корней нет!";
                        label3.ForeColor = Color.Red;
                    }
                    else if (d == 0)
                    {
                        double x = (-b / (2 * a));
                        label3.Text = a + "x^2+" + b + "x+" + c + "=0\nНайдем дискриминант квадратного уравнения:\nD=b^2-4ac=" + b + "^2-" + "4*" + a + "*" + c + "=" + d + "\nТак как дискриминант равен нулю то,квадратное\nуравнения имеет один действительных корень:\nx=" + x;
                        label3.ForeColor = Color.Black;
                    }
                    else
                    {
                        label3.ForeColor = Color.Black;
                        double x1 = ((-b - Math.Sqrt(d)) / (2 * a));
                        double x2 = ((-b + Math.Sqrt(d)) / (2 * a));
                        label3.Text = a + "x^2+" + b + "x+" + c + "=0\nНайдем дискриминант квадратного уравнения:\nD=b^2-4ac=" + b + "^2-" + "4*" + a + "*" + c + "=" + d + "\nТак как дискриминант больше нулья то,квадратное\nуравнения имеет два действительных корня:\nx1=" + x1 + "\nx2=" + x2;
                    }
                }

            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            guna2TextBox1.Clear();
            guna2TextBox2.Clear();
            guna2TextBox3.Clear();
            label3.Text = "";
            label5.Text = "";

        }

        private void guna2TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != ',' && ch != 'e' && ch != '+')
            {
                label5.Text = "Ввод символов и букв запрещена!";
                label5.ForeColor = Color.Red;
                e.Handled = true;
            }
            else
            {
                label5.Text = "";
            }
            if ((e.KeyChar == ','))
            {
                if (guna2TextBox1.Text.IndexOf(',') != -1)
                {
                    e.Handled = true;
                }
                return;
            }
            if ((e.KeyChar == 'e'))
            {
                if (guna2TextBox1.Text.IndexOf('e') != -1)
                {
                    e.Handled = true;
                }
                return;
            }
            if ((e.KeyChar == '+'))
            {
                if (guna2TextBox1.Text.IndexOf('+') != -1)
                {
                    e.Handled = true;
                }
                return;
            }
        }

        private void guna2TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != ',' && ch != 'e' && ch != '+')
            {
                label5.Text = "Ввод символов и букв запрещена!";
                label5.ForeColor = Color.Red;
                e.Handled = true;
            }
            else
            {
                label5.Text = "";
            }
            if ((e.KeyChar == ','))
            {
                if (guna2TextBox2.Text.IndexOf(',') != -1)
                {
                    e.Handled = true;
                }
                return;
            }
            if ((e.KeyChar == 'e'))
            {
                if (guna2TextBox2.Text.IndexOf('e') != -1)
                {
                    e.Handled = true;
                }
                return;
            }
            if ((e.KeyChar == '+'))
            {
                if (guna2TextBox2.Text.IndexOf('+') != -1)
                {
                    e.Handled = true;
                }
                return;
            }
        }

        private void guna2TextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != ',' && ch != 'e' && ch != '+')
            {
                label5.Text = "Ввод символов и букв запрещена!";
                label5.ForeColor = Color.Red;
                e.Handled = true;
            }
            else
            {
                label5.Text = "";
            }
            if ((e.KeyChar == ','))
            {
                if (guna2TextBox3.Text.IndexOf(',') != -1)
                {
                    e.Handled = true;
                }
                return;
            }
            if ((e.KeyChar == 'e'))
            {
                if (guna2TextBox3.Text.IndexOf('e') != -1)
                {
                    e.Handled = true;
                }
                return;
            }
            if ((e.KeyChar == '+'))
            {
                if (guna2TextBox3.Text.IndexOf('+') != -1)
                {
                    e.Handled = true;
                }
                return;
            }
        }
    }
}
