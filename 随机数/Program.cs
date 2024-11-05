namespace 随机数
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("随机数");
            #region 产生随机数对象
            // 固定语法
            // Random 随机数变量名 = new Readom();
            Random r = new Random();
            #endregion

            #region 生成随机数
            // 生成非负数随机数 产生的数会非常大
            int i = r.Next();
            Console.WriteLine(i);

            // 固定范围 如生成0--99的随机数
            i = r.Next(100);
            Console.WriteLine(i);

            // 生成5--99的随机数
            i = r.Next(5, 100);
            Console.WriteLine(i);
            #endregion
        }
    }
}
