﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Day02
{
    public class Soal0206
    {
        private int Value { get; set; }
        public Soal0206()
        {
            Console.Write("Nilai n : ");
            Value = int.Parse(Console.ReadLine());
            Process();
        }

        public void Process()
        {
            for (int i = 0; i < Value; i++)
            {
                if ((i + 1) % 3 == 0)
                {
                    Console.Write(" *\t");
                }
                else
                {
                    Console.Write($"{i * 4 + 1} \t");
                }
            }
            Console.WriteLine();
            Console.WriteLine("Press Any Key to Continue...");
            Console.ReadLine();
        }
    }
}
