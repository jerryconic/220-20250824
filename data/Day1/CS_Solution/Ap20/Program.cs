int total = 0;
int[] ar = { 17, 31, 42, 21, 5 };
Array.Sort(ar);
foreach(int n in ar)
{
    Console.WriteLine(n);
    total += n;
}
Console.WriteLine($"Total={total}");