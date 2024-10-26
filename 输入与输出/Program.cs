using System;

namespace 输入与输出
{
    class Program
    {
        static void Main(string[] args)
        {
            // 输出
            // 在控制台打印一行信息 打印结束后自动空一行
            Console.WriteLine("Hello World ！");

            // 在控制台打印一行信息 但不空行 两行内容紧挨着打印
            Console.Write("111");
            Console.Write("222");

            // 为了美观，输出一个空行 使用转义字符
            Console.Write("\n");
            // 输入 
            // 检测玩家输入 输入完成（ 回车键 ）后才会继续执行后续代码 括号内不需要参数!
            Console.ReadLine();
            // 输入完成后执行
            Console.WriteLine("输入完成");

            // 检测玩家输入 但只要按了键盘任意按钮 输入就会结束 无需回车
            Console.ReadKey();
            Console.Write("\n");
            Console.WriteLine("完成");
        }
    }
}