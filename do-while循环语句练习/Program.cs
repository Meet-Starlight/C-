namespace do_while循环练习题
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("do_while循环练习题");

            // 1. 要求输入用户名和密码，只要不是admin和8888就提示错误，重新输入
            string userName = "";
            string passWord = "";
            bool isShow = false;
            do
            {
                if (isShow) // 默认为false，即第一次不执行错误信息
                {
                    Console.WriteLine("错误，请重新输入");
                }
                // 循环输入
                Console.WriteLine("请输入用户名");
                userName = Console.ReadLine();
                Console.WriteLine("请输入密码");
                passWord = Console.ReadLine();
                isShow = true; // 设置为true，后续如果输入错误，输出错误信息
            } while (userName != "admin" || passWord != "8888");
        }
    }
}
