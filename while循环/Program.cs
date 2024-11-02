namespace while循环
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("while循环");
            #region 作用
            // 循环语句可以让代码重复执行，满足一定条件时退出循环

            #endregion

            #region 语法
            // while( bool类型的值 )
            // {
            //   满足条件时执行的内容
            // }
            //   代码执行完后回到while循环开头，进行条件判断，满足则继续执行，不满足则跳出循环，执行后面的代码

            // 死循环 不停执行，直到进程卡死或崩溃
            // 死循环只在目前学习控制台程序时使用，在unity中基本不用
            //int i = 0;
            //while (true)
            //{

            //    Console.WriteLine(i++);
            //}

            // 非死循环 计算一个非0的整型，累加到10停止
            int i = 0;
            while (i < 10)
            {
                ++i;
                // 输出累加的每一个数字
                Console.WriteLine(i);
            }
            #endregion

            #region 嵌套使用
            int a = 0;
            int b = 0;
            while (a < 10) // 外层先执行1次，进入内层
            {
                ++a;
                while (b < 10) // 内层全部执行完，b=10后，返回继续执行外层
                {
                    ++b;
                }
            }

            int a2 = 0;
            while (a2 < 10) // 执行1次后进入内层
            {
                ++a2;
                int b2 = 0; // 每次循环的b2与上一次循环无关，即b2会被重新声明，重复循环
                while (b2 < 10)// 循环完成后返回外层
                {
                    ++b2;
                }
            }
            #endregion

            #region 流程控制关键字
            // 控制循环逻辑的关键词
            // break：跳出循环
            while (true)
            {
                Console.WriteLine("break之前的代码");
                break; // 遇到break，跳出循环 break后面的代码不打印
                Console.WriteLine("break之后的代码"); // 不打印此行代码
            }
            Console.WriteLine("循环外代码");

            int i2 = 0;
            while(true)
            {
                ++i2;
                Console.WriteLine(i2);
                if (i2 == 10) // 判断当i2循环到10后，执行break，跳出循环
                {
                    break; // 与循环关联 与if无关
                }
            }
            Console.WriteLine(i2);
            Console.WriteLine("----------------");

            // continue：回到循环开始，继续执行
            //while (true)
            //{
            //    Console.WriteLine("continue之前的代码");
            //    continue; // 不会跳出循环 而是回到while (true)判断是否满足条件 满足则继续循环 只打印continue之前的代码
            //    Console.WriteLine("continue之后的代码");
            //}
            //Console.WriteLine("循环外代码");

            // 打印1 - 20 之间的奇数
            int a3 = 0;
            while (a3 < 20)
            {
                ++a3;
                if (a3 % 2 != 0)
                {
                    Console.WriteLine(a3);
                    continue;
                }
            }
            // 方法2
            int a4 = 0;
            while (a4 < 20)
            {
                ++a4;
                if (a4 % 2 == 0) // 判断是否为偶数，是则进入if内执行continue，跳过输出，继续循环，否则跳过if判断，执行输出
                {
                    continue;
                }
                Console.WriteLine(a4);
            }
            #endregion
        }
    }
}
