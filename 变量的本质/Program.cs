using System;

namespace 变量的本质
{
    class Program
    {
        static void Main(string[] args)
        {

            #region 一 变量的存储空间（内存中）
            // 1byte = 8bit
            // 1KB = 1024byte
            // 1MB = 1024KB
            // 1GB = 1024MB
            // 1TB = 1024GB
            // 通过sizeof方法，可以获取变量类型所占的内存空间（ 字节 ）
            // 有符号的变量类型
            // sbyte   解释：定义整型变量sbytesize用于保存获取的数据，使用sizeof方法，传入变量类型sbyte，获取的字节数保存到变量sbytesize中，最后输出
            int sbyteSize = sizeof(sbyte);
            Console.WriteLine("sbyte类型占用的内存空间为" + sbyteSize + "字节" + "\n");
            // 其他有符号类型：int short long
            int intSize = sizeof(int);
            Console.WriteLine("int类型占用的内存空间为" + intSize + "字节" + "\n");
            int shortSize = sizeof(short);
            Console.WriteLine("short类型占用的内存空间为" + shortSize + "字节" + "\n");
            int longSize = sizeof(long);
            Console.WriteLine("long类型占用的内存空间为" + longSize + "字节" + "\n");
            Console.WriteLine("----------------------------------------------------" + "\n");

            // 无符号的变量类型
            int byteSize = sizeof(byte);
            Console.WriteLine("byte类型占用的内存空间为" + byteSize + "字节" + "\n");
            int uintSize = sizeof(uint);
            Console.WriteLine("uint类型占用的内存空间为" + uintSize + "字节" + "\n");
            int ushortSize = sizeof(ushort);
            Console.WriteLine("ushort类型占用的内存空间为" + ushortSize + "字节" + "\n");
            int ulongSize = sizeof(ulong);
            Console.WriteLine("ulong类型占用的内存空间为" + ulongSize + "字节" + "\n");
            Console.WriteLine("----------------------------------------------------" + "\n");

            // 浮点数变量类型
            int floatSize = sizeof(float);
            Console.WriteLine("float类型占用的内存空间为" + floatSize + "字节" + "\n");
            int doubleSize = sizeof(double);
            Console.WriteLine("double类型占用的内存空间为" + doubleSize + "字节" + "\n");
            int decimalSize = sizeof(decimal);
            Console.WriteLine("decimal类型占用的内存空间为" + decimalSize + "字节" + "\n");
            Console.WriteLine("----------------------------------------------------" + "\n");

            // 特殊类型
            int boolSize = sizeof(bool);
            Console.WriteLine("bool类型占用的内存空间为" + boolSize + "字节" + "\n");
            int charSize = sizeof(char);
            Console.WriteLine("char类型占用的内存空间为" + charSize + "字节" + "\n");
            // sizeof无法获取string类型所占的内存空间大小，因为字符串类型占用的空间可变，取决于字符串的长度
            // int stringSize = sizeof(String);
            Console.WriteLine("----------------------------------------------------" + "\n");
            #endregion

            #region 变量的本质
            // 变量的本质是2进制，计算机中所有数据都是二进制，由0和1组成
            // 计算机中的存储单位最小为1bit，他只能表示0和1两个数字，非0既1
            // 一字节=8bit，0和1的任意组合 如 1byte = 1000 0001
            // 二进制与十进制比较
            // 二进制与十进制互相转换 查看二.png
            #endregion
        }
    }
}
