using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace V1._0
{
    public partial class Form1 : Form
    {
        double firstNum;
        string operation;
        double secondNum;
        double result; 
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0" || textBox.Text == operation)
            {
                textBox.Text = "1";
            }
            else
            {
                textBox.Text = textBox.Text + "1";
            } 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0" || textBox.Text == operation)
            {
                textBox.Text = "2";
            }
            else
            {
                textBox.Text = textBox.Text + "2";
            } 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0" || textBox.Text == operation)
            {
                textBox.Text = "3";
            }
            else
            {
                textBox.Text = textBox.Text + "3";
            } 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0" || textBox.Text == operation)
            {
                textBox.Text = "4";
            }
            else
            {
                textBox.Text = textBox.Text + "4";
            } 
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0" || textBox.Text == operation)
            {
                textBox.Text = "5";
            }
            else
            {
                textBox.Text = textBox.Text + "5";
            } 
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0" || textBox.Text ==operation)
            {
                textBox.Text = "6";
            }
            else
            {
                textBox.Text = textBox.Text + "6";
            } 
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0" || textBox.Text == operation)
            {
                textBox.Text = "7";
            }
            else
            {
                textBox.Text = textBox.Text + "7";
            } 
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0" || textBox.Text == operation)
            {
                textBox.Text = "8";
            }
            else
            {
                textBox.Text = textBox.Text + "8";
            } 
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0" || textBox.Text == operation)
            {
                textBox.Text = "9";
            }
            else
            {
                textBox.Text = textBox.Text + "9";
            } 
        }

        private void zero_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "0";
        }
        private void point_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + ".";
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (firstNum == 0.0)
            {
                firstNum = Convert.ToDouble(textBox.Text);
            }
            else
            {
                secondNum = Convert.ToDouble(textBox.Text);
                if (operation == "+")
                {
                    result = (firstNum + secondNum);
                    textBox.Text = Convert.ToString(result);;
                    firstNum = result;

                }
                else if (operation == "-")
                {
                    result = (firstNum - secondNum);
                    textBox.Text = Convert.ToString(result);
                    firstNum = result;
                }
                else if (operation == "*")
                {
                    result = (firstNum * secondNum);
                    textBox.Text = Convert.ToString(result);
                    firstNum = result;
                }
                else if (operation == "/")
                {
                    if (secondNum == 0)
                    {
                        textBox.Text = "Cannot divide by zero";

                    }
                    else
                    {
                        result = (firstNum / secondNum);
                        textBox.Text = Convert.ToString(result);
                        firstNum = result;
                    }

                }
                else if(operation == "^")
                {
                    result = Math.Pow(firstNum, secondNum);
                    textBox.Text = Convert.ToString(result);
                    firstNum = result;
                }
            }
            textBox.Text = Add.Text;
            operation = "+";
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            if (firstNum == 0.0)
            {
                firstNum = Convert.ToDouble(textBox.Text);
            }
            else
            {
                secondNum = Convert.ToDouble(textBox.Text);
                if (operation == "+")
                {
                    result = (firstNum + secondNum);
                    textBox.Text = Convert.ToString(result);
                    firstNum = result;
                }
                else if (operation == "-")
                {
                    result = (firstNum - secondNum);
                    textBox.Text = Convert.ToString(result);
                    firstNum = result;
                }
                else if (operation == "*")
                {
                    result = (firstNum * secondNum);
                    textBox.Text = Convert.ToString(result);
                    firstNum = result;
                }
                else if (operation == "/")
                {
                    if (secondNum == 0)
                    {
                        textBox.Text = "Cannot divide by zero";

                    }
                    else
                    {
                        result = (firstNum / secondNum);
                        textBox.Text = Convert.ToString(result);
                        firstNum = result;
                    }
                }
                else if (operation == "^")
                {
                    result = Math.Pow(firstNum, secondNum);
                    textBox.Text = Convert.ToString(result);
                    firstNum = result;
                }
            }
            textBox.Text = Minus.Text;
            operation = "-";
        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            if (firstNum == 0.0)
            {
                firstNum = Convert.ToDouble(textBox.Text);
            }
            else
            {
                secondNum = Convert.ToDouble(textBox.Text);
                if (operation == "+")
                {
                    result = (firstNum + secondNum);
                    textBox.Text = Convert.ToString(result);
                    firstNum = result;

                }
                else if (operation == "-")
                {
                    result = (firstNum - secondNum);
                    textBox.Text = Convert.ToString(result);
                    firstNum = result;
                }
                else if (operation == "*")
                {
                    result = (firstNum * secondNum);
                    textBox.Text = Convert.ToString(result);
                    firstNum = result;
                }
                else if (operation == "/")
                {
                    if (secondNum == 0)
                    {
                        textBox.Text = "Cannot divide by zero";

                    }
                    else
                    {
                        result = (firstNum / secondNum);
                        textBox.Text = Convert.ToString(result);
                        firstNum = result;
                    }
                }
                else if (operation == "^")
                {
                    result = Math.Pow(firstNum, secondNum);
                    textBox.Text = Convert.ToString(result);
                    firstNum = result;
                }
            }
            textBox.Text = Multiply.Text;
            operation = "*";
        }

        private void Div_Click(object sender, EventArgs e)
        {
            if (firstNum == 0.0)
            {
                firstNum = Convert.ToDouble(textBox.Text);
            }
            else
            {
                secondNum = Convert.ToDouble(textBox.Text);
                if (operation == "+")
                {
                    result = (firstNum + secondNum);
                    textBox.Text = Convert.ToString(result);
                    firstNum = result;

                }
                else if (operation == "-")
                {
                    result = (firstNum - secondNum);
                    textBox.Text = Convert.ToString(result);
                    firstNum = result;
                }
                else if (operation == "*")
                {
                    result = (firstNum * secondNum);
                    textBox.Text = Convert.ToString(result);
                    firstNum = result;
                }
                else if (operation == "/")
                {
                    if (secondNum == 0)
                    {
                        textBox.Text = "Cannot divide by zero";

                    }
                    else
                    {
                        result = (firstNum / secondNum);
                        textBox.Text = Convert.ToString(result);
                        firstNum = result;
                    }
                }
                else if (operation == "^")
                {
                    result = Math.Pow(firstNum, secondNum);
                    textBox.Text = Convert.ToString(result);
                    firstNum = result;
                }
            }
            textBox.Text = Div.Text;
            operation = "/";
        }

        private void Equal_Click(object sender, EventArgs e)
        {
            secondNum = Convert.ToDouble(textBox.Text);

            if (operation == "+")
            {
                result = (firstNum + secondNum);
                textBox.Text = Convert.ToString(result);
                firstNum = 0.0;
            }
            else if (operation == "-")
            {
                result = (firstNum - secondNum);
                textBox.Text = Convert.ToString(result);
                firstNum = 0.0;
            }
            else if (operation == "*")
            {
                result = (firstNum * secondNum);
                textBox.Text = Convert.ToString(result);
                firstNum = 0.0;
            }
            else if (operation == "/")
            {
                if (secondNum == 0)
                {
                    textBox.Text = "Cannot divide by zero";

                }
                else
                {
                    result = (firstNum / secondNum);
                    textBox.Text = Convert.ToString(result);
                    firstNum = 0.0;
                }
            }
            else if(operation == "x2")
            {
                result = Math.Sqrt(firstNum);
                textBox.Text = Convert.ToString(result);
                firstNum = 0.0;
            }
            else if(operation == "^")
            {
                result = Math.Pow(firstNum, secondNum);
                textBox.Text = Convert.ToString(result);
                firstNum = 0.0;
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            textBox.Clear();
        }

        private void BackSpace_Click(object sender, EventArgs e)
        {
            textBox.Text = Convert.ToString(textBox.Text.Length - 1);
        }

        private void square_Click(object sender, EventArgs e)
        {
            firstNum = Convert.ToDouble(textBox.Text);
            result = Math.Sqrt(firstNum);
            textBox.Text = Convert.ToString(result);
            firstNum = result;

        }

        private void cube_Click(object sender, EventArgs e)
        {
            firstNum = Convert.ToDouble(textBox.Text);
            result = Math.Ceiling(Math.Pow(firstNum, (double)1 / 3));
            textBox.Text = Convert.ToString(result);
            firstNum = result;
        }

        private void caret_Click(object sender, EventArgs e)
        {
            if (firstNum == 0.0)
            {
                firstNum = Convert.ToDouble(textBox.Text);
            }
            else
            {
                secondNum = Convert.ToDouble(textBox.Text);
                if (operation == "+")
                {
                    result = (firstNum + secondNum);
                    textBox.Text = Convert.ToString(result);
                    firstNum = result;

                }
                else if (operation == "-")
                {
                    result = (firstNum - secondNum);
                    textBox.Text = Convert.ToString(result);
                    firstNum = result;
                }
                else if (operation == "*")
                {
                    result = (firstNum * secondNum);
                    textBox.Text = Convert.ToString(result);
                    firstNum = result;
                }
                else if (operation == "/")
                {
                    if (secondNum == 0)
                    {
                        textBox.Text = "Cannot divide by zero";

                    }
                    else
                    {
                        result = (firstNum / secondNum);
                        textBox.Text = Convert.ToString(result);
                        firstNum = result;
                    }
                }
                else if(operation == "^")
                {
                    result = Math.Pow(firstNum, secondNum);
                    textBox.Text = Convert.ToString(result);
                    firstNum = result;
                }
            }
            textBox.Text = caret.Text;
            operation = "^";
           
        }
    }
}
