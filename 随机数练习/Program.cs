namespace 随机数练习
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("随机数练习");
            // NPC血量20，防御10 玩家攻击力为8--12之间的一个值 通过控制台打印信息表现玩家攻击NPC的过程，掉血情况
            // 攻击力小于防御力时，不掉血，否则掉血=攻击力和防御力的差值

            // 声明随机数对象
            Random r = new Random();
            // 初始化攻击力 设置为0 后续随机
            int i = 0;
            // 初始化NPC血量和防御
            int HP = 20;
            int DEF = 10;
            while (true)
            {
                // 随机攻击力
                i = r.Next(8, 13);
                if( i > DEF)
                {
                    // 计算差值后用血量减去差值，得到剩余血量
                    HP = HP - (i - DEF);
                    Console.WriteLine("玩家对NPC造成了{0}点伤害，NPC剩余血量{1}", i - DEF, HP);

                    // 血量小于0时结束
                    if (HP < 0)
                    {
                        break;
                    }
                }else
                {
                    Console.WriteLine("玩家攻击力小于NPC防御力，未造成伤害，NPC剩余血量{0}", HP);
                }
                Console.WriteLine("请按任意键继续");
                Console.ReadKey(true);
                Console.Clear();
            }
            Console.WriteLine("NPC已死亡，游戏结束");
        }
    }
}
