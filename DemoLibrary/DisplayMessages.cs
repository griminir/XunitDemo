using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Red, Green, Refactor = write a test that turns red then, do whatever you need to do to turn the light green
// then you refactor

namespace DemoLibrary
{
    public class DisplayMessages
    {
        public string Greeting(string firstName, int hourOfTheDay)
        {
            var output = "";
            if (hourOfTheDay <= 4)
            {
                output = $"Go to bed {firstName}";
            }
            else if (hourOfTheDay < 12)
            {
                output = $"Good morning {firstName}";
            }
            else if (hourOfTheDay < 18)
            {
                output = $"Good afternoon {firstName}";
            }
            else
            {
                output = $"Good evening {firstName}";
            }
            return output;
        }
    }
}
