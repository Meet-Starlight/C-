using System;

namespace 异常捕获
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("异常捕获");
            #region 作用
            // 将玩家输入的内容存入变量
            //string str = Console.ReadLine();
            // 将str转为int类型 Parse方法转换必须合法，如果是汉字转数字则报错
            //int i = int.Parse(str);

            // 异常捕获的作用是在程序报错时，防止程序卡死

            #endregion

            #region 基本语法
            // 必备部分
            try
            {
                // 希望进行异常捕获的代码块写到这里
                string st = Console.ReadLine();
                int i2 = int.Parse(st);
                // 如果try中的代码报错，跳转到catch
            }
            catch
            {
                // 捕获异常的部分
                // catch(Exception e)
                // 带参数的写法 e会携带具体报错信息，打印e即可查看报错
            }
            // 可选部分
            finally
            {
                // 最后执行的代码 不管有没有出错都会执行
                // 目前了解即可
            }
            // 异常捕获的基本结构代码块不需要加分号
            #endregion

            #region 实践 以作用中的代码为例
            try
            {
                string str = Console.ReadLine();
                int i = int.Parse(str);
                Console.WriteLine(i);
            }
            catch
            {
                Console.WriteLine("请输入合法数字");
            }
            #endregion

            #region 练习
            // 输入一个数字，如果输入有误，提示输入错误
            try
            {
                string s = Console.ReadLine();
                int i3 = int.Parse(s);
                Console.WriteLine("您输入的数字是" + i3);
            }
            catch
            {
                Console.WriteLine("输入错误 请输入正确的数字");
            }
            // 输入姓名 地址 成绩 如果输入的成绩有误则输出错误 如果无误则转为整形存储
            try
            {
                Console.WriteLine("请依次输入姓名 地址 成绩");
                string s2 = Console.ReadLine();
                string s3 = Console.ReadLine();
                int chengji = int.Parse(Console.ReadLine());
            }
            catch(Exception e)
            {
                Console.WriteLine("请输入正确的成绩");
                // 加Message后，只输出报错信息，不输出报错代码的具体行数
                Console.WriteLine(e.Message);
            }
            #endregion
        }
    }
}