using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Budget
{
    public partial class Form1 : Form
    {
        const int size = 99;
        int[] housArray = new int[size];
        int[] entArray = new int[size];
        int[] transArray = new int[size];
        int[] grocArray = new int[size];
        int[] miscArray = new int[size];        

        public Form1()
        {
            InitializeComponent();
        }

        private int AddToHous(int chargeAmt)
        {
            int index = 0;
            housArray[index] = chargeAmt;
            index++;
            int housSum = housArray.Sum();
            return housSum;
        }

        private int AddToEnt(int chargeAmt)
        {
            int index = 0;
            entArray[index] = chargeAmt;
            index++;
            int sum = entArray.Sum();
            return sum;
        }
       
        private int AddToGroc(int chargeAmt)
        {
            int index = 0;
            grocArray[index] = chargeAmt;
            index++;
            int sum = grocArray.Sum();
            return sum;
        }

        private int AddToTrans(int chargeAmt)
        {
            int index = 0;
            transArray[index] = chargeAmt;
            index++;
            int sum = transArray.Sum();
            return sum;
        }

        private int AddToMisc(int chargeAmt)
        {
            int index = 0;
            miscArray[index] = chargeAmt;
            index++;
            int sum = miscArray.Sum();
            return sum;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            housBtn.Checked = false;
            entBtn.Checked = false;
            grocBtn.Checked = false;
            transBtn.Checked = false;
            miscBtn.Checked = false;
            amtBox.Text = " ";
        }

        private void checkBtn_Click(object sender, EventArgs e)
        {
            int housSum = housArray.Sum();
            int entSum = entArray.Sum();
            int grocSum = grocArray.Sum();
            int transSum = transArray.Sum();
            int miscSum = miscArray.Sum();
            int totalSpent = housSum + entSum + grocSum + transSum + miscSum;
            MessageBox.Show("You have spent $" + housSum + " of your $1000 housing budget.");
            MessageBox.Show("You have spent $" + entSum + " of your $200 entertainment budget.");
            MessageBox.Show("You have spent $" + grocSum + " of your $500 grocery budget.");
            MessageBox.Show("You have spent $" + transSum + " of your $250 transportation budget.");
            MessageBox.Show("You have spent $" + miscSum + " of your $100 miscellaneous budget.");
            MessageBox.Show("You have spent $" + totalSpent + " of your total budget.");
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                double input = double.Parse(amtBox.Text);
                int newCharge = Convert.ToInt32(input);

                if (housBtn.Checked = true)
                {
                    int housSum = AddToHous(newCharge);
                }

                else if (entBtn.Checked = true)
                {
                    int entSum = AddToEnt(newCharge);
                }

                else if (grocBtn.Checked = true)
                {
                    int grocSum = AddToGroc(newCharge);
                }

                else if (transBtn.Checked = true)
                {
                    int transSum = AddToTrans(newCharge);
                }

                else if (miscBtn.Checked = true)
                {
                    int miscSum = AddToMisc(newCharge);
                }
            }

            catch
            {
                MessageBox.Show("Please try again.");
            }
        }
    }
}
