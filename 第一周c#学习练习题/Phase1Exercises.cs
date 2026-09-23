using System.ComponentModel;

namespace HelloDotNetGuide.CSharp语法
{
    /// <summary>
    /// 第一阶段练习题：基础语法和概念
    /// 完成下面的每个方法，实现注释中描述的功能。
    /// 做完后对照 Phase1ExerciseAnswers.cs 检查答案。
    /// </summary>
    public class Phase1Exercises
    {
        #region 一、变量和数据类型

        /// <summary>
        /// 练习1：声明变量
        /// 声明以下变量并输出到控制台：
        /// 1. int 类型变量 age = 25
        /// 2. double 类型变量 price = 19.99
        /// 3. char 类型变量 grade = 'A'
        /// 4. bool 类型变量 isStudent = true
        /// 5. string 类型变量 name = "张三"
        /// 输出格式：name=张三, age=25, price=19.99, grade=A, isStudent=True
        /// </summary>
        public static void Exercise01_DeclareVariables()
        {
            // 变量应该声明在方法内部（局部变量），而不是类内部（字段）
            Console.WriteLine("练习1：声明变量");
            int age = 25;
            double price = 19.99;
            char grade = 'A';
            bool isStudent = true;
            string name = "张三";

            Console.WriteLine($"name={name}, age={age}, price={price}, grade={grade}, isStudent={isStudent}");
            Console.WriteLine("###############################################");
        }

        /// <summary>
        /// 练习2：类型转换
        /// 1. 将 int 变量 num = 100 隐式转换为 long、float、double，并输出
        /// 2. 将 double 变量 dbl = 3.99 显式转换为 int（结果应为3），并输出
        /// 3. 使用 Convert.ToInt32 将字符串 "123" 转换为 int 并加 1，输出结果
        /// </summary>
        public static void Exercise02_TypeConversion()
        {
            Console.WriteLine("练习2：类型转换");
            int num = 100;
            long num1 = num;
            float num2 = num;
            double num3 = num;
            Console.WriteLine($"隐式转换：long={num1}, float={num2}, double={num3}");
            double dbl = 3.99;
            int dbl2 = (int)dbl;
            Console.WriteLine($"显式转换：double={dbl} 转换为 int={dbl2}");
            Console.WriteLine("###############################################");
        }

        /// <summary>
        /// 练习3：可空类型和 var
        /// 1. 声明 int? 可空变量 nullableNum = null，输出它是否有值（HasValue）
        /// 2. 声明 var 变量 message = "Hello C#"，并输出它的类型名称
        /// 3. 使用 ?? 运算符：当 nullableNum 为 null 时输出默认值 0
        /// </summary>
        public static void Exercise03_NullableAndVar()
        {
            int? nullableNum= null;
            Console. WriteLine("练习3：可空类型和 var");
            Console.WriteLine("nullableNum.HasValue={0}", nullableNum.HasValue);
            var message = "Hello C#"; 
            Console.WriteLine("message的类型是：{0}", message.GetType().Name);
            Console.WriteLine("nullableNum ?? 0 = {0}", nullableNum ?? 0);

            Console.WriteLine("###############################################");
        }

        #endregion

        #region 二、运算符

        /// <summary>
        /// 练习4：算术运算符
        /// 定义 int a = 17, b = 5，输出：
        /// a + b = 22, a - b = 12, a * b = 85, a / b = 3, a % b = 2
        /// 注意整数除法会丢弃小数部分
        /// </summary>
        public static void Exercise04_ArithmeticOperators()
        {
            int a = 17, b = 5;
            Console.WriteLine("练习4：算术运算符");
            Console.WriteLine($"a + b = {a + b}, a - b = {a - b}, a * b = {a * b}, a / b = {a / b}, a % b = {a % b}");
            Console.WriteLine("###############################################");

        }

        /// <summary>
        /// 练习5：自增自减和复合赋值
        /// 1. int x = 5; int y = x++; int z = ++x; 输出 x, y, z 的值并解释区别
        /// 2. 使用复合赋值运算符 +=、-=、*=、/= 对变量 num = 10 依次运算
        /// </summary>
        public static void Exercise05_IncrementAndCompound()
        {
            Console.WriteLine("练习5：自增自减和复合赋值");
            int x = 5;
            int y = x++;
            int z = ++x; 
            Console.WriteLine($"x={x}, y={y}, z={z}"); // x=7, y=5, z=7"
            int num = 10;
            num += 5;
            Console.WriteLine($"num += 5 => num={num}");
            Console.WriteLine("###############################################");
        }

