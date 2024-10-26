namespace 条件运算符练习
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("条件运算符练习");
            // 写出打印结果
            bool b = true;
            Console.WriteLine(b != true);  // false

            Console.WriteLine(10 == 10); // true
            Console.WriteLine(10 > 20); // false
            Console.WriteLine(10 <= 20);// true
            Console.WriteLine(10 <= 10);// true

            // 写出打印结果
            bool gameOver, startGame;
            int a = 10;
            int b2 = 15;
            gameOver = a > (b2 - 5); // 10 > 10 false
            startGame = gameOver == (b2 > (a + 5)); // false == false true
            Console.WriteLine("startGame=" + startGame); // startGame=true
        }
    }
}
