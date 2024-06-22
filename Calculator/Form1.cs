using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string SelectOperetor = "";
        double PriviousValue;
        string history;
        private void buttonClick(object sender, EventArgs e)
        {
            if(TBresult.Text == "0")
            {
                TBresult.Clear();
            }
            Button button = (Button)sender;
            if(button.Text == ".")
            {
                if (!TBresult.Text.Contains("."))
                {

                 TBresult.Text = TBresult.Text + button.Text;
                }
            }
            else { TBresult.Text = TBresult.Text + button.Text; }
        }
        private void OperatorClck(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            SelectOperetor = btn.Text;
            PriviousValue = double.Parse(TBresult.Text);
            history = TBresult.Text + SelectOperetor;
            LBresult.Text = history;
            TBresult.Clear() ;                     
        }

        private void button16_Click(object sender, EventArgs e)
        {
            double result;
            switch (SelectOperetor)
            {
                case "+":
                    result = PriviousValue + double.Parse(TBresult.Text);
                    LBresult.Text = history + TBresult.Text.ToString();
                    TBresult.Text = result.ToString();

                    break;
                case "-":
                    result = PriviousValue - double.Parse(TBresult.Text);
                    LBresult.Text = history + TBresult.Text.ToString();
                    TBresult.Text = result.ToString();
                    break;
                case "*":
                    result = PriviousValue * double.Parse(TBresult.Text);
                    LBresult.Text = history + TBresult.Text.ToString();
                    TBresult.Text = result.ToString();
                    break;
                case "/":
                    result = PriviousValue / double.Parse(TBresult.Text);
                    LBresult.Text = history + TBresult.Text.ToString();
                    TBresult.Text = result.ToString();

                    break;
                default:
                    result = PriviousValue + double.Parse(TBresult.Text);
                    TBresult.Text = result.ToString();
                    break;

            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            TBresult.Text = "";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            TBresult.Clear();
            LBresult.Text = "";
        }

        private void TBresult_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
