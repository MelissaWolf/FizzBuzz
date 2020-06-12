using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FizzBuzz
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 20; i++)
            {

                if (i % 3 == 0 && i % 5 == 0)
                {
                    ListBox.Items.Add("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    ListBox.Items.Add("Fizz");
                }
                else if (i % 5 == 0)
                {
                    ListBox.Items.Add("Buzz");
                }
                else
                {
                    ListBox.Items.Add(i);
                }

            }

        }

        private void MoneyBtn_Click(object sender, EventArgs e)
        {
            int change = 0;
            int prevChange = Int32.Parse(TotMoneyBox.Text);
            int boxNum = 0;

            int FuncChange(int dollar) {
                change = prevChange % dollar;
                boxNum = prevChange - change;
                prevChange = prevChange - boxNum;
                boxNum = boxNum / dollar;
                return(change);
            }

            FuncChange(100);
            HundredBox.Text = "" + boxNum;

            FuncChange(50);
            FiftyBox.Text = "" + boxNum;

            FuncChange(20);
            TwentyBox.Text = "" + boxNum;

            FuncChange(10);
            TenBox.Text = "" + boxNum;

            FuncChange(5);
            FiveBox.Text = "" + boxNum;

            FuncChange(2);
            TwoBox.Text = "" + boxNum;

            FuncChange(1);
            OneBox.Text = "" + boxNum;

            /*
            change = prevChange % 100;
            boxNum = prevChange - change;
            prevChange = prevChange - boxNum;
            boxNum = boxNum / 100;
            HundredBox.Text = "" + boxNum;

            change = prevChange % 50;
            boxNum = prevChange - change;
            prevChange = prevChange - boxNum;
            boxNum = boxNum / 50;
            FiftyBox.Text = "" + boxNum;

            change = prevChange % 20;
            boxNum = prevChange - change;
            prevChange = prevChange - boxNum;
            boxNum = boxNum / 20;
            TwentyBox.Text = "" + boxNum;

            change = prevChange % 10;
            boxNum = prevChange - change;
            prevChange = prevChange - boxNum;
            boxNum = boxNum / 10;
            TenBox.Text = "" + boxNum;

            change = prevChange % 5;
            boxNum = prevChange - change;
            prevChange = prevChange - boxNum;
            boxNum = boxNum / 5;
            FiveBox.Text = "" + boxNum;

            change = prevChange % 2;
            boxNum = prevChange - change;
            prevChange = prevChange - boxNum;
            boxNum = boxNum / 2;
            TwoBox.Text = "" + boxNum;

            change = prevChange % 1;
            boxNum = prevChange - change;
            prevChange = prevChange - boxNum;
            boxNum = boxNum / 1;
            OneBox.Text = "" + boxNum;
            */

        }
    }
}
