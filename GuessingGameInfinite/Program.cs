using System;

namespace GuessingGameInfinite
{
    class Program
    {
        static void Main(string[] args)
        {
            // programm genereerib juhuslikku numbri 1 kuni 10;
            //kasutaja peab seda numbrit ära arvama
            //katsete arv on piiramattu;
            //programm genereerib juhuslikku numbrit ühe kaupa

            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);
            int usernumber = 0;
            
            while (usernumber != cpuNumber)
            { 
            Console.WriteLine("Vali juhuslik number 1-10");
             usernumber = Convert.ToInt32(Console.ReadLine());

                if(usernumber == cpuNumber)
                {
                    Console.WriteLine("Sinu Võit");
                }
                else
                {
                    Console.WriteLine("Proovi uuesti");
                }
            }
            
               
            
            
          

        }
    }
}

