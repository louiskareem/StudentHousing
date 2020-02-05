using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentHousingBv
{
    public class Grocery
    {
        // Properties
        public String StudentName
        {
            get;
            set;
        }

        public double Price
        {
            get;
            set;
        }

        /**
         * Method to add a grocery
         */
        public void AddGrocery( string studentName, double price )
        {
            this.StudentName = studentName;
            this.Price = price;
        }

        /**
         * Method to calculate the total amount that needs to be split
         */
        public double CalculateAmount(double total, int count)
        {
            return this.Price = total /= count;
        }

        /**
         * Method to get the amount information
         */
        public String GetAmountInfo()
        {
            return String.Format( "€ {0:N2}", Price );
        }
    }
}
