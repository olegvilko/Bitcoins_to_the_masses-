﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitcoins_to_the_masses_
{
    class Program
    {
        static void Main(string[] args)
        {
            double amount = 1.11; //количество биткоинов от одного человека
            int peopleCount = 60; // количество человек
            int totalMoney = (int)(Math.Round(amount * peopleCount)); // ← исправьте ошибку в этой строке
            Console.WriteLine(totalMoney);
            Console.ReadKey();
        }
    }
}
