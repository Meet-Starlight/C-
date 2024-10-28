namespace 逻辑运算符
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("逻辑运算符");
            // 对bool类型的逻辑运算

            #region 逻辑与
            // &&
            // 规则：对两个bool值进行逻辑与运算，有假则假 同真为真
            bool result = true && false; // false
            Console.WriteLine(result);

            result = true && true; // true
            Console.WriteLine(result);

            // 左右两边可写：bool变量  条件运算符
            // 逻辑运算符优先级低于条件运算符 算术运算符
            result = 3 > 2 && 6 > 1; // true
            Console.WriteLine(result);

            int i = 3;
            result = i > 2 && 3 < 1; // false
            Console.WriteLine(result);

            // 多个逻辑与组合
            // 在没有括号的情况下，从左到右 依次运算 有括号先看括号
            int i2 = 5;
            result = i2 > 1 && i2 < 5 && i > 1 && i < 5; // false
            Console.WriteLine(result);
            #endregion

            #region 逻辑或
            // ||
            // 规则：对两个bool值进行逻辑或运算 有真则真 同假为假 （ 有一个true则为真 ）
            result = true || false; // true 有真则真
            Console.WriteLine(result);

            result = false || false; // false 同假为假
            Console.WriteLine(result);
            #endregion

            #region 逻辑非
            // ! 
            // 规则：对一个bool值进行取反 真变假 假变真
            result = !true; // false
            Console.WriteLine(result);

            result = !false;
            Console.WriteLine(result);
            // 逻辑非优先级较高 后跟条件运算符等时，应加括号
            result = !(3 > 2);  // false
            Console.WriteLine(result);
            #endregion

            #region 混合使用的优先级
            // 逻辑非优先级最高 逻辑与优先级高于逻辑或
            // 逻辑运算符优先级低于算数运算符 条件运算符 逻辑非除外
            bool gameOver = false;
            int hp = 100;
            bool isDead = false;
            bool isMustOver = true;
            result = gameOver || hp < 0 && !isDead || isMustOver; // true
            Console.WriteLine(result);
            #endregion

            #region 短路规则
            int i3 = 1;
            // 短路规则：逻辑与 逻辑或 左边满足条件时，右边不再计算
            result = i3 > 0 || ++i3 >= 1;
            // 上式左边i3 > 0满足条件 右边不再计算，因此i3为1
            Console.WriteLine(i3);
            #endregion
        }
    }
}
