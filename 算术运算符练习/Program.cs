namespace 算术运算符练习
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. 定义一个变量存储年龄，计算10年后是多少
            int myAge = 20;
            myAge += 10;
            Console.WriteLine("10年后是:" + myAge);

            // 2. 计算半径为5的圆的面积和周长
            const float PI = 3.14f;
            float Radius = 5;
            Console.WriteLine("圆的面积是" + (PI * (Radius * Radius)));
            Console.WriteLine("圆的周长是" + (2 * PI * Radius));

            // 3. 计算三门课总分和平均值
            int c = 83;
            int u = 70;
            int m = 90;
            int sum = c + u + m;
            float avg = sum / 3f;
            Console.WriteLine("总分是:" + sum);
            Console.WriteLine("平均分是" + avg);

            // 4. 请说明number1和number2，number3的结果
            int a = 10;
            int b = 20;
            int number1 = ++a + b;

            a = 10;
            b = 20;
            int number2 = a + b++;

            a = 10;
            b = 20;
            int number3 = a++ + ++b + a++;

            // 5. 交换a和b的值
            // 中间变量法
            int a2 = 99;
            int b2 = 87;
            // 声明一个临时的中间变量
            int map = 0;
            map = a2;
            a2 = b2;
            b2 = map;
            Console.WriteLine(a2);
            Console.WriteLine(b2);

            // 算术运算符法
            a2 = 99;
            b2 = 87;
            a2 = a2 + b2; // a2 = 99 + 87
            b2 = a2 - b2; // b2 = 99 + 87 - 87 b2 = 99
            a2 = a2 - b2; // a2 = 99 + 87 - 99 a2 = 87
        }
    }
}
