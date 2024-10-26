using System;

namespace 变量
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("变量");

            // 一 折叠代码
            // 主要作用：使代码逻辑更清晰
            // 由#region 和 #endregion配对出现
            // 它可以将代码折叠，避免太过凌乱
            // 本质是编辑器提供的预处理指令，只影响编辑，不影响运行
            #region 折叠示例

            #endregion

            #region 如何声明变量
            // 变量可以理解为可以变化的容器 变量就是用来存储各种不同类型数值的容器
            // 不同的变量类型可以存储不同类型的值，如整数型，字符型等
            // 变量声明固定写法：
            // 变量类型 变量名 = 初始值;
            // 初始值必须与变量类型对应，如int的初始值必须是整数
            // 14种变量类型：
            // 1.有符号的整型变量  能存储一定范围正负数包括0的变量类型：
            // sbyte    存储范围-128~~127
            // int      存储范围-21亿~~21亿多
            // short    存储范围-32768~~32767
            // long     存储范围-9百万兆~~9百万兆
            sbyte a = 20;
            int i = 100;
            short b = 200;
            long c = 500;
            // 错误示例：超出存储范围会报错
            // sbyte d = 200;

            // 2. 无符号的整型变量 能存储一定范围内0和正数的变量类型
            // byte 0~~255
            // uint 0~~42亿
            // ushort 0~65535
            // ulong 0~~18百万兆
            byte s = 1;
            uint ui = 2;
            ushort us = 3;
            ulong ul = 4;

            // 3. 浮点数（小数）
            // float 存储7~8位有效数字，编译器不同，有效数字可能不同，声明末尾加f，四舍五入，有效数字从左到右，从非零数开始计算
            // 在C#中，小数默认double类型，因此，在声明float类型的小数时要在末尾加f，用以区分类型
            float f = 1.1234567390f;
            Console.WriteLine(f);
            // double 15~17位有效数字
            double d1 = 2.123456789012345678901234567890;
            Console.WriteLine(d1);
            // decimal 27~28位有效数字，末尾加m 但不建议使用，了解即可
            decimal d2 = 0.123456789012345678901234567890m;

            // 4. 特殊类型
            // bool 布尔类型，表示真假，true--真；false--假
            bool a1 = true;
            bool b1 = false;
            // char 存储单个字符 字符型
            char c1 = 'a';
            char c2 = '夏';
            // string 存储多个字符 无上限，字符串类型
            string s1 = "asdfg";
            string s2 = "添加到源代码管理";

            // 使用变量  直接使用变量名即可
            Console.WriteLine(a);
            // 使用和修改变量必须先声明，不能无中生有
            int i1 = 100;
            Console.WriteLine(i1);
            // 修改变量
            i1 = 300;
            Console.WriteLine(i1);

            // 字符串和变量一起输出，使用+号连接
            Console.WriteLine("整型变量" + i);
            #endregion

            #region 三 为什么有那么多变量类型
            // 不同的变量 存储的范围和类型不一样，本质是占用的内存空间不同
            // 选择不同的数据（ 变量 ）类型装载不同的数据

            // 国籍   字符串类型
            string guo = "中国";
            // 年龄  byte类型
            byte i2 = 20;
            // 性别  只有两种可能，因为是布尔型 true女 false男
            bool sex = false;
            Console.WriteLine(guo + ',' + i2 + ',' + sex);

            // 目前常用：数字 用int 小数 用float 字符串 用string 真假 用bool
            #endregion

            #region 四 多个相同类型变量 同时声明
            // 单个声明
            int z1 = 100;
            float f2 = 0.12f;
            string s3 = "选择";
            bool a3 = true;

            // 同类型声明多个
            // 变量类型 变量名 = 初始值，变量名 = 初始值，变量名 = 初始值...；
            int z2 = 100, m1 = 200;
            string s4 = "12", s5 = "34";
            #endregion

            #region 变量初始化相关
            // 变量声明时可以不赋值，但不建议这样写
            int a2;
            #endregion
        }
    }
}