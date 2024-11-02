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
        }

    }
}
