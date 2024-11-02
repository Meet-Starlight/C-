namespace switch语句
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("switch语句");
            #region 基础语法
            // switch( 变量 )
            // {
            //   变量 == 常量 时，执行对应分支的代码
            //   case 常量
            //      满足条件执行的代码
            //      break; -- 分支1
            //   case 常量
            //      break; -- 分支2
            //   case 常量
            //      break; -- 分支...
            //   default：
            //        如果上面的case条件都不满足，执行此处的代码
            // }
            // 注意：case处的常量只能写一个值 不能写范围，条件运算符，逻辑运算符
            // switch只判断变量是否等于一个固定值
            // switch一般配合枚举使用
            int a = int.Parse(Console.ReadLine());
            switch (a)
            {
                case 1:
                    Console.WriteLine("a的值是1");
                    break;
                case 2:
                    Console.WriteLine("a的值是2");
                    break;
                case 3:
                    Console.WriteLine("a的值是3");
                    break;
                default:
                    Console.WriteLine("你输入的数值不在1-3之间，或为0，小数");
                    break;
            }
            #endregion

            #region default可省略
            string str = Console.ReadLine();
            switch (str)
            {
                case "122":
                    Console.WriteLine("你输入的是122");
                    break;
                case "123":
                    Console.WriteLine("你输入的是123");
                    break;
            }
            #endregion

            #region 可自定义常量
            // 可声明一个常量用作case值
            const char c2 = 'A';
            char c = 'A';
            switch (c)
            {
                case c2:
                    Console.WriteLine("c的值等于常量c2");
                    break;
            }
            #endregion

            #region 贯穿
            // 满足某些条件时，做的事情一样，可以使用贯穿
            int aa = 1;
            switch (aa)
            {
                case 1:
                case 2:
                    Console.WriteLine("是个数字");
                    // case 1 和 case 2 输出的内容相同( 逻辑相同 ），因此可以省略case 1的输出内容，使其贯穿到case 2
                    break;
            }
            #endregion
        }
    }
}
