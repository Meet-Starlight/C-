using System;

namespace 常量
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 常量的声明
            // 关键字 const
            // const 变量类型 名 = 初始值
            const int i = 10;
            #endregion

            #region 常量的特点
            // 1. 必须初始化，在声明时必须赋值
            // 2. 不能修改
            // 用来声明一些常用不变的变量,比如圆周率
            const float PI = 3.14f;
            Console.WriteLine(PI);
            #endregion
        }

    }
}