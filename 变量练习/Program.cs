using System;

namespace 变量练习
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 下列代码的输出结果是   num
            double num = 36.6;
            // 注意区分字符串与变量
            Console.WriteLine("num");

            // 2 用合适的变量来存储名字 年龄 性别 身高 体重 家庭住址 并打印
            string name = "小明";
            byte b = 20;
            char c = '男';
            float f = 70.8f;
            float f2 = 185.3f;
            string jia = "山东省威海市";
            Console.WriteLine("姓名：" + name + "\n" + "年龄：" + b + "\n" + "性别：" + c + "\n" + "身高：" + f2 + "\n" + "体重：" + f +  "\n" + "家庭住址:" + jia + "\n" );
        }
    }
}