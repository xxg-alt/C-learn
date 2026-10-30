namespace HelloDotNetGuide.CSharp语法
{
    /// <summary>
    /// 第三阶段练习题：集合（List / Dictionary）、泛型初步、异常处理
    /// 完成下面的每个方法，实现注释中描述的功能。
    /// 做完后对照 Phase3ExerciseAnswers.cs 检查答案。
    /// 衔接说明：本周会用到第一周的数组/字符串/循环，以及第二周的类、属性、
    /// 方法设计——所有新类都定义在 Phase3Exercises 类【内部】，不要写在
    /// namespace 级（否则会和答案文件的同名类冲突，报 CS0101）。
    /// </summary>
    public class Phase3Exercises
    {
        #region 一、List<T> 基础

        /// <summary>
        /// 练习1：创建 List 并遍历
        /// 1. 创建 List<int>，用集合初始化器存入 10, 20, 30, 40, 50
        /// 2. 用 foreach 遍历输出所有元素
        /// 3. 用 Add 追加 60，输出 Count 属性
        /// 回顾：List 是"会自动变长的数组"，第一周数组的 Length 换成了 Count
        /// </summary>
        public static void Exercise01_ListBasics()
        {
            List<int> nums = new List<int> { 10, 20, 30, 40, 50 };
            foreach (var arr in nums)
            {
                Console.WriteLine($"{arr}");
            }
            nums.Add(60);
            Console.WriteLine($"{nums.Count}");
        }

        /// <summary>
        /// 练习2：插入与删除
        /// 给定 List<string> fruits = { "苹果", "香蕉", "橘子" }
        /// 1. 在索引 1 处插入 "葡萄"，输出列表
        /// 2. 用 Remove 删除 "香蕉"，再用 RemoveAt(0) 删除第一个元素，输出列表
        /// 3. 体会：数组和 List 在"增删"上的最大区别是什么？（写一行注释）
        /// </summary>
        public static void Exercise02_InsertAndRemove()
        {
            List<string> fruits = new List<string> { "苹果", "香蕉", "橘子" };
            fruits.Insert(1, "葡萄");
            foreach (var arr in fruits)
            {
                Console.WriteLine($"{arr}");
            }
            fruits.Remove("香蕉");
            fruits.RemoveAt(0);
            Console.WriteLine("删除后元素");
            foreach (var arr in fruits)
            {
                Console.WriteLine($"{arr}");
            }
        }

        /// <summary>
        /// 练习3：查找
        /// 给定 List<int> nums = { 5, 12, 8, 21, 12, 3 }
        /// 1. 用 Contains 判断是否包含 8，输出结果
        /// 2. 用 IndexOf 找 12 第一次出现的索引（注意有两个 12）
        /// 3. 用 Find 找出第一个大于 10 的数
        /// 4. 用 FindAll 找出所有偶数并输出
        /// 提示：Find/FindAll 的参数是 Lambda 表达式，如 x => x > 10
        /// </summary>
        public static void Exercise03_Search()
        {
            // TODO: 在这里编写代码
        }

        /// <summary>
        /// 练习4：排序与统计
        /// 给定 List<double> scores = { 88.5, 92.0, 76.5, 100, 63.0 }
        /// 1. 用 Sort() 升序排序后输出
        /// 2. 用 Reverse() 反转后输出
        /// 3. 用循环（不用内置 Sum/Average）求总和与平均值，输出保留 1 位小数
        /// 回顾：第一周练习16用数组做过一模一样的事，对比一下代码量
        /// </summary>
        public static void Exercise04_SortAndStats()
        {
            // TODO: 在这里编写代码
        }

        #endregion

        #region 二、Dictionary<TKey, TValue>

        /// <summary>
        /// 练习5：字典基础
        /// 1. 创建 Dictionary<string, int> ages，添加三个键值对：
        ///    "张三"=18, "李四"=22, "王五"=20
        /// 2. 用方括号 ages["李四"] 取值并输出
        /// 3. 输出 Count
        /// </summary>
        public static void Exercise05_DictBasics()
        {
            // TODO: 在这里编写代码
        }

        /// <summary>
        /// 练习6：安全访问（重点）
        /// 1. 对练习5的 ages，直接取 ages["赵六"]（观察抛出什么异常）
        /// 2. 改用 ContainsKey 判断后再取值，键不存在时输出"查无此人"
        /// 3. 再用 TryGetValue 实现同样的判断（推荐写法）
        /// </summary>
        public static void Exercise06_SafeAccess()
        {
            // TODO: 在这里编写代码
        }

        /// <summary>
        /// 练习7：遍历键值对
        /// 1. 用 foreach 遍历练习5的 ages，输出 "姓名=年龄" 格式
        ///    提示：foreach (var kv in ages)，kv.Key 和 kv.Value
        /// 2. 再用 Keys 属性单独遍历所有键
        /// 3. 修改"王五"的年龄为 21（直接对 key 赋值即可），再次遍历验证
        /// </summary>
        public static void Exercise07_Traverse()
        {
            // TODO: 在这里编写代码
        }

        /// <summary>
        /// 练习8：词频统计（经典应用）
        /// 给定字符串 sentence = "the quick brown fox jumps over the lazy dog the fox"
        /// 1. 用 Split(' ') 拆成单词数组（回顾第一周练习18）
        /// 2. 用 Dictionary<string, int> 统计每个单词出现的次数
        ///    （不存在就 Add 成 1，存在就 +1）
        /// 3. 遍历输出 "单词: 次数"
        /// </summary>
        public static void Exercise08_WordCount()
        {
            // TODO: 在这里编写代码
        }

        #endregion

        #region 三、集合进阶与泛型

        /// <summary>
        /// 练习9：List 存对象（衔接第二周）
        /// 1. 在 Phase3Exercises 类【内部】定义 Student3 类：
        ///    属性 Name、Age，方法 Introduce()
        /// 2. 创建 List<Student3> 存入 3 个学生
        /// 3. foreach 遍历调用 Introduce()
        /// 4. 删除第 2 个学生（RemoveAt），再遍历验证
        /// </summary>
        public static void Exercise09_ListOfObjects()
        {
            // TODO: 在这里编写代码
        }

        /// <summary>
        /// 练习10：对象排序
        /// 1. 用练习9的 Student3，按 Age 升序排列列表并输出
        /// 提示：list.Sort((a, b) => a.Age - b.Age)——这是 Comparison 委托
        /// 2. 改成按 Name 排序，提示：用 string.Compare(a.Name, b.Name)
        /// </summary>
        public static void Exercise10_SortObjects()
        {
            // TODO: 在这里编写代码
        }

        /// <summary>
        /// 练习11：Stack 与 Queue
        /// 1. Stack<int>（后进先出）：Push 1,2,3 后连续 Pop 三次，观察顺序
        /// 2. Queue<int>（先进先出）：Enqueue 1,2,3 后连续 Dequeue 三次，观察顺序
        /// 3. 用一行注释总结两者的区别和使用场景
        /// </summary>
        public static void Exercise11_StackQueue()
        {
            // TODO: 在这里编写代码
        }

        /// <summary>
        /// 练习12：泛型方法（泛型初步）
        /// 1. 在 Phase3Exercises 类内部定义泛型方法
        ///    private static T Max<T>(T a, T b) where T : IComparable<T>
        ///    返回较大的那个（用 a.CompareTo(b) 判断）
        /// 2. 分别用 int、double、string 三种类型调用它，验证都能用
        /// 思考：为什么不用重载写三份几乎一样的代码？
        /// </summary>
        public static void Exercise12_GenericMethod()
        {
            // TODO: 在这里编写代码
        }

        #endregion

        #region 四、异常处理

        /// <summary>
        /// 练习13：try-catch 基础
        /// 1. 用 int.Parse("abc") 把非数字字符串转整数，放进 try 中
        /// 2. catch (FormatException) 捕获并输出"格式错误"
        /// 3. 再捕获 DivideByZeroException：int x = 10; x /= 0;
        /// 回顾：第一周我们用 int.TryParse 避免"红字"，try-catch 是更通用的兜底方式
        /// </summary>
        public static void Exercise13_TryCatch()
        {
            // TODO: 在这里编写代码
        }

        /// <summary>
        /// 练习14：多个 catch 分支
        /// 写一个方法 SafeDivide(int a, int b)，在 try 中返回 a / b：
        /// 1. b 为 0 时被 DivideByZeroException 捕获，输出"除数不能为0"并返回 0
        /// 2. 最后加一个 catch (Exception ex) 兜底，输出 ex.Message
        /// 3. 测试 SafeDivide(10, 2) 和 SafeDivide(10, 0)
        /// 思考：为什么具体异常要写在兜底 Exception 前面？
        /// </summary>
        public static void Exercise14_MultipleCatch()
        {
            // TODO: 在这里编写代码
        }

        /// <summary>
        /// 练习15：finally 块
        /// 1. 在 try 中输出"开始处理"并故意抛出异常
        /// 2. 在 catch 中输出"捕获到异常"
        /// 3. 在 finally 中输出"清理资源（无论如何都会执行）"
        /// 4. 观察输出顺序，用注释说明 finally 的用途
        /// </summary>
        public static void Exercise15_Finally()
        {
            // TODO: 在这里编写代码
        }

        /// <summary>
        /// 练习16：throw 与自定义异常（衔接第二周练习7）
        /// 1. 定义自定义异常类 AgeOutOfRangeException : Exception
        ///    （同样定义在 Phase3Exercises 类【内部】）
        /// 2. 在 Person3 类的 Age 属性 set 中：不在 0-150 范围时
        ///    throw new AgeOutOfRangeException("年龄必须在0到150之间")
        ///    （对比第二周练习7：那时只是打印提示，现在是主动抛异常）
        /// 3. 用 try-catch 包住赋值 p.Age = -5，捕获后输出异常消息
        /// </summary>
        public static void Exercise16_CustomException()
        {
            // TODO: 在这里编写代码
        }

        #endregion

        #region 五、综合挑战

        /// <summary>
        /// 练习17：通讯录（综合挑战）
        /// 用 Dictionary<string, string> 做一个循环菜单通讯录：
        /// 1. 菜单：1=添加联系人 2=按姓名查电话 3=删除联系人 4=显示全部 0=退出
        /// 2. 添加时若姓名已存在，提示并拒绝覆盖
        /// 3. 查询/删除不存在的联系人时，给出友好提示
        /// 4. 用 while + switch 实现（回顾第一周练习9、练习11）
        /// 提示：Console.ReadLine() 读菜单选项和姓名
        /// </summary>
        public static void Exercise17_Contacts()
        {
            // TODO: 在这里编写代码
        }

        /// <summary>
        /// 练习18：异常安全的数字收集器
        /// 1. 循环读取用户输入，转换为 int 存入 List<int>
        /// 2. 输入非法内容时用 try-catch 提示"请输入有效整数"并继续（不退出）
        /// 3. 输入 "q" 时结束，输出收集到的所有数字、总数和平均值
        /// 4. 一个数字都没收集时输出"未收集到任何数字"（避免除零）
        /// </summary>
        public static void Exercise18_SafeCollector()
        {
            // TODO: 在这里编写代码
        }

        /// <summary>
        /// 练习19：成绩管理系统 V3（终极挑战，三周知识总集成）
        /// 1. 定义 StudentV3 类（Phase3Exercises 内部）：Name、Chinese、Math、English
        /// 2. 定义方法 GetAverage() 返回平均分
        /// 3. 创建 List<StudentV3> 存入至少 4 名学生（分数有高有低）
        /// 4. 用 Dictionary<string, StudentV3> 按"等级"（优秀/良好/中等/及格/不及格）
        ///    分组——注意同名 key 会冲突，key 改用 姓名 或直接改用
        ///    Dictionary<string, List<StudentV3>> 按【等级】分组存 List
        /// 5. 输出每个等级组的人数和组内学生姓名
        /// 6. 用 try-catch 包住一段会产生异常的代码（如访问不存在的学生），
        ///    保证程序不崩溃
        /// 考点：类与属性（第2周）+ List/Dictionary（本周）+ 异常处理（本周）+ 循环（第1周）
        /// </summary>
        public static void Exercise19_GradeSystemV3()
        {
            // TODO: 在这里编写代码
        }

        #endregion
    }
}
