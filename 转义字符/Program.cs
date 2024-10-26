using System;

namespace 转义字符
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 转义字符的使用
            // 转义字符是字符串的一部分，用来表示一些特殊的字符
            // 比如单引号，引号，换行等
            #endregion

            #region 固定写法
            // 不同的 \ 和字符组合，表示不同的含义
            // 常用转义字符：
            // 单引号  \'
            string j = "单引号转义字符\'abc\'";
            Console.WriteLine(j);
            // 双引号
            string a = "双引号转义字符\"abc\"";
            Console.WriteLine(a);
            // 换行
            string b = "换行转义字符\n123321";
            Console.WriteLine(b);
            // 斜杠  文件路径常用
            string c = "斜杠转义字符\\";
            Console.WriteLine(c);

            // 不常用转义字符 了解即可
            // 制表符 即空一个Tab键 \t
            // 光标退格 \b
            // 空字符 \0  无任何作用
            // 警报音 \a

            // 转义字符也可以直接打印
            Console.WriteLine("123321\n123321");
            #endregion

            #region 取消转义字符
            // 在声明字符串时加@可取消转义字符,例如在字符串中直接输出\
            string str = @"123\123";
            Console.WriteLine(str);
            // 直接使用
            Console.WriteLine(@"123\n123");
            #endregion
        }
    }
}
