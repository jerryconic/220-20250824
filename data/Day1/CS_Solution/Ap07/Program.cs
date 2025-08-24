Console.WriteLine("byte:size={0}, {1} ~ {2}", 
    sizeof(byte), byte.MinValue, byte.MaxValue);

Console.WriteLine("short:size={0}, {1} ~ {2}",
    sizeof(short), short.MinValue, short.MaxValue);

Console.WriteLine("int:size={0}, {1} ~ {2}",
    sizeof(int), int.MinValue, int.MaxValue);

Console.WriteLine("long:size={0}, {1} ~ {2}",
    sizeof(long), long.MinValue, long.MaxValue);

Console.WriteLine("float:size={0}, {1} ~ {2}",
    sizeof(float), float.MinValue, float.MaxValue);

Console.WriteLine("double:size={0}, {1} ~ {2}",
    sizeof(double), double.MinValue, double.MaxValue);

Console.WriteLine("decimal:size={0}, {1} ~ {2}",
    sizeof(decimal), decimal.MinValue, decimal.MaxValue);

decimal x = 10L+ 21.5M;