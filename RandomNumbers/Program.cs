﻿using System;

namespace RandomNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhuslikud numbrid
            //kui genereeritud number on 5, programm lõpetab töö ja soovib kasutajale kena päeva
            //kui genereeritud number on midagi muud siis programm j'tkab oma tööd

            Random rnd = new Random();
            int i = 0;

            while (i != 5)
            {
                int myRandomNumber = rnd.Next(1, 11);
                Console.WriteLine($"Juhuslik number on {myRandomNumber}");
                if (myRandomNumber == 5)
                {
                    i = myRandomNumber;
                }
            }
            Console.WriteLine("Kena päeva!");




        }
    }
}
