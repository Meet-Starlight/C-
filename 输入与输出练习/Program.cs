using System;

namespace 输入与输出练习
{
    class Program
    {
        static void Main(string[] args)
        {
            // 请用户输入用户名 年龄 班级
            Console.WriteLine("请输入用户名");
            Console.ReadLine();
            Console.WriteLine("请输入年龄");
            Console.ReadLine();
            Console.WriteLine("请输入班级");
            Console.ReadLine();
            Console.WriteLine("输入完成\n");

            // 询问用户喜欢什么运动，不管输入什么都输出我也喜欢
            Console.WriteLine("你喜欢什么运动");
            Console.ReadLine();
            Console.WriteLine("我也喜欢\n");

            // 控制台输出一个10*10空心星形方阵
            Console.WriteLine("**********");
            Console.WriteLine("*        *");
            Console.WriteLine("*        *");
            Console.WriteLine("*        *");
            Console.WriteLine("*        *");
            Console.WriteLine("*        *");
            Console.WriteLine("*        *");
            Console.WriteLine("*        *");
            Console.WriteLine("*        *");
            Console.WriteLine("**********");
        }
    }
}