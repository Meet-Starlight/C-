namespace 位运算符练习
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("位运算符练习");
            // 写出35 << 4 和 66 >> 1的结果
            int a = 35; // 100011
            int c = a << 4; // 1000110000
            Console.WriteLine(c);

            a = 66; // 1000011
            c = a >> 1; // 100001
            Console.WriteLine(c);

            // 写出99 ^ 33 和 76 | 85的结果
            a = 99; // 1100011
            int b = 33; // 100001
            Console.WriteLine(a ^ b); // 66

            a = 76; // 1001100
            b = 85; // 1010101
            Console.WriteLine(a | b); // 93
        }
    }
}
