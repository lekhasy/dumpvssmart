using System;

namespace key
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("starting");
            var count_ten = 0;
            var count_zero = 0;

            var iteration = 0;

            var r = new Random();

            while (count_ten < 10)
            {
                iteration++;

                var tenSuccess = true;
                var zeroSuccess = true;

                // loop through 10 question
                for (int i = 0; i < 10; i++)
                {
                    var correctValue = r.Next(1, 5);
                    // two dump: 62498.3/1
                    var choosenTenValue = r.Next(1, 5);

                    // one smart: 146.1 / 1
                    if (i < 5) choosenTenValue = correctValue;
                    if (i < 8) choosenTenValue = (new int[] { correctValue, 5 })[r.Next(0, 2)];
                    var choosenZeroValue = r.Next(1, 5);

                    if (correctValue != choosenTenValue) tenSuccess = false;
                    if (correctValue == choosenZeroValue) zeroSuccess = false;
                }

                if (tenSuccess) count_ten++;
                if (zeroSuccess) count_zero++;

                Console.WriteLine("count ten:" + count_ten.ToString() + Environment.NewLine + "count zero: " + count_zero.ToString());
            }

            Console.WriteLine("Finished");

            Console.ReadLine();
        }
    }
}
