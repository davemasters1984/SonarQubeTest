using System;
using System.Collections.Generic;
using System.Text;

namespace SonarQubeTest
{
    class TestClass
    {
        private string _one;
        private string _two;
        private string _three;
        private string _four;
        private string _five;

        public TestClass(string one, string two, string three, string four, string five)
        {
            _one = one;
            _two = two;
            _three = three;
            _four = four;
            _five = five;

            if (five == null)
            {
                five.ToString();
            }
        }
    }
}
