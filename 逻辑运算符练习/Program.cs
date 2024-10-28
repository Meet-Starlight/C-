namespace 逻辑运算符练习
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("逻辑运算符练习");
            // 求打印结果
            Console.WriteLine(true || true); // true
            Console.WriteLine(false || true); // true
            Console.WriteLine(true && true); // true
            Console.WriteLine(true && false); // false
            Console.WriteLine(!true); // false
            // 分割线
            Console.WriteLine("---------------");
            // 求打印结果
            bool gameOver;
            bool isWin;
            int health = 100;
            gameOver = true;
            isWin = false;
            Console.WriteLine(gameOver || isWin && health > 0); //true
        }
    }
}