        /// <summary>
        /// 练习6：判断闰年（综合运用 %、&&、||）
        /// 输入一个年份，判断是否为闰年并输出：
        /// 闰年规则：能被4整除且不能被100整除，或者能被400整除
        /// 例如：2000年是闰年，1900年不是闰年，2024年是闰年
        /// </summary>
        public static void Exercise06_LeapYear()
        {
            Console.WriteLine("练习6：判断闰年（综合运用 %、&&、||）");
            Console.Write("请输入一个年份：");
            int year = int .Parse(Console.ReadLine());
            if(year % 4  ==0&&year  % 100 != 0 || year % 400 == 0)
            {
                Console.WriteLine($"{year}年是闰年");
            }
            else
            {
                Console.WriteLine($"{year}年不是闰年");
            } 
            //if (int.TryParse(Console.ReadLine(), out int year))
            //{
            //    bool isLeap = (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
            //    Console.WriteLine($"{year}年{(isLeap ? "是" : "不是")}闰年");
            //}
            Console.WriteLine("###############################################");
        }

        /// <summary>
        /// 练习7：三元运算符
        /// 输入一个整数，使用三元运算符输出它是"偶数"还是"奇数"
        /// </summary>
        public static void Exercise07_TernaryOperator(int number)
        {
            int a = int.TryParse(Console.ReadLine(), out int b) ? b : 0;
            Console.WriteLine($"{a}是{(a % 2 == 0 ? "偶数" : "奇数")}");
        }

        #endregion

        #region 三、控制流

        /// <summary>
        /// 练习8：成绩等级（if-else if-else）
        /// 输入分数 score（0-100），输出等级：
        /// 90-100: 优秀  80-89: 良好  70-79: 中等  60-69: 及格  0-59: 不及格
        /// 分数超出范围时输出"分数无效"
        /// </summary>
        public static void Exercise08_ScoreLevel(int score)
        {
            // TODO: 在这里编写代码
        }

        /// <summary>
        /// 练习9：星期转换（switch 语句）
        /// 输入数字 1-7，使用 switch 输出对应的中文星期
        /// 1=星期一 ... 7=星期日，其他数字输出"无效输入"
        /// </summary>
        public static void Exercise09_DayOfWeek()
        {
            if(int.TryParse(Console.ReadLine(), out int day))
            {
                switch (day)
                {
                    case(1):
                        Console.WriteLine("星期一");
                        break;
                    case(2):
                        Console.WriteLine("星期二");
                        break;
                    case(3):
                        Console.WriteLine("星期三");
                        break;
                    case(4):
                        Console.WriteLine("星期四");
                        break;
                    case(5):
                        Console.WriteLine("星期五");
                        break;
                    case(6):
                        Console.WriteLine("星期六");
                        break;
                    case(7):
                        Console.WriteLine("星期日");
                        break;
                    default:
                        Console.WriteLine("无效输入");
                        break;
                }
            }
        }

        /// <summary>
        /// 练习10：for 循环
        /// 1. 用 for 循环计算 1 到 100 的和并输出
        /// 2. 用 for 循环输出 1-9 的九九乘法表
        /// </summary>
        public static void Exercise10_ForLoop()
        {
            int sum = 0;
            for (int i = 1; i <= 100; i++)
            {
                sum += i;
                //Console.WriteLine("1-100和为{0}", sum);
            }
            Console.WriteLine("1-100和为{0}", sum);
        }

        /// <summary>
        /// 练习11：猜数字游戏（while 循环）
        /// 系统生成一个 1-100 的随机数，用户循环输入猜测值：
        /// 猜大了提示"太大了"，猜小了提示"太小了"，猜中提示"恭喜你猜对了！共猜了X次"
        /// 提示：Random random = new Random(); int target = random.Next(1, 101);
        /// 提示：使用 int.Parse(Console.ReadLine()) 读取用户输入
        /// </summary>
        public static void Exercise11_GuessNumber()
        {
            Random random = new Random();
            int target = random.Next(1, 101);
            //int guess;
            int count = 0;
            while (true)
            {
                Console.Write("请输入你猜的数字（1-100）：");
                if(int.TryParse(Console.ReadLine() , out int guess))
                {
                    if(guess < target)
                    {
                        Console.WriteLine("猜小了");
                        count++;
                    }
                    else if(guess > target)
                    {
                        Console.WriteLine("猜大了");
                        count++;
                    }
                    else
                    {
                        count++;
                        Console.WriteLine($"恭喜你猜对了！共猜了{count}次");
                        break;
                    }
                }
            }
        }

