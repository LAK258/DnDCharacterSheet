using System;
using System.Collections.Generic;
using System.Text;

namespace DnDCharacter
{
    class UtilityMethods
    {
        public string ReadTextInput(string aMessage)
        {
            string returnValue;

            Console.WriteLine(aMessage);
            returnValue = Console.ReadLine();

            return returnValue;
        }

        public int ReadNumericInput(string aMessage)
        {
            int returnvalue;

            Console.WriteLine(aMessage);
            returnvalue = Convert.ToInt32(Console.ReadLine());

            return returnvalue;
        }
    }
}
