namespace 三目运算符
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("三目运算符");
            #region 基本语法
            // 3个空位 2个符号
            // 语法： 空位 ? 空位 : 空位;
            // bool类型 ? bool类型为真返回的内容 : bool类型为假返回的内容
            // 返回值类型必须一致
            #endregion

            #region 具体使用
            string str = false ? "条件为真" : "条件为假";
            Console.WriteLine(str);

            int a = 5;
            str = a > 1 ? "a满足条件" : "a不满足条件";
            Console.WriteLine(str);

            // 第一个空位始终为bool类型表达式，bool变量，条件表达式，逻辑运算符表达式
            // 第二三个空位 保证结果类型一致
            #endregion
        }
    }
}
