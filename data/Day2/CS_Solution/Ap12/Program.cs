int a, b;
string s;
bool iscorrect;

do
{
    Console.Write("a=");
    s= Console.ReadLine();
    iscorrect = int.TryParse(s, out a );
    if(!iscorrect )
        Console.WriteLine($"'{s}' 不是整數");
} while (!iscorrect);


do
{
    Console.Write("b=");
    s = Console.ReadLine();
    iscorrect = int.TryParse(s, out b);
    if (!iscorrect)
        Console.WriteLine($"'{s}' 不是整數");
} while (!iscorrect);

Console.WriteLine($"{a} + {b} = {a+b}");