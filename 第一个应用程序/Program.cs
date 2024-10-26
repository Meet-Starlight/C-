// 两杠注释 只能注释一行

/*
 星号注释  多行注释
 可以注释多行
 */

// 引用命名空间
using System;

/// <summary>
/// 命名空间--工具包，存放工具
/// </summary>

/// <summary>
/// 三行注释
/// 用于注释类，命名空间等
/// </summary>

namespace 第一个应用程序
{

/// <summary>
/// 类--工具
/// </summary>
    class Program
        //类代码块
        //面向对象的代码在此处
    {
        //Main--主函数 程序主入口
        static void Main(string[] args)
        {
            // 函数代码块
            // 这个工具能做什么
            // 基础阶段的代码在此处写
            // 在控制台打印一行信息 打印完成后自动空一行
            Console.WriteLine("第一个应用程序");
            Console.WriteLine("111");
        }
    }
}