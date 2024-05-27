namespace AppFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region with while
            //Console.Write("Zehmet olmasa xeste sayini daxil edin: ");
            //int patient = Convert.ToInt32(Console.ReadLine());
            //int count = 0;
            //int sum = 0;
            //decimal average = 0;
            //while (count < patient)
            //{
            //    Console.Write($"{count + 1}. Xestenin dermanlarinin sayini daxil edin: ");
            //    int medicineCount = Convert.ToInt32(Console.ReadLine());
            //    sum += medicineCount;
            //    count++;
            //}
            //Console.WriteLine();
            //average = sum / patient;
            //Console.WriteLine($"Qebul edilen xeste sayi {patient}");
            //Console.WriteLine($"Xestelere yazilan toplam derman sayi {sum}");
            //Console.WriteLine($"Xeste basina ortalama dusen derman sayisi {average}");
            #endregion

            #region with for
            //Console.Write("Zehmet olmasa Xeste sayisini daxil edin: ");
            //int patient = Convert.ToInt32(Console.ReadLine());

            //int sum = 0;
            //int average = 0;
            //for (int i = 0; i < patient; i++)
            //{
            //    Console.Write($"{i+1}. Xestenin dermanlarinin sayini daxil edin: ");
            //    int medicineCount = Convert.ToInt32(Console.ReadLine());
            //    sum +=medicineCount;
            //}
            //Console.WriteLine();
            //average = sum /patient;
            //Console.WriteLine($"Qebul edilen xeste sayisi: {patient}");
            //Console.WriteLine($"Xestelere yazilan toplam derman sayi {sum}");
            //Console.WriteLine($"Xeste basina dusen ortlama derman sayisi: {average}");
            #endregion

            #region with do-while

            Console.Write("Zehmet olmasa Xeste sayisini daxil edin: ");
            int patient = Convert.ToInt32(Console.ReadLine());

            int count = 0;
            int sum = 0;
            decimal average = 0;
            do
            {
                Console.Write($"{count+1}. Xestenin aldigi derman sayisini daxil edin: ");
                int medicineCount = Convert.ToInt32(Console.ReadLine());
                sum += medicineCount;
                count++;
            }
            while (count<patient);
            average = (sum /patient);
            Console.WriteLine($"Qebul edilen xesde sayi {patient}");
            Console.WriteLine($"Xestelere yazilan toplam derman sayi {sum}");
            Console.WriteLine($"Xeste basina dusen ortalama derman sayisi {average}");
            #endregion
        }
    }
}
