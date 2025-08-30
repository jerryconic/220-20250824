for(; ; )
{
    string s;
    Console.Write(
@"1.畫星星
2.計算匯率
3.計算所得稅
4.猜數字
0.離開
請選擇(0~4):");
    s = Console.ReadLine();
    switch (s)
    {
        case "1":
            DrawStar();
            break;
        case "2":
            Console.WriteLine("2.計算匯率");//ExchangeRate()
            break;
        case "3":
            Console.WriteLine("3.計算所得稅");//CalcTax()
            break;
        case "4":
            GuessGame();
            break;
        case "0":
            Console.WriteLine("bye.");
            return;
    }
    Console.Write("按任意鍵繼續...");
    Console.ReadKey();
    Console.Clear();
}

void DrawStar()
{
    string s;
    int n;

    Console.Write("N=");
    s = Console.ReadLine();
    n = int.Parse(s);

    for (int i = 1; i <= n; i++)
    {
        for (int j = 1; j <= i; j++)
            Console.Write("*");
        Console.WriteLine();
    }
    Console.WriteLine();
    for (int i = n; i >= 1; i--)
    {
        for (int j = 1; j <= i; j++)
            Console.Write("*");
        Console.WriteLine();
    }
    Console.WriteLine();
    for (int i = 1; i <= n; i++)
    {
        for (int j = 1; j <= n - i; j++)
            Console.Write(" ");
        for (int j = 1; j <= 2 * i - 1; j++)
            Console.Write("*");
        Console.WriteLine();
    }
}

void CalcTax()
{

}

void GuessGame()
{
    int ans, guess;
    Random rnd = new Random();
    ans = rnd.Next(1, 100);
    do
    {
        Console.Write("猜數字(1~99):");
        string s = Console.ReadLine();
        guess = int.Parse(s);

        if (guess == -1)
        {
            Console.WriteLine($"答案是:{ans}");
            break;
        }

        if (guess < 1 || guess > 99)
        {
            Console.WriteLine("請輸入1~99");
            continue;
        }

        if (guess < ans)
            Console.WriteLine("高一點");
        else if (guess > ans)
            Console.WriteLine("低一點");
        else
            Console.WriteLine("猜對了");
    } while (ans != guess);
}