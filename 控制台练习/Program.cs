namespace 控制台练习
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("控制台练习");
            // 通过W A S D控制黄色方块上下左右移动

            // 背景色
            Console.BackgroundColor = ConsoleColor.Red;
            // 清空控制台
            Console.Clear();
            // 光标隐藏
            Console.CursorVisible = false;
            // 文字颜色
            Console.ForegroundColor = ConsoleColor.Yellow;

            // 控制移动
            // 初始化坐标系 原点位置
            int x = 0;
            int y = 0;
            // 循环  while死循环不停检测
            while (true)
            {
                Console.SetCursorPosition(x, y);
                Console.Write("■");
                // 得到玩家输入信息 只接受一个字符
                char c = Console.ReadKey(true).KeyChar;
                // 擦掉之前画的方块 中文应为2个空格
                Console.SetCursorPosition(x, y);
                Console.Write("  ");
                // 根据得到的输入信息做处理
                switch (c)
                {
                    case 'W':
                    case 'w':
                        // 向上 y轴减2格
                        y -= 2;
                        // 改变位置后判断是否越界 即超出缓冲区
                        if (y < 0)
                        {
                            // 拉回原点
                            y = 0;
                        }
                        break;
                    case 'A':
                    case 'a':
                        // 向左 x轴减2格
                        x -= 2;
                        if (x < 0)
                        {
                            // 拉回原点
                            x = 0;
                        }
                        break;
                    case 'S':
                    case 's':
                        // 向下 y轴加1格
                        y += 1;

                        // 改变位置后判断左右两侧是否超出缓冲区
                        // 获取缓冲区高度 Console.BufferHeight
                        if ( y > Console.BufferHeight - 1) // 减1：减去方块自身所占位置
                        {
                            // 超出缓冲区则强制拉回 使y等于缓冲区大小
                            y = Console.BufferHeight - 1;
                        }
                          
                        break;
                    case 'D':
                    case 'd':
                        // 向右 x轴加2格
                        // 获取缓冲区宽度 Console.BufferWidth
                        x += 2;
                        if (x > Console.BufferWidth - 2) // 减2：减去方块自身所占位置
                        {
                            // 超出缓冲区则强制拉回 使y等于缓冲区大小
                            x = Console.BufferWidth - 2;
                        }
                        break;
                }
            }

        }
    }
}
