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

        int FuncChange(int size, int totMoney, out int prevChange)
        {
            var change = totMoney % size; //Checks remainder
            int boxNum = totMoney - change; //Removes the remainder
            boxNum = boxNum / size; //Get total from division
            prevChange = change; //Sets as leftover change
            return boxNum;
        }

        private void MoneyBtn_Click(object sender, EventArgs e)
        {
            int myChange;

            HundredBox.Text = "" + FuncChange(100, Convert.ToInt32(TotMoneyBox.Text), out myChange);

            FiftyBox.Text = "" + FuncChange(50, myChange, out myChange);

            TwentyBox.Text = "" + FuncChange(20, myChange, out myChange);

            TenBox.Text = "" + FuncChange(10, myChange, out myChange);

            FiveBox.Text = "" + FuncChange(5, myChange, out myChange);

            TwoBox.Text = "" + FuncChange(2, myChange, out myChange);

            OneBox.Text = "" + FuncChange(1, myChange, out myChange);

            /* By using a function I avoid all this
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
