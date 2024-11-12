using System;
using System.Windows.Forms;

namespace BasicCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            double num1, num2;

            if (!inputValidation(out num1, out num2)) 
                return;

            double result = num1 + num2;
            txtResult.Text = result.ToString();
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            double num1, num2;

            if (!inputValidation(out num1, out num2))
                return;

            double result = num1 - num2;
            txtResult.Text = result.ToString();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            double num1, num2;

            if (!inputValidation(out num1, out num2))
                return;

            double result = num1 * num2;
            txtResult.Text = result.ToString();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            double num1, num2;

            if (!inputValidation(out num1, out num2))
                return;

            if (num2 == 0)
            {
                MessageBox.Show("Cannot divide by zero", "Invalid Operation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double result = num1 / num2;
            txtResult.Text = result.ToString();

        }

        private bool inputValidation(out double num1, out double num2)
        {
            num1 = 0;
            num2 = 0;

            if(!double.TryParse(txtFirstNumber.Text, out num1))
            {
                MessageBox.Show("Please enter a valid number for the first number", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!double.TryParse(txtSecondNumber.Text, out num2))
            {
                MessageBox.Show("Please enter a valid number for the second number", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFirstNumber.Clear();
            txtSecondNumber.Clear();
            txtResult.Clear();
        }
    }
}
