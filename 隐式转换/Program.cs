using System;

namespace 隐式转换
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 类型转换就是不同变量类型之间相互转换
            // 隐式转换的基本规则--不同类型之间自动转换
            // 大范围装小范围

            #region 相同大类型之间的转换
            // 有符号 long-->int-->short-->sbyte
            long l = 1;
            int i = 2;
            short s = 3;
            sbyte b = 4;
            //大范围装小范围，long的范围比int大，所以l可以等于i，如果小范围装大范围则会报错，如i=l
            //隐式转换 int隐式转换成了long
            l = i;

            //无符号 ulong-->uint-->ushort-->byte
            //转换规则相同，大范围装小范围
            ulong ul = 1;
            uint ui = 2;
            ushort us = 3;
            byte by = 4;

            ul = ui;

            //浮点数 decimal double-->float
            decimal de = 5.2m;
            double u = 1.2;
            float t = 5.5f;
            // decimal类型无法用隐式转换来存储double和float
            u = t;

            //特殊类型 bool char string
            //特殊类型不存在隐式转换
            #endregion

            #region 不同大类型间的转换
            //无符号
            byte b2 = 4;
            ushort s2 = 5;
            uint ui2 = 6;
            ulong ul2 = 7;
            //有符号
            sbyte by2 = 8;
            short sh = 9;
            int i2 = 10;
            long l2 = 11;

            // 1. 无符号装有符号
            //无符号的变量类型没有负数，有符号的变量类型有负数，无法隐式转换，错误示例：
            //b2 = by2;

            //2. 有符号装无符号 无符号范围小于有符号范围即可 遵守大范围装小范围原则
            i2 = b2;

            //3. 浮点数装整数（ 有，无符号 ）
            // 浮点数可以装任何整数，不区分范围，有无符号
            float f2 = 1.2f;
            double d2 = 1.1;
            decimal il = 2.1m;

            f2 = l2;
            f2 = ul2;

            // float的存储范围非常大，当超过一定大小时，会以科学计数法输出，所以可以隐式转换，遵守大范围装小范围
            f2 = 100000000000000;
            Console.WriteLine(f2);

            //总结：double-->float-->所有整形（ 有符号 无符号 ）
            // decimal-->所有整形（ 有符号 无符号 ）
            // 整数无法隐式转换浮点数，因为整数不能存小数
            #endregion

            // 特殊类型无法与其他类型间隐式转换
            //char类型本质是一个16位无符号整数，用于表示Unicode字符的编码值，范围0-65535，可以隐式转换成比他宽度更大的数值类型，如int long ushort ulong
            //char隐式转换成数值类型所输出的数字为ASCII码

            #region 总结
            // 高精度（大范围）装低精度（小范围）
            // long-->int-->short-->sbyte
            // ulong-->uint-->ushort-->byte  
            // double--> float-->整数（ 有符号 无符号 ）-->char
            // decimal--> 整数（ 有符号 无符号 ）--> char
            // string bool 不参与隐式转换
            // 无符号不能隐式转换有符号
            // 有符号可以隐式转换无符号，遵守大范围装小范围
            #endregion
        }
    }
}
