using System;

namespace CountingMinutesI
{
    class Program
    {


        public static string CountingMinutesI(string str)
        {

            // code goes here  
            string[] times = str.Split('-');
            int hour24Dif = 0;

            if (times[0].Contains("am"))
            {
                hour24Dif++;
            }
            if (times[1].Contains("am"))
            {
                hour24Dif++;
            }

            hour24Dif *= 12;

            int hour1 = Convert.ToInt32(times[0].Split(':')[0]);
            int min1 = Convert.ToInt32(times[0].Replace("am","").Replace("pm","").Split(':')[1]);

            int hour2 = Convert.ToInt32(times[1].Split(':')[0]);
            int min2 = Convert.ToInt32(times[1].Replace("am", "").Replace("pm", "").Split(':')[1]);

            int hourDif = (hour2 - hour1) + hour24Dif;
            int minDif = min2 - min1;

            int result = (hourDif * 60) + minDif;

            return result.ToString();

        }
        static void Main(string[] args)
        {
            Console.WriteLine(CountingMinutesI(Console.ReadLine()));
        }
    }
}
