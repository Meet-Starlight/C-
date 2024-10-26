using System;

namespace 变量的命名规则
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 变量命名规则
            // 1. 不能重名 int i = 1; string i = "2";
            // 2. 不能以数字开头 int 2i = 1;
            // 3. 不能使用程序关键字 int if = 3;
            // 4. 不能有特殊符号，下划线除外 int i% = 1;
            // 5. 不建议使用汉字命名 int 变量 = 2;
            // 建议的命名规则：变量名要有含义，做到见名知意，使用英文或拼音
            string name = "小明";
            #endregion

            #region 常用命名规范
            // 驼峰命名法 首字母小写，之后单词首字母大写 适用于变量
            string myName = "小李";

            // 帕斯卡命名法 所有单词首字母都大写 适用于函数和类
            // 此处用变量演示
            string MyName = "小兰";

            // C#严格区分大小写
            #endregion
        }
    }
}