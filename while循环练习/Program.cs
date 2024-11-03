namespace while循环练习
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("while循环练习");
            // 1. 控制台输出1-100
            int num = 0;
            while (num < 100)
            {
                ++num;
                Console.WriteLine(num);
            }
            Console.WriteLine("-------------");

            // 2. 控制台输出1-100之间所有整数和
            int num2 = 0;
            int a = 0;
            while (num2 < 100)
            {
                ++num2;
                a += num2;
            }
            Console.WriteLine(a);
            Console.WriteLine("-------------");

            // 3. 计算1-100之间除了能被7整除之外的所有整数和
            int num3 = 0;
            int a2 = 0;
            while (num3 < 100)
            {
                ++num3;
                if (num3 % 7 == 0)
                {
                    continue;
                }
                a2 += num3;
            }
            Console.WriteLine(a2);
            Console.WriteLine("-------------");

            // 4. 提示用户输入一个数，判断是否为素数，并打印
            try
            {
                Console.WriteLine("请输入一个数字");
                int a3 = int.Parse(Console.ReadLine());
                int index = 2;
                while (index < a3)
                {
                    // 假设输入的数字是6，index是2
                    if (a3 % index == 0) // 6 % 2 能整除，得0，执行if内的代码
                    {
                        break; // 跳出循环，不执行++index
                    }
                    ++index;
                }
                if (index != a3) // 判断：若累加后的index不等于输入的值，则不是素数
                {
                    Console.WriteLine("不是素数");
                }
                else
                {
                    Console.WriteLine("是素数");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("请输入正确的数字");
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("-------------");

            // 5. 要求输入用户名admin，密码8888，输入错误则一直输入，直到输入正确为止
            while (true)
            {
                Console.WriteLine("请输入用户名和密码");
                string userName = Console.ReadLine();
                string passWord = Console.ReadLine();
                if (userName == "admin" && passWord == "8888")
                {
                    Console.WriteLine("登录成功");
                    break;
                }
                else
                {
                    Console.WriteLine("登录失败，请重新输入");
                }
            }
            Console.WriteLine("-------------");

            // 6. 输入班级人数 然后依次输入成绩，计算班级学员的平均成绩和总成绩
            try
            {
                Console.WriteLine("请输入班级人数");
                int num5 = int.Parse(Console.ReadLine());
                int sum = 0; // 总成绩
                // 第几次 第几个人
                int index = 0;
                while (index < num5)
                {
                    ++index;
                    Console.WriteLine("请输入第{0}个学员的成绩", index);
                    // 得到输入的成绩
                    int cj = int.Parse(Console.ReadLine());
                    sum += cj;
                }
                // 打印平均成绩和总分
                Console.WriteLine("平均成绩{0}，总分{1}", sum / num5, sum);
            }
            catch (Exception e)
            {
                Console.WriteLine("请输入正确数字 ");
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("-------------");

            // 7. 定义一个整型变量sum 然后分别把1--100之间的数字依次累加到sum中 当sum的值大于500时，中断操作，打印累加到第几个数时使sum大于500
            int sum2 = 0;
            int index2 = 0;
            while (index2 < 100)
            {
                ++index2;
                sum2 += index2;
                if (sum2 > 500)
                {
                    break;
                }
            }
            Console.WriteLine("累加到第{0}个数时，sum大于500", index2);
            Console.WriteLine("-------------");

            // 8. 初始数据为100，每个月增长20%，多久可以达到1000
            // 上一次的结果 * 20% + 上一次的结果 = 本月数据

            // 基础数据
            int pers = 100;
            // 月份
            int month = 0;
            while (true)
            {
                // 计算本月结果 结果取整数，小数float类型转为int类型
                pers += (int)(pers * 0.2f);
                // 每计算一次 月份累加1
                ++month;
                if (pers >= 1000)
                {
                    break;
                }
            }
            Console.WriteLine("需要{0}个月才能达到1000", month);
            Console.WriteLine("-------------");

            // 9. 求数列1，1，2，3，5，8，13的第20位
            // 斐波那契数列 面试常考
            // 2 = 1 + 1
            // 3 = 2 + 1
            // 5 = 3 + 2
            // 从第三个数开始，每个数的值等于前两个数相加

            // 定义第一个数和第二个数
            int n1 = 1;
            int n2 = 1;
            // 计数
            int index3 = 0;
            // 结果 初始化为0
            int result = 0;
            // 循环20次
            while (index3 < 20)
            {
                ++index3;
                // 前两个数固定都为1，即n1 n2
                if (index3 == 1) // 第一次
                {
                    result = n1;
                }
                else if (index3 == 2) // 第二次
                {
                    result = n2;
                }
                else // 后续
                {
                    // 从第三个数开始，用前两个数相加得到结果
                    result = n1 + n2;
                    // 第四个数
                    // 此时的n2相当于第三个数
                    n1 = n2;
                    n2 = result;
                }
            }
            Console.WriteLine(result);
            Console.WriteLine("-------------");

            // 找出100内所有素数并打印
            int num4 = 2;
            while (num4 < 100)
            {
                int i = 2;
                while (i < num4)
                {
                    // 判断整除
                    if (num4 % i == 0)
                    {
                        break;
                    }
                    ++i;
                }
                // 相等时证明该值之前的数都不能整除，是素数
                if (i == num4)
                {
                    Console.WriteLine(num4);
                }
                ++num4;
            }
        }

    }
}
