using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitap_napchong_toantu
{
    internal class money
    {
        private double currency;
        private String denomination;
        private long number;

        public static money operator +(money money1,money money2)
        {
            money m3=new money();
            if (money1.currency.Equals(money2.currency))
            {
                m3.denominations = money1.denominations + money2.denominations;
                m3.currency = money1.currency;
                return M3;
            }
            return null; 
        }

        public double Currency
        {
            set { this.currency = value; }
            get { return this.currency; }
        }

        public String denominations
        {
            set { this.denominations = value; }
            get { return this.denominations; }
        }
        public long Number
        {
            set { this.Number = value; }
            get { return this.Number; }
        }
        public money() { }
        public money(double currency, String denominations, long number)
        {
            this.currency = currency;
            this.denominations = denominations;
            this.number = number;

        }
    }
}
