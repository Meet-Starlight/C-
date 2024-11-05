namespace 控制台相关
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("控制台相关方法");
            #region 输入输出复习
            // 输出
            Console.WriteLine("111"); // 光标空行

            Console.Write("111"); // 不空行

            // 输入
            string str = Console.ReadLine(); // 一直输入

            // 按下键盘上任意按键，输入结束 只输入一个字符 获取输入的字符需要加.KeyChar
            // 补充：如果在ReadKey的括号内写true参数，输入的内容不会显示在控制台，但还是会被记录
            char str2 = Console.ReadKey(true).KeyChar;
            #endregion

            #region 控制台其他方法
            // 1. 清空
            Console.Clear();

            // 2. 设置控制台大小
            // 窗口大小 缓冲区大小
            // 先设置窗口 再设置缓冲区 缓冲区大小不能小于窗口大小 窗口大小不能大于控制台最大尺寸

            // 窗口大小
            Console.SetWindowSize(100, 50);  // 宽 高

            // 缓冲区大小  即可打印内容区域的宽高
            Console.SetBufferSize(1000, 1000);

            // 设置光标位置
            // 控制台是以左上角为原点的二维平面坐标系，右方x轴正朝向，下方y轴正朝向
            // 边界问题：在缓冲区范围内设置，不能超出缓冲区大小
            // 横纵距离单位不同 1y = 2x 视觉上
            // 设置后 内容从光标位置开始打印
            Console.SetCursorPosition(10, 5);
            Console.WriteLine("123");

            // 设置颜色 一般在程序开始时设置
            // 文字颜色
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("11");
            Console.ForegroundColor = ConsoleColor.Red; // 11之后打印的内容会输出为红色

            // 背景颜色
            // 重置背景颜色后需要清空控制台使颜色生效
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear(); 

            // 光标显隐
            // bool类型的属性
            Console.CursorVisible = false;

            // 关闭控制台
            Environment.Exit(0);
            #endregion
        }
    }
}
