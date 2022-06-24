using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Endassignment
{
    class Journey
    {
        private double Kilometers;
        private double Seconds;
        private double result;

       

        public Journey(double kil, double secs)
        {

            Kilometers = kil;
            Seconds = secs;

            result = Kilometers*0.5 + Seconds*0.17;

        }

        public double Result
        {
            get
            {
                return result;
            }
            protected set
            {
                result = value;
            }
        }

       
    }
    
      
}
