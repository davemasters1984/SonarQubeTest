using System;
using System.Collections.Generic;
using System.Text;

namespace SonarQubeTest.Test
{
    class TestClass
    {
        public string One { get; set; }
        public string Two { get; set; }
        public string Three { get; set; }
        public string Four { get; set; }
        public string Five { get; set; }

        public TestClass(string one, string two, string three, string four, string five)
        {
            One = one;
            Two = two;
            Three = three;
            Four = four;
            Five = five;

            //Test

            if (five == null)
            {
                five.ToString();
            }
        }


    }
}
