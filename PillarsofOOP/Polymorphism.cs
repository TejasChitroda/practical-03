using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PillarsofOOP
{
    //Bird : this class is Parent class of Duck class
    class Bird
    {
        // Voice : This method is public and virtual so we can overrid this method in child class
        public virtual void Voice()
        {
            Console.WriteLine("Turr Turr");
        }
    }

    // Duck : this class is child class of Bird class so it is inherite propeties of there parent
    class Duck : Bird
    {
        // Voice : This voice method is overriden from there parent class
        public override void Voice()
        {
            Console.WriteLine("Quack Quack");
        }
    }
}
