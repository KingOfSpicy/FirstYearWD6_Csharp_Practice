﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WDCheWei_task9
{
    class Program
    {
        static void Main(string[] args)
        {
            //var names = new List<string> { "Che-Wei", "Ana", "Felipe" };
            //foreach (var name in names)
            //{
            //    Console.WriteLine($"Hello {name.ToUpper()}!");
            //}

            //Console.WriteLine(names.IndexOf("Felipe"));

            //Console.WriteLine();
            //names.Add("Maria");
            //names.Add("Bill");
            //names.Remove("Ana");
            //foreach (var name in names)
            //{
            //    Console.WriteLine($"Hello {name.ToUpper()}!");
            //}

            //Console.WriteLine($"My name is {names[0]}.");
            //Console.WriteLine($"I've added {names[2]} and {names[3]} to the list.");

            //Console.WriteLine($"The list has {names.Count} people in it");

            //var index = names.IndexOf("Felipe");
            //if (index != -1)
            //    Console.WriteLine($"The name {names[index]} is at index {index}");

            //var notFound = names.IndexOf("Not Found");
            //Console.WriteLine($"When an item is not found, IndexOf returns {notFound}");

            //names.Sort();
            //names.Sort();
            //foreach (var name in names)
            //{
            //    Console.WriteLine($"Hello {name.ToUpper()}!");
            //}

            var fibonacciNumbers = new List<int> { 1, 1 };
            int i = 0;
            for(i=0; i<18; i++)
            { 
            var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
            var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];
            fibonacciNumbers.Add(previous + previous2);
            }

            //fibonacciNumbers.Add(previous + previous2);


            foreach (var item in fibonacciNumbers)
                Console.WriteLine(item);

        }
    }
}
