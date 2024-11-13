using System;

namespace 入门实践
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 控制台基础设置
            // 隐藏光标
            Console.CursorVisible = false;
            // 设置舞台大小 即控制台大小
            // 通过变量存储，方便更改
            int w = 50;
            int h = 30;
            Console.SetWindowSize(w, h);
            // 设置缓存区大小
            Console.SetBufferSize(w, h);
            #endregion

            #region 多场景
            // 场景ID
            // 当前所在场景 初始化为1 表示第一个场景
            int nowSceneID = 1;
            while (true)
            {
                // 根据不同的场景ID处理不同情况
                switch (nowSceneID)
                {
                    case 1:
                        Console.Clear();
                        // 光标位置居中 x坐标取控制台宽的一半 x坐标需减去文字所占的位置 y坐标为文字占的空格数
                        Console.SetCursorPosition(w / 2 - 5, 10);
                        Console.Write("实践项目壹");

                        // 选项的编号 初始为0 选中开始游戏 在分支内修改编号来选中具体哪个选项
                        int nowSelIndex = 0;
                        // 开始场景逻辑的循环
                        while (true)
                        {
                            // 声明一个标识 用于处理在switch内退出while循环 默认为false
                            bool isQuitWhile = false;
                            // 显示内容
                            // 设置光标位置 x坐标取宽度一半 减去文字所占位置 y为文字所占空格数
                            Console.SetCursorPosition(w / 2 - 4, 13);
                            // 判断选中的是哪个选项 修改颜色 三目运算符
                            Console.ForegroundColor = nowSelIndex == 0 ? ConsoleColor.Red : ConsoleColor.White;
                            Console.Write("开始游戏");
                            Console.SetCursorPosition(w / 2 - 4, 15);
                            Console.ForegroundColor = nowSelIndex == 1 ? ConsoleColor.Red : ConsoleColor.White;
                            Console.Write("退出游戏");
                            // 检测玩家输入
                            char input = Console.ReadKey(true).KeyChar;
                            switch (input)
                            {
                                case 'W':
                                case 'w':
                                    // 改变编号
                                    --nowSelIndex;
                                    // 如果小于0 赋值为0 防止出现负数
                                    if (nowSelIndex < 0)
                                    {
                                        nowSelIndex = 0;
                                    }
                                    break;
                                case 'S':
                                case 's':
                                    //逻辑相同
                                    ++nowSelIndex;
                                    // 如果大于1 赋值为1
                                    if (nowSelIndex > 1)
                                    {
                                        nowSelIndex = 1;
                                    }
                                    break;
                                case 'J':
                                case 'j':
                                    // 判断nowSelIndex的值 切换到具体场景
                                    if (nowSelIndex == 0)
                                    {
                                        // 游戏场景
                                        nowSceneID = 2;
                                        // 退出内层while循环 否则无法切换场景
                                        // switch内无法直接退出while循环 通过改变标识来退出
                                        isQuitWhile = true;

                                    }
                                    else if (nowSelIndex == 1)
                                    {
                                        // 退出游戏 调用API 关闭控制台
                                        Environment.Exit(0);
                                    }
                                    break;
                            }

                            // switch内退出while循环 判断isQuitWhile是否为true 为true则执行break
                            if (isQuitWhile)
                            {
                                break;
                            }
                        }
                        break;
                    case 2:
                        Console.Clear();

                        #region 边界区域
                        // 字体颜色
                        Console.ForegroundColor = ConsoleColor.Red;
                        for (int i = 0; i < w; i += 2)
                        {
                            // 上方边界
                            Console.SetCursorPosition(i, 0);
                            Console.Write("■");

                            // 下方边界
                            Console.SetCursorPosition(i, h - 1);
                            Console.Write("■");

                            // 中间边界
                            Console.SetCursorPosition(i, h - 6);
                            Console.Write("■");
                        }

                        // 左侧边界
                        for (int i = 0; i < h; i++)
                        {
                            Console.SetCursorPosition(0, i);
                            Console.Write("■");

                            //右侧边界
                            Console.SetCursorPosition(w - 2, i);
                            Console.Write("■");
                        }
                        #endregion
                        // NPC相关属性
                        // 位置
                        int NpcX = 24;
                        int NpcY = 15;
                        // 最小攻击力
                        int NpcAtkMin = 5;
                        // 最大攻击力
                        int NpcAtkMax = 10;
                        // 血量
                        int NpcHp = 150;
                        // 图标
                        string NpcIcon = "■";
                        // 声明一个自定义的颜色类型 用于NPC的图标颜色
                        ConsoleColor NpcColor = ConsoleColor.Green;
                        // 游戏场景主循环 检测玩家输入相关循环
                        while (true)
                        {
                            // Npc血量大于0，绘制NPC图标
                            if (NpcHp > 0)
                            {
                                // 绘制NPC图标
                                Console.SetCursorPosition(NpcX, NpcY);
                                Console.ForegroundColor = NpcColor;
                                Console.Write(NpcIcon);
                            }
                        }
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("结束场景");
                        break;
                }
            }
            #endregion
        }
    }
}
