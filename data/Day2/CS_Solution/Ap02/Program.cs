﻿int n, total = 0;
string s;

do
{
    Console.Write("n(0 for end)=");
    s = Console.ReadLine();
    n = int.Parse(s);
    total += n;
} while (n!=0);
Console.WriteLine($"Total={total}");