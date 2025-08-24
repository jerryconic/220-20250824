string s;
int income, tax;

Console.Write("年所得收入:");
s = Console.ReadLine();
income = int.Parse(s);

if (income <= 540000)
    tax = (int)(income * 0.05 + 0.5);
else if (income <= 1210000)
    tax = (int)(income * 0.12 - 37800 + 0.5);
else if (income <= 2420000)
    tax = (int)(income * 0.2 - 134600 + 0.5);
else if (income <= 4530000)
    tax = (int)(income * 0.3 - 376600 + 0.5);
else
    tax = (int)(income * 0.4 - 829600 + 0.5);

Console.WriteLine($"年所得收入:{income:#,##0}, 應繳所得稅:{tax:#,##0}");