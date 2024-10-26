namespace 字符串拼接
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("字符串拼接");
            #region 字符串拼接方式 一
            // string不存在算数运算符，不能计算，但是可以通过+号进行字符串拼接
            string str = "123";
            str = str + "456";
            Console.WriteLine(str);

            // 隐式转换：字符串拼接其他类型时会转为字符串拼接，如拼接整型
            str = str + 789;
            Console.WriteLine(str);

            // string可以用复合运算符 +=
            str = "123";
            str += "1" + 4 + true;
            Console.WriteLine(str);
            #endregion

            #region 字符串拼接方式 二
            // 语法：
            // string.Format("带拼接的内容", 内容1, 内容2, 内容3....);
            // 拼接内容中，想要被拼接的内容用占位符替代，{ 0 },数字0--n，依次往后
            string str2;
            str2 = string.Format("今天是{0}，今年是{1}", "10月25", "2024");
            Console.WriteLine(str2);

            string str3 = string.Format("{0}，{1}，{2}，{3}", 1, true, 2, false);
            Console.WriteLine(str3);
            #endregion

            #region 控制台打印拼接
            // 与string.Format方法类似
            Console.WriteLine("{0}，{1}，{2}，{3}，{4}", 1, true, 2, false, "A");
            #endregion

        }
    }
}
