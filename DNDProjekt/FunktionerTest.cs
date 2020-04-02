using System;
using System.Collections.Generic;
using System.Text;

namespace DNDProjekt
{
    class FunktionerTest
    {
        public void print()
        {
            Skill kebab = new Skill(3, 1, 3, 0, 2, 4, 2, new int[] {1, 3, 6, 17});
            
            bool equalSelf = kebab.Equals(kebab);
            equalSelf = Object.Equals(kebab, kebab);

            Console.WriteLine("Result:\n\n" + kebab);
        }         
    }             
}                