        #endregion

        #region 四、方法

        /// <summary>
        /// 练习12：方法定义与调用
        /// 1. 定义方法 Add(int a, int b) 返回两数之和
        /// 2. 定义方法 Max(int a, int b) 返回较大的数
        /// 3. 定义方法 IsEven(int n) 返回 n 是否为偶数
        /// 4. 在 Main 中调用以上方法并输出结果（在方法体内直接测试调用）
        /// </summary>
        public static void Exercise12_MethodDefinition()
        {
            int  Add(int a, int b)
            {
                return a + b;
            }
            int aaa=Add(4, 5);
            void  MAX (int a, int b)
            {
                if (a < b)
                {
                    Console.WriteLine($"Max={b}");
                }
                else
                { 
                    Console.WriteLine($"Max={a}");
                }
            }
            MAX(4, 5);
            Console.WriteLine($"Add(4,5)={aaa}");
        }
        /// <summary>
        /// 练习13：方法重载
        /// 定义重载方法 Print：
        /// 1. Print(int value) 输出 "整数：值"
        /// 2. Print(string value) 输出 "字符串：值"
        /// 3. Print(double value) 输出 "小数：值"
        /// 分别调用三个重载并观察输出
        /// </summary>
        public static void Exercise13_MethodOverload()
        {
            // TODO: 定义并调用重载方法
        }

        /// <summary>
        /// 练习14：ref / out 参数
        /// 1. 定义方法 Swap(ref int a, ref int b) 交换两个变量的值
        /// 2. 定义方法 GetMinMax(int[] nums, out int min, out int max)
        ///    返回数组中的最小值和最大值
        /// </summary>
        public static void Exercise14_RefAndOut()
        {
            int x = 4;
            int y = 5;
            void  Swap (ref int a, ref int b)
            {
                int temp = a;
                a = b;
                b = temp;
            }
            Swap(ref x, ref y);
            Console.WriteLine($"交换后：a = {x}, b = {y}");
        }

        /// <summary>
        /// 练习15：params 参数和递归
        /// 1. 定义方法 Sum(params int[] numbers) 求任意个数的和
        /// 2. 定义方法 Factorial(int n) 用递归求 n 的阶乘
        /// 3. 定义方法 Fibonacci(int n) 用递归求斐波那契数列第 n 项（第1项=1，第2项=1）
        /// </summary>
        public static void Exercise15_ParamsAndRecursion()
        {
            // TODO: 定义并调用方法
        }

        #endregion

        #region 五、数组和字符串

        /// <summary>
        /// 练习16：一维数组
        /// 给定数组 int[] numbers = { 12, 45, 7, 89, 23, 56, 34, 90, 11, 67 };
        /// 1. 用 foreach 输出所有元素
        /// 2. 求出最大值、最小值、平均值并输出
        /// 3. 用 for 循环逆序输出数组
        /// </summary>
        public static void Exercise16_OneDimensionalArray()
        {
            int[] numbers = { 12, 45, 7, 89, 23, 56, 34, 90, 11, 67 };
            // TODO: 在这里编写代码
        }

        /// <summary>
        /// 练习17：二维数组（矩阵转置）
        /// 给定 2x3 矩阵，将其转置为 3x2 矩阵并输出
        /// 原矩阵：{{1, 2, 3}, {4, 5, 6}}
        /// 转置后：{{1, 4}, {2, 5}, {3, 6}}
        /// </summary>
        public static void Exercise17_TwoDimensionalArray()
        {
            int[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 } };
            // TODO: 在这里编写代码
        }

        /// <summary>
        /// 练习18：字符串操作
        /// 给定字符串 string text = "Hello CSharp, learning is fun!";
        /// 1. 统计字符 'l' 出现的次数并输出
        /// 2. 反转字符串并输出
        /// 3. 用空格分割字符串，输出单词数量
        /// 4. 判断字符串是否以 "Hello" 开头、以 "fun!" 结尾
        /// </summary>
        public static void Exercise18_StringOperations()
        {
            string text = "Hello CSharp, learning is fun!";
            // TODO: 在这里编写代码
        }

        /// <summary>
        /// 练习19：回文判断（综合挑战）
        /// 判断一个字符串是否为回文（正读和反读相同，忽略大小写和空格）
        /// 例如："A man a plan a canal Panama" 是回文
        /// 提示：先移除所有空格并转为小写，再比较反转结果
        /// </summary>
        public static void Exercise19_Palindrome(string input)
        {
            // TODO: 在这里编写代码
        }

        #endregion
    }
}
