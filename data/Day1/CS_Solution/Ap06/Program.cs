int a;
short b;

//b = 10000;
//a = b;

a = 1000000;
b = (short)a; 

Console.WriteLine($"a={a}({a:x8}), b={b}({b:x4})");