using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Factorial_Iterative_Recursive
{
    public partial class Form1 : Form
    {
        private string number = "";

        public Form1()
        {
            InitializeComponent();
        }

        static double Iterative(int n)
        {
            double result = 1;
            for (int i = 2; i <= n; i++)
                result *= i;
            return result;
        }

        static double Recursive(int n)
        {
            if (n == 0)
                return 1;
            return n * Recursive(n - 1);
        }

        private void dataBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int.Parse(dataBox.Text);
                if (dataBox.Text.Trim().Length > 3)
                    throw new Exception();
                number = dataBox.Text.Trim();
            }
            catch
            {
                int position = dataBox.SelectionStart;
                dataBox.Text = number.ToString();
                if(position>0)
                    dataBox.SelectionStart = position-1;
            }
        }

        private void iterativeButton_Click(object sender, EventArgs e)
        {
            if (int.Parse(number) >= 0)
                messageLabel.Text = number + "! = " + Iterative(int.Parse(number));
            else
                messageLabel.Text = "Please enter a positive number";
            dataBox.Text = "";
        }

        private void recursiveButton_Click(object sender, EventArgs e)
        {
            if (int.Parse(number) >= 0)
                messageLabel.Text = number + "! = " + Recursive(int.Parse(number));
            else
                messageLabel.Text = "Please enter a positive number";
            dataBox.Text = "";
        }
    }
}
