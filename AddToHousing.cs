using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget
{
    class AddToHousing
    {
        private int AddNewExpense(int chargeAmt)
        {
            const int size = 99;
            int index = 0;
            int[] housArray = new int[size];
            housArray[index] = chargeAmt;
            int sum = housArray.Sum();
            return sum;       
        }
    }
}
