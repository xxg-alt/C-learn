namespace HelloDotNetGuide.CSharp语法
{
    /// <summary>
    /// 第三阶段练习题参考答案
    /// 建议先独立完成 Phase3Exercises.cs，再对照本文件检查。
    /// 注释中带【解析】标记的是本题的核心考点。
    /// 所有辅助类同样嵌套在 Phase3ExerciseAnswers 类内部（与练习文件约定一致）。
    /// </summary>
    public class Phase3ExerciseAnswers
    {
        #region 一、List<T> 基础

        public static void Exercise01_ListBasics()
        {
            List<int> numbers = new List<int> { 10, 20, 30, 40, 50 };

            foreach (int n in numbers)
            {
                Console.WriteLine(n);
            }

            numbers.Add(60);
            Console.WriteLine($"添加后 Count = {numbers.Count}"); // 6
            // 【解析】List 内部其实维护着一个数组，满了就自动扩容搬新家，
            // 所以不用像数组那样预先定死长度。
        }

        public static void Exercise02_InsertAndRemove()
        {
            List<string> fruits = new List<string> { "苹果", "香蕉", "橘子" };

            fruits.Insert(1, "葡萄");
            Console.WriteLine(string.Join(", ", fruits)); // 苹果, 葡萄, 香蕉, 橘子

            fruits.Remove("香蕉");
            fruits.RemoveAt(0);
            Console.WriteLine(string.Join(", ", fruits)); // 葡萄, 橘子

            // 数组长度固定、增删要手动搬元素；List 增删后自动调整，只需记 Count。
            // 【解析】Remove 按内容删第一个匹配项，RemoveAt 按索引删；
            // Remove 返回 bool 表示是否删到，RemoveAt 索引越界会抛异常。
        }

        public static void Exercise03_Search()
        {
            List<int> nums = new List<int> { 5, 12, 8, 21, 12, 3 };

            Console.WriteLine($"包含 8 吗？{nums.Contains(8)}");           // True
            Console.WriteLine($"12 第一次出现的索引：{nums.IndexOf(12)}"); // 1
            Console.WriteLine($"第一个大于10的数：{nums.Find(x => x > 10)}"); // 12

            List<int> evens = nums.FindAll(x => x % 2 == 0);
            Console.WriteLine($"所有偶数：{string.Join(", ", evens)}");    // 12, 8, 12
            // 【解析】x => x > 10 是 Lambda 表达式，意思是"给我一个 x，
            // 返回 x > 10 这个判断结果"。Find 返回第一个满足的，FindAll 返回全部。
        }

        public static void Exercise04_SortAndStats()
        {
            List<double> scores = new List<double> { 88.5, 92.0, 76.5, 100, 63.0 };

            scores.Sort();
            Console.WriteLine($"升序：{string.Join(", ", scores)}");

            scores.Reverse();
            Console.WriteLine($"反转：{string.Join(", ", scores)}");

            double sum = 0;
            foreach (double s in scores)
            {
                sum += s;
            }
            Console.WriteLine($"总和：{sum}，平均：{sum / scores.Count:F1}");
            // 【解析】Sort 是原地排序（改自己，不返回新列表）；Reverse 同理。
            // 手写求和的循环在任何集合上都通用——内置的 Sum()/Average() 是
            // LINQ 提供的，以后学了 LINQ 可以一行搞定。
        }

        #endregion

        #region 二、Dictionary<TKey, TValue>

        public static void Exercise05_DictBasics()
        {
            Dictionary<string, int> ages = new Dictionary<string, int>
            {
                { "张三", 18 },
                { "李四", 22 },
                { "王五", 20 }
            };

            Console.WriteLine($"李四的年龄：{ages["李四"]}");
            Console.WriteLine($"Count = {ages.Count}");
            // 【解析】Dictionary 是"键 -> 值"的映射，按键查值接近 O(1)，
            // 比在 List 里逐个找快得多。键必须唯一，值可以重复。
        }

        public static void Exercise06_SafeAccess()
        {
            Dictionary<string, int> ages = new Dictionary<string, int>
            {
                { "张三", 18 }, { "李四", 22 }, { "王五", 20 }
            };

            // Console.WriteLine(ages["赵六"]); // 抛 KeyNotFoundException

            // 写法1：ContainsKey 判断
            if (ages.ContainsKey("赵六"))
            {
                Console.WriteLine(ages["赵六"]);
            }
            else
            {
                Console.WriteLine("查无此人");
            }

            // 写法2（推荐）：TryGetValue，一次查找同时完成"判断+取值"
            if (ages.TryGetValue("赵六", out int age))
            {
                Console.WriteLine($"赵六 {age} 岁");
            }
            else
            {
                Console.WriteLine("查无此人");
            }
            // 【解析】方括号取不存在的键会抛异常；TryGetValue 找到时返回 true
            // 并通过 out 参数带回值（回顾第二周 out 的用法），找不到只返回 false。
        }

        public static void Exercise07_Traverse()
        {
            Dictionary<string, int> ages = new Dictionary<string, int>
            {
                { "张三", 18 }, { "李四", 22 }, { "王五", 20 }
            };

            // 1. 遍历键值对
            foreach (var kv in ages)
            {
                Console.WriteLine($"{kv.Key}={kv.Value}");
            }

            // 2. 只遍历键
            foreach (string name in ages.Keys)
            {
                Console.WriteLine($"姓名：{name}");
            }

            // 3. 修改值：直接对已有 key 赋值
            ages["王五"] = 21;
            foreach (var kv in ages)
            {
                Console.WriteLine($"{kv.Key}={kv.Value}");
            }
            // 【解析】对不存在的 key 赋值 = 新增；对存在的 key 赋值 = 修改。
            // 这也是"添加或更新"最简洁的写法。
        }

        public static void Exercise08_WordCount()
        {
            string sentence = "the quick brown fox jumps over the lazy dog the fox";
            string[] words = sentence.Split(' ');

            Dictionary<string, int> counts = new Dictionary<string, int>();
            foreach (string word in words)
            {
                if (counts.ContainsKey(word))
                {
                    counts[word]++;
                }
                else
                {
                    counts[word] = 1;
                }
            }

            foreach (var kv in counts)
            {
                Console.WriteLine($"{kv.Key}: {kv.Value}");
            }
            // 【解析】词频统计是 Dictionary 最经典的入门应用：
            // "第一次见到就记一笔，再见到就加一"。
            // 这个模式（存在则更新、不存在则初始化）以后会反复遇到。
        }

        #endregion

        #region 三、集合进阶与泛型

        public static void Exercise09_ListOfObjects()
        {
            List<Student3> students = new List<Student3>
            {
                new Student3("张三", 18),
                new Student3("李四", 22),
                new Student3("王五", 20)
            };

            foreach (Student3 s in students)
            {
                s.Introduce();
            }

            students.RemoveAt(1);
            Console.WriteLine("删除第二个学生后：");
            foreach (Student3 s in students)
            {
                s.Introduce();
            }
            // 【解析】泛型 List<Student3> 尖括号里不只能放 int/string，
            // 任何类型都可以——这正是"泛型"的含义：类型是参数。
        }

        public static void Exercise10_SortObjects()
        {
            List<Student3> students = new List<Student3>
            {
                new Student3("张三", 18),
                new Student3("李四", 22),
                new Student3("王五", 20)
            };

            // 按年龄升序
            students.Sort((a, b) => a.Age - b.Age);
            foreach (Student3 s in students)
            {
                Console.WriteLine($"{s.Name} {s.Age}");
            }

            // 按姓名排序
            students.Sort((a, b) => string.Compare(a.Name, b.Name));
            foreach (Student3 s in students)
            {
                Console.WriteLine($"{s.Name} {s.Age}");
            }
            // 【解析】List.Sort 自带的是按"自然顺序"排，对象没有自然顺序，
            // 所以要传一个比较器告诉它怎么比。a.Age - b.Age：负数表示 a 在前，
            // 正数表示 b 在前——想降序就把 a、b 换个位置（b.Age - a.Age）。
        }

        public static void Exercise11_StackQueue()
        {
            // Stack：后进先出（像叠盘子）
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            while (stack.Count > 0)
            {
                Console.Write(stack.Pop() + " "); // 3 2 1
            }
            Console.WriteLine();

            // Queue：先进先出（像排队）
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            while (queue.Count > 0)
            {
                Console.Write(queue.Dequeue() + " "); // 1 2 3
            }
            Console.WriteLine();

            // Stack 后进先出适合"撤销/返回"场景；Queue 先进先出适合"排队/任务队列"。
        }

        public static void Exercise12_GenericMethod()
        {
            Console.WriteLine($"Max(3, 7) = {Max(3, 7)}");
            Console.WriteLine($"Max(2.5, 1.8) = {Max(2.5, 1.8)}");
            Console.WriteLine($"Max(\"apple\", \"banana\") = {Max("apple", "banana")}");
            // 【解析】where T : IComparable<T> 约束了"T 必须能比较自己"，
            // 所以方法内部才能调 a.CompareTo(b)。一份代码服务所有可比较类型，
            // 这就是泛型的核心价值：类型安全 + 复用，不需要 object 装箱拆箱。
        }

        private static T Max<T>(T a, T b) where T : IComparable<T>
        {
            return a.CompareTo(b) >= 0 ? a : b;
        }

        #endregion

        #region 四、异常处理

        public static void Exercise13_TryCatch()
        {
            try
            {
                int n = int.Parse("abc"); // 这里会抛 FormatException
            }
            catch (FormatException)
            {
                Console.WriteLine("格式错误：字符串不是有效的整数");
            }

            try
            {
                int x = 10;
                x /= 0; // 整数除零抛 DivideByZeroException
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("除数不能为0");
            }
            // 【解析】int.Parse 失败抛异常而不是返回特殊值；
            // 注意浮点数除以 0 不抛异常（结果是无穷），只有整数除零才抛。
        }

        public static void Exercise14_MultipleCatch()
        {
            Console.WriteLine($"SafeDivide(10, 2) = {SafeDivide(10, 2)}");
            Console.WriteLine($"SafeDivide(10, 0) = {SafeDivide(10, 0)}");
        }

        private static int SafeDivide(int a, int b)
        {
            try
            {
                return a / b;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("除数不能为0");
                return 0;
            }
            catch (Exception ex)
            {
                // 兜底：处理没预料到的其他异常
                Console.WriteLine($"发生异常：{ex.Message}");
                return 0;
            }
            // 【解析】catch 按书写顺序匹配，Exception 是所有异常的基类，
            // 如果放前面会把后面的具体 catch 全部"截胡"，所以必须放最后。
        }

        public static void Exercise15_Finally()
        {
            try
            {
                Console.WriteLine("开始处理");
                throw new InvalidOperationException("故意抛出的异常");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"捕获到异常：{ex.Message}");
            }
            finally
            {
                Console.WriteLine("清理资源（无论如何都会执行）");
            }
            // 输出顺序：开始处理 -> 捕获到异常 -> 清理资源
            // 【解析】finally 无论 try 正常结束还是抛异常都会执行，
            // 适合放"必须做的收尾工作"：关文件、关数据库连接、解锁等。
        }

        public static void Exercise16_CustomException()
        {
            Person3 p = new Person3();
            try
            {
                p.Age = -5;
            }
            catch (AgeOutOfRangeException ex)
            {
                Console.WriteLine($"赋值失败：{ex.Message}");
            }

            p.Age = 25;
            Console.WriteLine($"重新赋值成功：{p.Age}");
            // 【解析】第二周练习7的选择是"打印提示并忽略"，这次升级为
            // "抛异常让调用方决定怎么办"——把错误的处理权交给调用者，
            // 类自己只负责守住规则，这是更符合工程实践的封装方式。
        }

        /// <summary>自定义异常：继承 Exception，添加有意义类名 + 携带消息</summary>
        public class AgeOutOfRangeException : Exception
        {
            public AgeOutOfRangeException(string message) : base(message) { }
        }

        public class Person3
        {
            private int age;

            public int Age
            {
                get { return age; }
                set
                {
                    if (value < 0 || value > 150)
                    {
                        throw new AgeOutOfRangeException("年龄必须在0到150之间");
                    }
                    age = value;
                }
            }
        }

        #endregion

        #region 五、综合挑战

        public static void Exercise17_Contacts()
        {
            Dictionary<string, string> contacts = new Dictionary<string, string>();

            while (true)
            {
                Console.WriteLine("\n===== 通讯录 =====");
                Console.WriteLine("1=添加 2=查询 3=删除 4=显示全部 0=退出");
                Console.Write("请选择：");
                string choice = Console.ReadLine() ?? "";

                if (choice == "0")
                {
                    break;
                }

                switch (choice)
                {
                    case "1":
                        Console.Write("姓名：");
                        string addName = Console.ReadLine() ?? "";
                        if (contacts.ContainsKey(addName))
                        {
                            Console.WriteLine("该联系人已存在，添加失败");
                        }
                        else
                        {
                            Console.Write("电话：");
                            contacts[addName] = Console.ReadLine() ?? "";
                            Console.WriteLine($"已添加 {addName}");
                        }
                        break;

                    case "2":
                        Console.Write("要查谁：");
                        string findName = Console.ReadLine() ?? "";
                        if (contacts.TryGetValue(findName, out string? phone))
                        {
                            Console.WriteLine($"{findName} 的电话：{phone}");
                        }
                        else
                        {
                            Console.WriteLine("查无此人");
                        }
                        break;

                    case "3":
                        Console.Write("要删谁：");
                        string delName = Console.ReadLine() ?? "";
                        if (contacts.Remove(delName))
                        {
                            Console.WriteLine($"已删除 {delName}");
                        }
                        else
                        {
                            Console.WriteLine("查无此人");
                        }
                        break;

                    case "4":
                        if (contacts.Count == 0)
                        {
                            Console.WriteLine("通讯录是空的");
                        }
                        foreach (var kv in contacts)
                        {
                            Console.WriteLine($"{kv.Key}：{kv.Value}");
                        }
                        break;

                    default:
                        Console.WriteLine("无效选项");
                        break;
                }
            }
            // 【解析】Dictionary.Remove 返回 bool，比 TryGetValue+Remove 更简洁。
            // Console.ReadLine() 可能为 null（Nullable 开启下编译器会警告），
            // 用 ?? "" 兜底是习惯性的防御写法。
        }

        public static void Exercise18_SafeCollector()
        {
            List<int> numbers = new List<int>();

            while (true)
            {
                Console.Write("请输入整数（q 结束）：");
                string input = Console.ReadLine() ?? "";

                if (input == "q")
                {
                    break;
                }

                try
                {
                    numbers.Add(int.Parse(input));
                    Console.WriteLine($"已收集 {numbers.Count} 个数字");
                }
                catch (FormatException)
                {
                    Console.WriteLine("请输入有效整数");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("数字太大了，超出 int 范围");
                }
            }

            if (numbers.Count == 0)
            {
                Console.WriteLine("未收集到任何数字");
            }
            else
            {
                int sum = 0;
                foreach (int n in numbers)
                {
                    sum += n;
                }
                Console.WriteLine($"共 {numbers.Count} 个：{string.Join(", ", numbers)}");
                Console.WriteLine($"平均值：{(double)sum / numbers.Count:F1}");
            }
            // 【解析】"先判断退出条件，再 try-catch 转换"的循环骨架
            // 在任何需要用户输入的程序里都通用。
            // 注意除零防护：Count 为 0 时直接短路输出，不做除法。
        }

        public static void Exercise19_GradeSystemV3()
        {
            List<StudentV3> students = new List<StudentV3>
            {
                new StudentV3("张三", 90, 85, 88),
                new StudentV3("李四", 70, 65, 72),
                new StudentV3("王五", 95, 92, 96),
                new StudentV3("赵六", 55, 60, 48)
            };

            // 按等级分组：等级 -> 学生列表
            Dictionary<string, List<StudentV3>> groups = new Dictionary<string, List<StudentV3>>();

            foreach (StudentV3 s in students)
            {
                string level = s.GetLevel();
                if (!groups.ContainsKey(level))
                {
                    groups[level] = new List<StudentV3>();
                }
                groups[level].Add(s);
            }

            foreach (var kv in groups)
            {
                string names = string.Join("、", kv.Value.ConvertAll(s => s.Name));
                Console.WriteLine($"{kv.Key}（{kv.Value.Count}人）：{names}");
            }

            // 访问不存在的学生：用异常兜底而不是崩溃
            try
            {
                StudentV3 ghost = students[100]; // 索引越界
                ghost.Introduce();
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("没有这个学生（索引越界已被安全处理）");
            }
            // 【解析】分组统计是 Dictionary<string, List<T>> 的招牌用法：
            // "组不存在就先建空组，再把元素放进去"。
            // 它在真实项目里无处不在（按日期分组订单、按部门分组员工……）。
            // 严格来说按索引取值更适合先判断 Count，这里故意演示
            // "异常作为最后防线"的用法。
        }

        public class StudentV3
        {
            public string Name { get; set; }
            public double Chinese { get; set; }
            public double Math { get; set; }
            public double English { get; set; }

            public StudentV3(string name, double chinese, double math, double english)
            {
                Name = name;
                Chinese = chinese;
                Math = math;
                English = english;
            }

            public double GetAverage() => (Chinese + Math + English) / 3;

            public void Introduce() => Console.WriteLine($"我是{Name}，平均分{GetAverage():F1}");

            // 复用第二周的分数段规则
            public string GetLevel()
            {
                double avg = GetAverage();
                if (avg >= 90) return "优秀";
                else if (avg >= 80) return "良好";
                else if (avg >= 70) return "中等";
                else if (avg >= 60) return "及格";
                else return "不及格";
            }
        }

        #endregion

        /// <summary>
        /// 练习9、10 使用的学生类
        /// </summary>
        public class Student3
        {
            public string Name { get; set; }
            public int Age { get; set; }

            public Student3(string name, int age)
            {
                Name = name;
                Age = age;
            }

            public void Introduce() => Console.WriteLine($"大家好，我是{Name}，今年{Age}岁");
        }
    }
}
