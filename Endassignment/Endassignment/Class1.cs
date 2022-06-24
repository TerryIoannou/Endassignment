using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Endassignment
{
    public class Taxis

    {
        private string driver;
        private int driverId;
        private string title;

        public Taxis(string driver, int driverId)
        {
            this.driver = driver;
            this.driverId = driverId;

            title = "hello  " + driver + "  your ID is  "+ driverId;

        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }
    }

}

    
       


   

