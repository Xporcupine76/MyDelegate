using System;
using System.Collections;
using System.Reflection.Metadata.Ecma335;

namespace IEnumerable_Example
{

    class Program
    {
        delegate int del(int x, int y);
        static void Main(string[] args)
        {
/*          Mark mark = new Mark();
            mark.AddNumbers(3, 3);
            mark.MultiplyNumbers(4, 4);
            Console.WriteLine(mark.AddNumbers(3, 3));
            Console.WriteLine(mark.MultiplyNumbers(4, 4));
*/
             Mark mark = new Mark();
            del d = mark.AddNumbers;
            Console.WriteLine(d(3,4));

            d = mark.MultiplyNumbers;
            Console.WriteLine(d(3, 4));

            d = mark.DoAnotherThing;
            Console.WriteLine(d(4,4));

            d = mark.MyTest;
            Console.WriteLine(d(4));
        }
    }
    public class Mark
    {
        public int AddNumbers(int a, int b)
        {

            return a + b;
        }
        public int MultiplyNumbers(int a, int b)
        {

            return a * b;
        }
        public int DoAnotherThing(int x, int y)
        {

            return x + (y * 3);
        }
        public int MyTest(int a)
        {

            return 6;
        }
    }
}
