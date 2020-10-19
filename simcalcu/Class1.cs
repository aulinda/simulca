using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simcalcu
{
    public delegate int GetAnswer(int num1, int num2);
    class Class1
    {
        public delegate int GetAnswer(int num1, int num2);
        public static int getAdd(int num1, int num2)
        {
            return num1 + num2;
        }
        public static int getDiff(int num1, int num2)
        {
            return num1 - num2;
        }
        public static int getMul(int num1, int num2)
        {
            return num1 * num2;
        }
        public static int getDiv(int num1, int num2)
        {
            return num1 / num2;
        }
    }
}
    

