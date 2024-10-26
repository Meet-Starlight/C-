namespace 字符串拼接练习
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. 定义一个变量存储姓名，然后早控制台显示你好，xxx
            string myName = "小明";
            Console.WriteLine("你好" + myName);

            // 2. 输入用户名，年龄，班级，用占位符打印
            string str = "小明";
            string str1 = "19";
            string str2 = "4班";
            Console.WriteLine("{0}，{1}，{2}", str, str1, str2);

            // 3. 用户输入用户名，年龄，地址，最后占位符形式打印
            Console.WriteLine("请输入用户名");
            string name = Console.ReadLine();
            Console.WriteLine("请输入年龄");
            string a = Console.ReadLine();
            Console.WriteLine("请输入地址");
            string di = Console.ReadLine();
            Console.WriteLine("用户名：{0}，年龄：{1}，地址：{2}", name, a, di);
        }
    }
}
