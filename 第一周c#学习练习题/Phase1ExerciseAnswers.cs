namespace HelloDotNetGuide.CSharp语法
{
    /// <summary>
    /// 第一阶段练习题参考答案
    /// 建议先独立完成 Phase1Exercises.cs，再对照本文件检查。
    /// </summary>
    public class Phase1ExerciseAnswers
    {
        #region 一、变量和数据类型

        public static void Exercise01_DeclareVariables()
        {
            int age = 25;
            double price = 19.99;
            char grade = 'A';
            bool isStudent = true;
            string name = "张三";

            Console.WriteLine($"name={name}, age={age}, price={price}, grade={grade}, isStudent={isStudent}");
        }

        public static void Exercise02_TypeConversion()
        {
            // 1. 隐式转换：int -> long -> float -> double（从小到大自动转换）
            int num = 100;
            long longNum = num;        // int 到 long 隐式转换
            float floatNum = longNum;  // long 到 float 隐式转换
            double doubleNum = floatNum; // float 到 double 隐式转换
            Console.WriteLine($"num={num}, longNum={longNum}, floatNum={floatNum}, doubleNum={doubleNum}");

            // 2. 显式转换（强制转换）：会截断小数部分
            double dbl = 3.99;
            int intNum = (int)dbl;
            Console.WriteLine($"dbl={dbl} 强制转换后 intNum={intNum}");

            // 3. Convert.ToInt32 字符串转整数
            int converted = Convert.ToInt32("123") + 1;
            Console.WriteLine($"Convert.ToInt32(\"123\") + 1 = {converted}");
        }

        public static void Exercise03_NullableAndVar()
        {
            // 1. 可空类型 int?
            int? nullableNum = null;
            Console.WriteLine($"nullableNum.HasValue = {nullableNum.HasValue}");

            // 2. var 关键字：编译器根据初始值推断类型
            var message = "Hello C#";
            Console.WriteLine($"message 的类型是: {message.GetType().Name}");

            // 3. ?? 运算符：左边为 null 时返回右边的默认值
            int result = nullableNum ?? 0;
            Console.WriteLine($"nullableNum ?? 0 = {result}");
        }

        #endregion

        #region 二、运算符

        public static void Exercise04_ArithmeticOperators()
        {
            int a = 17, b = 5;
            Console.WriteLine($"a + b = {a + b}"); // 22
            Console.WriteLine($"a - b = {a - b}"); // 12
            Console.WriteLine($"a * b = {a * b}"); // 85
            Console.WriteLine($"a / b = {a / b}"); // 3（整数除法，丢弃小数）
            Console.WriteLine($"a % b = {a % b}"); // 2（取余数）
        }

        public static void Exercise05_IncrementAndCompound()
        {
            // 1. 自增自减
            int x = 5;
            int y = x++;  // y = 5，x 后置自增变成 6
            int z = ++x;  // x 前置自增变成 7，z = 7
            Console.WriteLine($"x={x}, y={y}, z={z}");
            Console.WriteLine($"解释：y = x++ 先赋值后自增（y=5）；z = ++x 先自增后赋值（x先变7，z=7）");

            // 2. 复合赋值
            int num = 10;
            num += 5;   // num = 15
            num -= 3;   // num = 12
            num *= 2;   // num = 24
            num /= 4;   // num = 6
            Console.WriteLine($"复合赋值后 num = {num}");
        }

        public static void Exercise06_LeapYear(int year)
        {
            bool isLeap = (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
            Console.WriteLine($"{year}年{(isLeap ? "是" : "不是")}闰年");
        }

        public static void Exercise07_TernaryOperator(int number)
        {
            string result = number % 2 == 0 ? "偶数" : "奇数";
            Console.WriteLine($"{number} 是{result}");
        }

        #endregion

        #region 三、控制流

        public static void Exercise08_ScoreLevel(int score)
        {
            if (score < 0 || score > 100)
            {
                Console.WriteLine("分数无效");
            }
            else if (score >= 90)
            {
                Console.WriteLine("优秀");
            }
            else if (score >= 80)
            {
                Console.WriteLine("良好");
            }
            else if (score >= 70)
            {
                Console.WriteLine("中等");
            }
            else if (score >= 60)
            {
                Console.WriteLine("及格");
            }
            else
            {
                Console.WriteLine("不及格");
            }
        }

        public static void Exercise09_DayOfWeek(int day)
        {
            switch (day)
            {
                case 1:
                    Console.WriteLine("星期一");
                    break;
                case 2:
                    Console.WriteLine("星期二");
                    break;
                case 3:
                    Console.WriteLine("星期三");
                    break;
                case 4:
                    Console.WriteLine("星期四");
                    break;
                case 5:
                    Console.WriteLine("星期五");
                    break;
                case 6:
                    Console.WriteLine("星期六");
                    break;
                case 7:
                    Console.WriteLine("星期日");
                    break;
                default:
                    Console.WriteLine("无效输入");
                    break;
            }
        }

        public static void Exercise10_ForLoop()
        {
            // 1. 1-100 求和
            int sum = 0;
            for (int i = 1; i <= 100; i++)
            {
                sum += i;
            }
            Console.WriteLine($"1 到 100 的和 = {sum}");

            // 2. 九九乘法表
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{j}x{i}={i * j}\t");
                }
                Console.WriteLine();
            }
        }

        public static void Exercise11_GuessNumber()
        {
            Random random = new Random();
            int target = random.Next(1, 101);
            int guess = 0;
            int attempts = 0;

            Console.WriteLine("猜数字游戏开始！请输入 1-100 之间的数字：");

            while (guess != target)
            {
                guess = int.Parse(Console.ReadLine() ?? "0");
                attempts++;

                if (guess > target)
                {
                    Console.WriteLine("太大了，再试一次：");
                }
                else if (guess < target)
                {
                    Console.WriteLine("太小了，再试一次：");
                }
            }

            Console.WriteLine($"恭喜你猜对了！答案就是 {target}，共猜了 {attempts} 次");
        }

        #endregion

        #region 四、方法

        public static void Exercise12_MethodDefinition()
        {
            Console.WriteLine($"Add(3, 5) = {Add(3, 5)}");
            Console.WriteLine($"Max(10, 20) = {Max(10, 20)}");
            Console.WriteLine($"IsEven(7) = {IsEven(7)}");
        }

        private static int Add(int a, int b) => a + b;

        private static int Max(int a, int b) => a > b ? a : b;

        private static bool IsEven(int n) => n % 2 == 0;

        public static void Exercise13_MethodOverload()
        {
            Print(42);        // 调用 Print(int)
            Print("Hello");   // 调用 Print(string)
            Print(3.14);      // 调用 Print(double)
        }

        private static void Print(int value) => Console.WriteLine($"整数：{value}");

        private static void Print(string value) => Console.WriteLine($"字符串：{value}");

        private static void Print(double value) => Console.WriteLine($"小数：{value}");

        public static void Exercise14_RefAndOut()
        {
            // 1. ref 交换
            int a = 10, b = 20;
            Console.WriteLine($"交换前：a={a}, b={b}");
            Swap(ref a, ref b);
            Console.WriteLine($"交换后：a={a}, b={b}");

            // 2. out 返回多个值
            int[] nums = { 5, 8, 2, 10, 3 };
            GetMinMax(nums, out int min, out int max);
            Console.WriteLine($"数组 [{string.Join(", ", nums)}] 中：最小值={min}, 最大值={max}");
        }

        private static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        private static void GetMinMax(int[] nums, out int min, out int max)
        {
            min = nums[0];
            max = nums[0];
            foreach (int num in nums)
            {
                if (num < min) min = num;
                if (num > max) max = num;
            }
        }

        public static void Exercise15_ParamsAndRecursion()
        {
            // 1. params 参数
            Console.WriteLine($"Sum(1, 2, 3) = {Sum(1, 2, 3)}");
            Console.WriteLine($"Sum(10, 20, 30, 40, 50) = {Sum(10, 20, 30, 40, 50)}");

            // 2. 递归阶乘
            Console.WriteLine($"Factorial(5) = {Factorial(5)}"); // 5! = 120

            // 3. 递归斐波那契
            Console.WriteLine($"Fibonacci(8) = {Fibonacci(8)}"); // 1,1,2,3,5,8,13,21 -> 第8项=21
        }

        private static int Sum(params int[] numbers)
        {
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
            return sum;
        }

        private static int Factorial(int n)
        {
            if (n <= 1) return 1;          // 递归终止条件
            return n * Factorial(n - 1);   // 递归调用
        }

        private static int Fibonacci(int n)
        {
            if (n <= 2) return 1;                          // 前两项都是 1
            return Fibonacci(n - 1) + Fibonacci(n - 2);    // 前两项之和
        }

        #endregion

        #region 五、数组和字符串

        public static void Exercise16_OneDimensionalArray()
        {
            int[] numbers = { 12, 45, 7, 89, 23, 56, 34, 90, 11, 67 };

            // 1. foreach 输出所有元素
            Console.Write("所有元素：");
            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            // 2. 最大值、最小值、平均值
            int max = numbers[0], min = numbers[0], sum = 0;
            foreach (int num in numbers)
            {
                if (num > max) max = num;
                if (num < min) min = num;
                sum += num;
            }
            Console.WriteLine($"最大值={max}, 最小值={min}, 平均值={sum / (double)numbers.Length:F2}");

            // 3. 逆序输出
            Console.Write("逆序：");
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
        }

        public static void Exercise17_TwoDimensionalArray()
        {
            int[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 } };
            int rows = matrix.GetLength(0);    // 2
            int cols = matrix.GetLength(1);    // 3

            Console.WriteLine("原矩阵：");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            // 转置：行列互换，新矩阵为 3x2
            int[,] transposed = new int[cols, rows];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    transposed[j, i] = matrix[i, j];
                }
            }

            Console.WriteLine("转置后：");
            for (int i = 0; i < cols; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    Console.Write(transposed[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public static void Exercise18_StringOperations()
        {
            string text = "Hello CSharp, learning is fun!";

            // 1. 统计字符 'l' 出现的次数
            int count = 0;
            foreach (char c in text)
            {
                if (c == 'l') count++;
            }
            Console.WriteLine($"字符 'l' 出现次数：{count}");

            // 2. 反转字符串
            char[] charArray = text.ToCharArray();
            Array.Reverse(charArray);
            string reversed = new string(charArray);
            Console.WriteLine($"反转后：{reversed}");

            // 3. 按空格分割，统计单词数量
            string[] words = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine($"单词数量：{words.Length}");

            // 4. 判断开头和结尾
            Console.WriteLine($"以 \"Hello\" 开头：{text.StartsWith("Hello")}");
            Console.WriteLine($"以 \"fun!\" 结尾：{text.EndsWith("fun!")}");
        }

        public static void Exercise19_Palindrome(string input)
        {
            // 移除所有空格并转小写
            string cleaned = input.Replace(" ", "").ToLower();

            // 反转字符串
            char[] charArray = cleaned.ToCharArray();
            Array.Reverse(charArray);
            string reversed = new string(charArray);

            bool isPalindrome = cleaned == reversed;
            Console.WriteLine($"\"{input}\" {(isPalindrome ? "是" : "不是")}回文");
        }

        #endregion
    }
}
