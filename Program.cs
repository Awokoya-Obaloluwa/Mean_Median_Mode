namespace Mean_Median_Mode_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                int[] kp = new int[] { 12, 5, 3, 45, 6, 5, 23, 6, 4, 7, 8, 3, 1, 34, 6, 6, 42, 1 };
                int[] af = new int[] { 32, 34, 24, 567, 676, 89, 7, 24, 7, 96, 89, 9, 6, 5, 7, 8, 798, 4 };
                int a = kp.Length;
                int b = af.Length;
                Console.WriteLine(mean(kp));
                Console.WriteLine(PrintMode(af, b));
            }
            catch (FormatException)
            {
                Console.WriteLine("Please always put in an array of numbers");
            }
            catch (IndexOutOfRangeException)
            {

            }


        }
        public static double mean(int[] num1)
        {


            double sum = 0;
            double numCount = 0;
            for (int i = 0; i <= num1.Length - 1; i++)
            {
                sum += num1[i];
                numCount++;
            }

            return Math.Round(sum / numCount, 2);


        }
        public static double median(int[] num2, int n)
        {
            Array.Sort(num2);

            if (n % 2 != 0)
                return (double)num2[n / 2];

            return (double)(num2[(n - 1) / 2] + num2[n / 2]) / 2.0;


        }
        public static double PrintMode(int[] num3, int k)
        {
            int High = num3.Max();
            int sizeOfCount = High + 1;
            int[] count = new int[sizeOfCount];
            for (int i = 0; i < sizeOfCount; i++)
                count[i] = 0;
            for (int i = 0; i < k; i++)
                count[num3[i]]++;

            int mode = 0;
            int r = count[0];

            for (int i = 1; i < High; i++)
            {
                if (count[i] > r)
                {
                    r = count[i];
                    mode = i;
                }
            }
            return mode;
        }

    }



}
