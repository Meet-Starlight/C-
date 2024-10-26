namespace 显式转换
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 显式转换--> 手动处理，强制转换
            #region 括号强转
            // 一般情况下，将高精度的类型强制转换为低精度
            // 变量类型 变量名 = （ 变量类型 ）变量;
            // 需要注意精度问题和范围问题

            // 相同大类整型--有符号
            sbyte sb = 3;
            short sh = 5;
            int i = 2;
            long l = 1;
            // 括号内为想要强转的类型，如将int转为short
            sh = (short)i;
            Console.WriteLine(sh);
            // 如果转换的范围超出对应变量类型装载的范围，会造成异常，如将i的值改为40000，超出转换后short类型的范围，则会输出错误的值,因此括号强转要注意范围问题
            i = 40000;
            sh = (short)i;
            Console.WriteLine(sh);
            // 相同大类整型--无符号 强转规则与有符号相同
            byte b = 1;
            uint ui = 1;
            b = (byte)ui;
            // 浮点数
            // 浮点数强制转换要注意精度问题，即有效数字，当有效数字超过转换后变量类型的位数时，会以转换后的变量类型的有效数字位数输出，会丢失精度
            float f = 1.2f;
            double db = 1.5f;
            f = (float)db;
            Console.WriteLine(f);
            // 精度问题
            db = 1.23456789987654329f;
            f = (float)db;
            Console.WriteLine(f);

            // 不同类型之间的强制转换
            // 无符号和有符号
            uint ui2 = 1;
            int i2 = 1;
            ui2 = (uint)i2;
            Console.WriteLine(ui2);
            // 同时需要注意范围问题，如将i2改为负数，转换后会因范围问题输出异常（ 无符号无法装载负数 ）
            i2 = -1;
            ui2 = (uint)i2;
            Console.WriteLine(ui2);
            // 浮点与整型
            // 以下为简化写法，直接写小数值，转换方法与前面相同，此处的int变量不再声明，直接使用前文i2
            // 浮点数转整数会有精度问题，丢失小数位，保留整数位
            i2 = (int)6.63f;
            Console.WriteLine(i2);
            // char和数值类型
            // 字符型可以隐式转换成数值型
            i2 = 'C';
            // 数值型不能隐式转换成字符型，需要强制转换，此处使用简写
            char c = (char)i2;
            Console.WriteLine(c);
            //bool和string
            // 无法通过括号强转为其他类型
            #endregion

            #region parse法
            // 把字符串类型转为对应的类型
            // 变量类型.parse("字符串")
            // 注意，字符串必须能转为对应类型，且大小不超过转换类型的范围，否则报错
            // 有符号
            // string str3 = "123" 简写如下：
            int i3 = int.Parse("123");
            Console.WriteLine(i3);
            // 填写的字符串必须能转成对应类型的字符，否则会报错,如字符串写成小数，转整型
            // int i4 = int.Parse("123.1");
            // Console.WriteLine(i4);
            // 字符串转short
            short sh1 = short.Parse("567");
            Console.WriteLine(sh1);
            // 组合写法
            Console.WriteLine(sbyte.Parse("100"));
            // 以上写法等同于：
            sbyte sb1 = sbyte.Parse("100");
            Console.WriteLine(sb1);

            // 无符号
            // 与有符号转换方法和规则相同
            Console.WriteLine(byte.Parse("10"));
            Console.WriteLine(uint.Parse("100"));
            Console.WriteLine(ulong.Parse("1000"));

            // 浮点数
            // 方法相同
            float f1 = float.Parse("12.3");
            Console.WriteLine(f);

            // 特殊类型
            // bool类型的字符串只能写逻辑值
            Console.WriteLine(bool.Parse("true"));
            Console.WriteLine(bool.Parse("false"));
            #endregion

            #region Convert法
            // 更准确的将各个类型之间相互转换
            // Convert.To目标类型(变量或常量）
            // 填写的变量或常量必须准确，否则报错

            // 转字符串
            // 以int类型举例，int类型4字节，32位，所以是ToInt32
            int a = Convert.ToInt32("12");
            Console.WriteLine(a);

            // 精度更高，在小数转整数时会四舍五入
            a = Convert.ToInt32(2.8f);
            Console.WriteLine(a);

            // 特殊类型bool转换，true输出1，false输出0
            a = Convert.ToInt32(true);
            Console.WriteLine(a);
            a = Convert.ToInt32(false);
            Console.WriteLine(a);

            // 特殊类型char转换 输出字符的ASCII值
            a = Convert.ToInt32('B');
            Console.WriteLine(a);
            #endregion

            #region 各类型的Convert转换方法
            // sbyte
            sbyte sb3 = Convert.ToSByte("123");

            // short  2字节，16位
            short st = Convert.ToInt16("1");

            // int 4字节，32位
            int a1 = Convert.ToInt32("12");

            // long 8字节 64位
            long l1 = Convert.ToInt64("1");

            // byte 
            byte b1 = Convert.ToByte("123");

            // ushort
            ushort u1 = Convert.ToUInt16("1");

            // uint
            uint ui3 = Convert.ToUInt32("123");

            // ulong
            ulong ul1 = Convert.ToUInt64("123");

            // float
            float f2 = Convert.ToSingle("12.3");

            // double
            double d2 = Convert.ToDouble("1.23");

            //decimal
            decimal d3 = Convert.ToDecimal("12.3");

            // bool
            bool bo2 = Convert.ToBoolean("true");

            // char
            char c2 = Convert.ToChar("A");

            // string
            string st1 = Convert.ToString(123);
            #endregion

            #region 其他类型转string
            // 拼接打印
            // 变量.toString();
            // 适用于任何类型
            string str = 1.ToString();

            str = true.ToString();

            str = 3.6.ToString();

            int i5 = 12;
            str = i5.ToString();

            // 字符串拼接打印时，其实就调用了该方法，将非string的变量类型转为string，再拼接打印
            Console.WriteLine("123321" + 3 + true);
            #endregion
        }
    }
}
