using System;

namespace GuessingGameThreeTries
{
    class Program
    {
        static void Main(string[] args)
        {
            // programm genereerib juhuslikku numbri 1 kuni 10;
            //kasutaja peab seda numbrit ära arvama
            //kui kasutaja suutis seda numbrit ära arvata, siis ta on mängu võitnud
            //kasutajal on kolm katset, 
            //programm genereerib juhuslikku numbrit ühe kaupa;

            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);
            int usernumber = 0;
            int i = 0;

            while (i < 3)
            {
                Console.WriteLine("Vali juhuslik number 1-10");
                usernumber = Convert.ToInt32(Console.ReadLine());

                if (usernumber == cpuNumber)
                {
                    Console.WriteLine("Sinu Võit");
                }
                else
                {
                    i++;
                  Console.WriteLine($"Proovi uuesti,{3 - i} katset on jäänud");
                }


            }


        }
    }
}
