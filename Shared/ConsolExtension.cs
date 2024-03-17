using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public class ConsolExtension
    {
        public static int GetIn(string message)
        {
            Console.Write(message);
            var numberString=Console.ReadLine();
            var numberInt = 0;
            if (int.TryParse(numberString, out numberInt))
            {
                return numberInt;


            }  
            return 0;
        }


    }
}
