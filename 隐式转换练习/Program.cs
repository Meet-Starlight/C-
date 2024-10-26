using System;

namespace 隐式转换练习
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 什么情况下会出现数据类型的隐式转换
            // 大范围装小范围，如double--> float-->整形（ 有符号 无符号 ）-->char
            int i = 1;
            short s = 1;
            i = s;

            // 将字符小明转换成数字并打印
            // 字符转数字，整形可以装字符型，输出该字符的ASCII码
            // 字符转数字可以不必声明char，之间将字符赋值给整形，也可以隐式转换
            // char name1 = '小';
            // char name2 = '明';
            int name1 = '小';
            int name2 = '明';
            Console.WriteLine(name1);
            Console.WriteLine('\n');
            Console.WriteLine(name2);
        }
    }
}
