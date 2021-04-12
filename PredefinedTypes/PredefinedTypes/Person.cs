using System;
using System.Collections.Generic;
using System.Text;

namespace PredefinedTypes
{
    public class Person
    {
        public string Name;

        public void SayHowManyLetters()
        {
            Console.WriteLine(Name.Length);
        }
    }
}
