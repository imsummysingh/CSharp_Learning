﻿List<int> numbers = new List<int> { 1, 2, 3 };
List<int> result = numbers.Where(temp => temp >= 2).ToList();
foreach(int n in result)
{
    Console.WriteLine(n);
}