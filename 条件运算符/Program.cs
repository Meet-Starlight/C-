namespace 条件运算符
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("条件运算符");

            #region 条件运算符
            // 用于比较两个常量或变量‘
            // 是否大于 >
            // 是否小于 <
            // 是否等于 ==
            // 是否不等于 !=
            // 是否大于等于 >=
            // 是否小于等于 <=
            // 条件运算符一定存在左右两边的内容
            // 语法：左边内容 条件运算符 右边内容
            int a = 1;
            int b = 2;
            // a > b 错误写法，不能单独使用，条件运算符有返回值(布尔值)，应配合输出语句
            Console.WriteLine(a > b);// false
            Console.WriteLine(b > a);// true
            // 布尔变量写法
            bool result = a != b;
            Console.WriteLine(result);// true
            #endregion

            #region 应用方法
            // 变量与变量比较
            int c = 3;
            int d = 4;
            Console.WriteLine(c > d);

            // 变量和数值比较
            int e = 5;
            Console.WriteLine(e > 2);

            // 数值和数值比较
            result = 6 == 6;
            Console.WriteLine(result);

            // 计算结果比较
            // 条件运算符的优先级低于算数运算符
            // 先算算数运算符
            result = e + 3 > d - 2 + 1;// 8 > 3
            Console.WriteLine(result);
            #endregion

            #region 不能进行范围比较
            a = 5;
            // 判断是否在某两个值之间
            // 1 < a < 6
            // 在C#中不能这样写
            // result = 1 < a < 6;
            #endregion

            #region 不同类型间的比较
            // 不同数值类型之间，无限制
            int i = 6;
            float f = 1.2f;
            double d2 = 10.1;
            byte y = 90;
            Console.WriteLine(y > f);
            Console.WriteLine(y < d2);
            Console.WriteLine(y != i);

            // 特殊类型 char string bool 只能同类型进行 == 和 != 比较
            string str = "123";
            char c2 = 'A';
            bool bo = true;

            result = str == "234";// false
            result = str == "123";// true

            result = c2 == 'A';
            // char可以和数值比较，因为char可以隐式转换为数值类型
            result = c2 > 23;

            result = bo == false;// false
            #endregion
        }
    }
}
