namespace if语句
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("if语句");
            // if分支语句：可以让程序产生逻辑变化的语句
            #region if语句
            // 满足条件时多执行一些代码
            // 语法：
            // if( bool类型的值)
            // {
            //    满足条件执行的代码;
            // }
            // if语句可以嵌套使用
            int a = 1;
            if (a == 1)
            {
                Console.WriteLine("条件为真");
            }
            Console.WriteLine("if语句外的代码");

            a = 2;
            if (a > 0 && a < 5)
            {
                Console.WriteLine("a的值在0-5之间");
            }

            // 嵌套使用
            // 可以无限嵌套
            string name = "小明";
            string password = "12345";
            if (name == "小明")
            {
                Console.WriteLine("用户名正确");
                if (password == "12345")
                {
                    Console.WriteLine("密码正确");
                    Console.WriteLine("登录成功");
                }
            }
            #endregion

            #region if...else 语句
            // 产生两条分支 对应满足条件执行和不满足条件执行
            //语法 
            // if ( bool ) {
            //     满足条件执行
            // }
            // else 
            // {
            //  不满足条件执行
            // }
            a = 13;
            if (a > 4)
            {
                Console.WriteLine("成立");
            }
            else
            {
                Console.WriteLine("不成立");
            }
            #endregion

            #region if...else if...else
            // 产生n条分支 最先满足其中的一个条件 就执行什么
            // 从上到下执行，满足其中一个后停止
            // 语法：
            // if ( bool ) {
            //     满足条件执行
            // }
            // else if ( bool类型值 )
            // {
            //    满足条件执行
            // }
            // 中间可以有n个满足条件执行的代码块
            // else 
            // 都不满足 执行此处
            // {
            //  不满足条件执行
            // }
            int a3 = 6;
            if (a3 >= 10)
            {
                Console.WriteLine("a大于等于10");
            }
            else if (a3 > 5 && a3 < 10)
            {
                Console.WriteLine("a大于5且小于10");
            }
            else if (a3 >=0 && a3 <= 10)
            {
                Console.WriteLine("a在0和5之间");
            }
            else
            {
                Console.WriteLine("a小于0");
            }
            #endregion
        }
    }
}
