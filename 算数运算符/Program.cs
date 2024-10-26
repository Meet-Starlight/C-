namespace 算数运算符
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("算数运算符");
            #region 赋值运算符
            // =
            // 先看右侧，再看左侧，将右侧值赋给左侧变量
            string myName = "小明";

            #endregion

            #region 算数运算符
            // 加法
            // 用自己来计算 先算右侧结果，再赋值给左侧变量
            int i = 1;
            i = 1 + 2;
            Console.WriteLine(i);

            // 连续运算 先算右侧结果，再赋值给左侧变量
            i = i + 3 + 10 + i;
            Console.WriteLine(i);

            // 初始化时运算
            int s = 2 + 1 + 4 + i;
            Console.WriteLine(s);

            // 减法
            int j = 1;   
            j = j - 1;
            Console.WriteLine(j);
            // 连续运算
            j = 1 - 2 - 4;
            Console.WriteLine(j);

            // 初始化时运算
            int j2 = 1 - 1 - j;
            Console.WriteLine(j2);

            // 乘法
            int c = 2;
            c = c * 3;
            Console.WriteLine(c);

            // 连续运算
            c = c * 2 * 3;
            Console.WriteLine(c);

            // 初始化时运算
            int c2 = c * 3;
            Console.WriteLine(c2);

            // 除法
            int a3 = 3;
            a3 = a3 / 3;
            Console.WriteLine(a3);

            // 连续运算
            a3 = a3 / 2 / 3;
            Console.WriteLine(a3);

            // 初始化时运算
            int a4 = 3 / 2 / 3;
            Console.WriteLine(a4);
            // 结果取整数，小数丢失，如果需要小数部分，在其中一个数中加f，使用float类型
            float f = 1 / 2f;
            Console.WriteLine(f);

            // 取余
            int y = 4;
            // 4 / 2 取余数 0
            y = y % 2;
            Console.WriteLine(y);

            // 连续运算
            y = y % 2 % 3;
            Console.WriteLine(y);

            // 初始化时运算
            int y2 = 4 % 2;
            Console.WriteLine(y2);
            #endregion

            #region 算数运算符的优先级
            // 优先级指在混合运算时运算顺序
            // 乘除取余优先级高于加减，括号可以改变优先级，优先算括号内的，多组括号优先计算里层括号内容，依次向外计算
            int a = 4 + 3 * 2 / 2 + 2 * 3 % 2;
            Console.WriteLine(a);

            int a2 = (4 + 3) * 3 / 2 + 2 * 3 % 2;
            Console.WriteLine(a2);

            int a5 = (4 + 3 + (8 * 8 / 3)) * 3 / 2 + 2 * 3 % 2;
            Console.WriteLine(a5);
            #endregion

            #region 算数运算符 复合运算符
            // 固定写法：
            // += -= *=  /= %=
            // 用于计算自己=自己
            int i2 = 1;
            i2 = i2 + 2;
            // 以上可用复合运算符简写为：
            i2 += 2;
            // 复合运算符只能单项运算，不能混用

            int i3 = 4;
            i3 *= 2;
            #endregion

            #region 自增运算符
            // 用于变量本身自增1
            // a++  后置++ 先用再加 先输出再进行加法操作
            int t = 1;
            t++;
            Console.WriteLine(t);

            // ++a 前置++ 先加再用 先加法操作再输出
            int t2 = 1;
            ++t2;
            Console.WriteLine(t2);

            // 区别
            a = 1;
            Console.WriteLine(a++);// 先用再加，先输出1，再加
            // 此时a为2
            Console.WriteLine(++a);// 先加再用，先a+1，再输出
            // 此时a为3

            // 自减运算符
            // a--
            // --a
            // 与自增运算符同理
            #endregion
        }
    }
}
