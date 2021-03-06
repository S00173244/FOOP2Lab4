﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSheet4Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 5, 3, 6, 11, 2, 15, 21, 13, 12, 10 };

            var outputNumbers = from number in numbers
                                where number > 5
                                orderby number descending
                                select number;

            foreach (int number in outputNumbers)
            {
                Console.WriteLine(number.ToString());
            }
        }
    }
}
