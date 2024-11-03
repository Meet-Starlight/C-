namespace do_while循环语句
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("do_while循环语句");

            // while循环：先判断条件再执行
            // do..while循环：至少执行一次循环语句块中的逻辑，再判断是否继续

            #region 基本语法
            // do
            // {
            // 循环语句块
            // } while (bool类型的值);
            // do while 语句需要加分号
            #endregion

            #region 实际使用
            // 实际开发中 do while 使用较少
            do
            {
                // 先执行一次
                Console.WriteLine("do while");
            } while (false); // 再判断是否继续执行

            int a = 0;
            do
            {
                ++a;
                Console.WriteLine(a);
            } while (a < 10); // 打印1-10
            #endregion

            #region 嵌套使用
            // do while 内可以嵌套使用别的语句
            // 以if为例：
            do
            {
                if(true)
                {
                    Console.WriteLine("1");
                }
            } while (true); // 死循环
            #endregion
        }
    }
}
