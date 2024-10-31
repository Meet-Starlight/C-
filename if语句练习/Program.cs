namespace if语句练习
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("if语句练习");
            // 用户输入时长，判断是否超过60分钟
            try
            {
                Console.WriteLine("请输入时长");
                int time = int.Parse(Console.ReadLine());
                if (time > 60)
                {
                    Console.WriteLine("超过了60分钟");
                }
                else
                {
                    Console.WriteLine("未超过60分钟");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("请输入正确时长");
                Console.WriteLine(e.Message);
            }

            // 输入两个整数a，b，如果两个数可以整除或者两个数加起来大于100，输出a的值，否则输出b的值
            Console.WriteLine("请输入两个整数");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            if (a % b == 0 || b % a == 0 ||a + b > 100)
            {
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine(b);
            }

            // 输入一个整数，如果是偶数，则输出 You input is even 否则输出 You input is odd
            Console.WriteLine("请输入一个整数");
            int c = int.Parse(Console.ReadLine());
            if (c % 2 == 0)
            {
                Console.WriteLine("You input is even");
            }
            else
            {
                Console.WriteLine("You input is odd");
            }
            // 有3个整型变量，输出最大值
            int a2 = 10;
            int b2 = 12;
            int c2 = 6;
            if (a2 > b2 && a2 > c2)
            {
                Console.WriteLine("最大值是" + a2);
            }
            else if (b2 > a2 && b2 > c2)
            {
                Console.WriteLine("最大值是" + b2);
            }
            else
            {
                Console.WriteLine(c2);
            }

            // 写出以下代码运行结果
            int a4 = 5;
            if (a4 > 3)
            {
                int b3 = 0;
                ++b3;
                b3 += a4;
                Console.WriteLine(b3); // 6 
            }
            // 报错原因：生命周期
            // b3在if语句块中声明，而Console.WriteLine(b3)在if语句块外，超出if语句块的范围后，b3被释放，所以报错
            Console.WriteLine(b3);

            // 用户输入一个字符 如果输入的字符是0-9数字中的一个，则显示您输入了一个数字，否则显示这不是一个数字
            Console.WriteLine("请输入一个字符");
            // 扩展：返回的是一个对象，要拿到输入的一个字符，需要加.KeyChar
            // char类型可以隐式转换为int
            int c3 = Console.ReadKey().KeyChar;
            // char类型可以隐式转换为
            // 使用askii码判断，如果输入的字符的askii码在0-9之间，则证明输入的是数字
            if (c3 >= '0' && c3 <= '9')
            {
                Console.WriteLine("输入的是数字");
            }
            else
            {
                Console.WriteLine("输入的不是数字");
            }
        }
    }
}
