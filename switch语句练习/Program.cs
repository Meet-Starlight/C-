namespace switch语句练习
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("switch语句练习");
            // 1. 基本工资4000，根据评级决定绩效
            int basicPay = 4000;
            string Rate = Console.ReadLine();
            switch (Rate)
            {
                case "A":
                    Console.WriteLine("评级为A，工资为" + (basicPay + 500));
                    break;
                case "B":
                    Console.WriteLine("评级为B，工资为" + basicPay);
                    break;
                case "C":
                    Console.WriteLine("评级为C，工资为" + (basicPay - 300));
                    break;
                case "D":
                    Console.WriteLine("评级为D，工资为" + (basicPay - 500));
                    break;
                case "E":
                    Console.WriteLine("评级为E，工资为" + (basicPay - 800));
                    break;
            }

            // 2. 总额10元，型号1需要5元，2需要7元，3需要11元，计算余额
            int money = 10;
            string str = Console.ReadLine();
            switch (str)
            {
                case "1":
                    money -= 5;
                    Console.WriteLine("余额{0}", money);
                    break;
                case "2":
                    money -= 7;
                    Console.WriteLine("余额{0}", money);
                    break;
                case "3":
                    Console.WriteLine("余额不足");
                    break;
            }

            // 3. 控制台输入1-9，输出大写
            Console.WriteLine("请输入1-9之间的数字");
            try
            {
                int number = int.Parse(Console.ReadLine());
                switch (number)
                {
                    case 1:
                        Console.WriteLine("一");
                        break;
                    case 2:
                        Console.WriteLine("二");
                        break;
                    case 3:
                        Console.WriteLine("三");
                        break;
                    case 4:
                        Console.WriteLine("四");
                        break;
                    case 5:
                        Console.WriteLine("五");
                        break;
                    case 6:
                        Console.WriteLine("六");
                        break;
                    case 7:
                        Console.WriteLine("七");
                        break;
                    case 8:
                        Console.WriteLine("八");
                        break;
                    case 9:
                        Console.WriteLine("九");
                        break;
                    default:
                        Console.WriteLine("你输入的数字超过了范围");
                        break;
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("请输入正确的数字");
                Console.WriteLine(e.Message);
            }
        }
    }
}
