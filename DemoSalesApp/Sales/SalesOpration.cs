using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSalesApp.Sales
{
    public class SalesOpration
    {

        public double CalculateTaxIncludedTotal(double subTotal,double taxPercentage)
        {          
            if (subTotal > 0)
            {
                if(taxPercentage > 0 && taxPercentage <= 100)
                { 
                    return subTotal + (subTotal * (taxPercentage *  0.01));
                }
                else
                {
                    return subTotal;
                }
            }
            else
            {
                return 0;
            }

        }

    }
}
