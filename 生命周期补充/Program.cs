namespace 生命周期补充
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("生命周期补充");
            // 目前接触的代码均写在函数语句块中
            // 函数语句块是目前最高层级的语句块

            // a 声明在函数语句块中
            int a = 1;
            {
                // 大括号内的代码 层级比函数语句块低
                // 在低层级也可以使用在高层级语句块声明的变量a
                Console.WriteLine(a);

                // 在低层级声明的变量，无法在当前层级外使用 即离开当前层级，变量b的生命周期结束 变量b释放
                int b = 2;
            }
            // 在更高层级使用低层级声明的变量，报错
            Console.WriteLine(b);
        }
    }
}
