string s, curr;
int nt;
decimal amt;

Console.Write("NT=");
s = Console.ReadLine();
nt = int.Parse(s);

Console.Write("幣別(U=USD/J=JPY/E=EUR):");
curr = Console.ReadLine();

switch(curr)
{
    case "U":
    case "u":
        amt = nt / 28.93M;
        break;
    case "J":
    case "j":
        amt = nt / 0.2048M;
        break;    
    case "E":
    case "e":
        amt = nt / 34.05M;
        break;
    default:
        amt = 0;
        break;
}

Console.WriteLine($"NT={nt:#,##0}, 可兌換外幣={amt:#,##0.00}");
