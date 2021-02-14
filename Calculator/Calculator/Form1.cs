using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/****************************************************************
    Juan Rodriguez
    CIST 2341
    C# Programming 1
    Lab #5
simple calculator app
This is my code....
*****************************************************************/

namespace Calculator
{
    public partial class Form1 : Form
    {
        //global variable
        int storeAnswer;
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
    // first Check if a text box is empty
            if (input1.Text == "" || input2.Text == "")
            {
                MessageBox.Show("Enter a number!");

            }
    //by using else-if we avoid an error from stoping our program when textbox is empty
            else if (addBtn.Checked)
            {
               
                double answer;
                double inputOne;
                double inputTwo;

                inputOne = Double.Parse(input1.Text);
                inputTwo = Double.Parse(input2.Text);

                answer = inputOne + inputTwo;

                answerBox.Text = "" + answer;

            }
           else if (subtractBtn.Checked)
            {
                double answer;
                double inputOne;
                double inputTwo;

                inputOne = Double.Parse(input1.Text);
                inputTwo = Double.Parse(input2.Text);

                answer = inputOne - inputTwo;

                answerBox.Text = "" + answer;
            }
            else if (multiplyBtn.Checked)
            {
                double answer;
                double inputOne;
                double inputTwo;

                inputOne = Double.Parse(input1.Text);
                inputTwo = Double.Parse(input2.Text);

                answer = inputOne * inputTwo;

                answerBox.Text = "" + answer;
            }
            else if (divideBtn.Checked)
            {
                double answer;
                double inputOne;
                double inputTwo;

                inputOne = Double.Parse(input1.Text);
                inputTwo = Double.Parse(input2.Text);

                answer = inputOne / inputTwo;

                answerBox.Text = "" + answer;
            }
        }
// Buttons calculate btn ,clear btn, exit btn, background color button, and button color button
        private void clearBtn_Click(object sender, EventArgs e)
        {
            input1.Text = "";
            input2.Text = "";
            answerBox.Text = "";
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            String message = "Are you sure you want to exit?";
            String caption = "App closing";
            DialogResult answer = MessageBox.Show(message, caption, MessageBoxButtons.YesNo);

            if (answer == DialogResult.Yes)
            {
                Application.Exit();
            }
            if (answer == DialogResult.No)
            {

            }
        }

        private void colorBtn_Click(object sender, EventArgs e)
        {
            if (colorPicker.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = colorPicker.Color;
            }
        }

        private void btnColorPicker_Click(object sender, EventArgs e)
        {
            if (colorPicker.ShowDialog() == DialogResult.OK)
            {
                calculateBtn.BackColor = colorPicker.Color;
                clearBtn.BackColor = colorPicker.Color;
                exitBtn.BackColor = colorPicker.Color;

            }
        }
        // MENU ITEMS background-color, button color, calculate, exit, and Help with sub-menu about
        private void backgroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorPicker.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = colorPicker.Color;
            }
        }

        private void buttonColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorPicker.ShowDialog() == DialogResult.OK)
            {
                calculateBtn.BackColor = colorPicker.Color;
                clearBtn.BackColor = colorPicker.Color;
                exitBtn.BackColor = colorPicker.Color;

            }
        }

        private void calculateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // first Check if a text box is empty
            if (input1.Text == "" || input2.Text == "")
            {
                MessageBox.Show("Enter a number!");

            }
            //by using else-if we avoid an error from stoping our program when textbox is empty
            else if (addBtn.Checked)
            {

                double answer;
                double inputOne;
                double inputTwo;

                inputOne = Double.Parse(input1.Text);
                inputTwo = Double.Parse(input2.Text);

                answer = inputOne + inputTwo;

                answerBox.Text = "" + answer;

            }
            else if (subtractBtn.Checked)
            {
                double answer;
                double inputOne;
                double inputTwo;

                inputOne = Double.Parse(input1.Text);
                inputTwo = Double.Parse(input2.Text);

                answer = inputOne - inputTwo;

                answerBox.Text = "" + answer;
            }
            else if (multiplyBtn.Checked)
            {
                double answer;
                double inputOne;
                double inputTwo;

                inputOne = Double.Parse(input1.Text);
                inputTwo = Double.Parse(input2.Text);

                answer = inputOne * inputTwo;

                answerBox.Text = "" + answer;
            }
            else if (divideBtn.Checked)
            {
                double answer;
                double inputOne;
                double inputTwo;

                inputOne = Double.Parse(input1.Text);
                inputTwo = Double.Parse(input2.Text);

                answer = inputOne / inputTwo;

                answerBox.Text = "" + answer;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String message = "Are you sure you want to exit?";
            String caption = "App closing";
            DialogResult answer = MessageBox.Show(message, caption, MessageBoxButtons.YesNo);

            if (answer == DialogResult.Yes)
            {
                Application.Exit();
            }
            if (answer == DialogResult.No)
            {

            }
        }
// About menu item message box
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String message = "This calculator was created by Juan Rodriguez.";
            DialogResult  = MessageBox.Show(message);
        }

        private void forLoopBtn_Click(object sender, EventArgs e)
        {

            for (int count = 0; count < 10; count += 1) 
            {
                Console.WriteLine("Go Falcons");
            }
            
        }

        private void whileLoopBtn_Click(object sender, EventArgs e)
        {
            int i = 0;
            while (i < 10)
            {
                Console.WriteLine("Go Falcons");
                i = i + 1;
            }
        }

        private void memoryBtn_Click(object sender, EventArgs e)
        {
            storeAnswer = int.Parse(answerBox.Text);
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(memoryBox, storeAnswer.ToString());
        }

        private void memoryAddBtn_Click(object sender, EventArgs e)
        {
            storeAnswer += int.Parse(answerBox.Text);
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(memoryBox, DialogResult.ToString());
        }
    }
}
