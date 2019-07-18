using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class SINCalculator: IOneArgumentCalculator
    {
        public double Calculate(double firstValue)
        {
            return Math.Sin(firstValue);
        }
        
    }
}
