namespace 三目运算符练习
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 比较两个数的大小 求出最大的
            try
            {
                Console.WriteLine("请分别输入两个数字");
                string str = Console.ReadLine();
                string str2 = Console.ReadLine();
                int a = int.Parse(str);
                int b = int.Parse(str2);
                string str3 = a > b ? "最大数是a" + a : "最大数是b" + b;
                Console.WriteLine(str3);
            }
            catch
            {
                Console.WriteLine("请输入正确的数字");
            }
            // 判断是否是闰年
            try
            {
                Console.WriteLine("请输入年份");
                int year = int.Parse(Console.ReadLine());
                Console.WriteLine(year % 400 == 0 || year % 4 == 0 && year % 100 != 0 ? year + "是闰年" : year + "不是闰年");

            }
            catch
            {
                Console.WriteLine("请输入正确的年份");
            }
        }
    }
}
