using System;

namespace HelloDotNetGuide.CSharp语法
{
    /// <summary>
    /// 第二阶段练习题：面向对象基础（类、封装、继承、多态）
    /// 完成下面的每个方法，实现注释中描述的功能。
    /// 做完后对照 Phase2ExerciseAnswers.cs 检查答案。
    /// 注意：练习中要求新定义的类（Rectangle、Book 等），请模仿 Student 的方式
    /// 定义在 Phase2Exercises 类的内部，不要放到 namespace 下——
    /// 否则会与答案文件里的同名类冲突，产生编译错误。
    /// 衔接说明：本周题目会用到第一周的变量、方法、数组和字符串知识，
    /// 建议先确保第一阶段练习已全部完成。
    /// </summary>
    public class Phase2Exercises
    {
        #region 一、类和对象

        /// <summary>
        /// 练习1：定义第一个类
        /// 1. 定义一个 Student 类，包含字段：Name（string）、Age（int）
        /// 2. 定义方法 Introduce()，输出 "大家好，我是XXX，今年XX岁"
        /// 3. 在本方法中创建 Student 对象，给字段赋值，并调用 Introduce()
        /// 提示：本题的 Student 类已作为示例给出，后续练习的新类请照它的样子定义在 Phase2Exercises 类内部
        /// </summary>
        public class Student
        {
            public string Name;
            public int Age;
            static int Count;
            // 无参构造函数：不传参数时，字段取默认值
            public Student()
            {
                Name = "未命名";
                Age = 0;
                Count++;
            }

            // 带参构造函数：new 的同时完成初始化
            public Student(string name, int age)
            {
                Name = name;
                Age = age;
                Count++;
            }
            public Student(string name)
            {
                Name = name;
                Count++;
            }

            public void Introduce()
            {
                Console.WriteLine($"大家好，我是{Name}，今年{Age}岁");
            }
            public void ShowCount()
            {
                Console.WriteLine("{0}", Count);
            }
        }
        public static void Exercise01_DefineClass()
        {
            Student student = new Student();
            student.Name = "张三";
            student.Age = 20;
            student.Introduce();
        }

        /// <summary>
        /// 练习2：构造函数
        /// 上面的 Student 类已经定义了两个构造函数（无参 + 带参）。
        /// 1. 分别用两种构造函数各创建一个对象，并调用 Introduce()
        /// 2. 亲手给 Student 类添加第三个构造函数 Student(string name)：
        ///    只传姓名、年龄默认为 0——同名不同参，这叫"构造函数重载"
        /// 3. 用第三个构造函数创建对象，验证结果
        /// 思考：和练习1"先 new 再逐个赋值"相比，用构造函数初始化的好处是什么？
        /// </summary>
        
        public static void Exercise02_Constructor()
        {
            Student student1 = new Student();
            student1.Introduce();
            Student student2 = new Student("李四", 22);
            student2.Introduce();
            Student student3 = new Student("ljj");
            student3.Introduce();
        }
        /// <summary>
        /// 练习3：this 关键字
        /// 1. 定义 Rectangle 类，字段为 width 和 height
        /// 2. 构造函数的参数名也叫 width、height，使用 this 区分字段和参数
        /// 3. 定义方法 GetArea() 返回面积、GetPerimeter() 返回周长
        /// 4. 创建 3x4 的矩形，输出面积和周长
        /// </summary>
        public class Rectangle 
        {
            double width;
            double height;
            public Rectangle(double width,double height)
            {
                this.width = width;
                this.height = height;
            }
            public double GetArea()
            {
                return width * height;
            }
            public double GetPerimeter()
            {
                return 2 * (width + height);
            }
        }
        public static void Exercise03_ThisKeyword()
        {
            Rectangle r1 = new Rectangle(3, 4);
            double area=r1.GetArea();
            double perimeter=r1.GetPerimeter();
            Console.WriteLine("面积为{0}，周长为{1}", area, perimeter);
        }

        /// <summary>
        /// 练习4：静态成员
        /// 1. 为 Student 类添加静态字段 Count，记录创建过的学生总数
        /// 2. 在构造函数中让 Count 自增（提示：每个构造函数里都要写一次）
        /// 3. 添加静态方法 ShowCount() 输出当前学生总数
        /// 4. 创建 3 个学生对象后调用 ShowCount()
        /// 思考：为什么 Count 要用 static？如果不用会怎样？
        /// </summary>
        public static void Exercise04_StaticMember()
        {
            Student C1 = new Student("ljj", 5);
            Student C2 = new Student();
            Student C3 = new Student("ljj");
            C1.ShowCount();
        }

        #endregion

        #region 二、属性与封装

        /// <summary>
        /// 练习5：自动属性
        /// 1. 定义 Book 类，使用自动属性：Title（string）、Price（double）
        /// 2. 创建对象并用对象初始化器赋值：new Book { Title="C#入门", Price=59.9 }
        /// 3. 输出书名和价格
        /// </summary>
        public static void Exercise05_AutoProperty()
        {
            // TODO: 在这里编写代码
        }

        /// <summary>
        /// 练习6：属性的读写控制
        /// 1. 为 Book 类添加 ISBN 属性：外部只能读、不能写（私有 set）
        /// 2. ISBN 通过构造函数传入
        /// 3. 尝试在方法中给 ISBN 赋值（观察编译器报错），体会封装的意义
        /// </summary>
        public static void Exercise06_PropertyAccess()
        {
            // TODO: 在这里编写代码
        }

        /// <summary>
        /// 练习7：属性验证（封装的精髓）
        /// 1. 定义 Person 类，字段 age 为私有
        /// 2. 属性 Age 的 set 中加入验证：只允许 0-150，否则输出"年龄无效"并保持原值
        /// 3. 测试：先赋值 25 输出，再赋值 -5 观察结果
        /// 回顾：这里用到了第一周的 if-else 判断
        /// </summary>
        public static void Exercise07_PropertyValidation()
        {
            // TODO: 在这里编写代码
        }

        /// <summary>
        /// 练习8：只读属性与计算属性
        /// 1. 定义 Circle 类，属性 Radius（可读可写）
        /// 2. 添加只读属性 Area，每次 get 时计算并返回 Math.PI * r * r
        /// 3. 输出半径为 5 的圆的面积（保留两位小数，格式 :F2）
        /// 回顾：第一周的字符串插值 $"" 和格式化
        /// </summary>
        public static void Exercise08_ReadOnlyProperty()
        {
            // TODO: 在这里编写代码
        }

        #endregion

        #region 三、继承与多态

        /// <summary>
        /// 练习9：继承基础
        /// 1. 定义 Animal 类，包含属性 Name 和方法 Eat()（输出 "XX正在吃东西"）
        /// 2. 定义 Dog 类继承 Animal，新增方法 Bark()（输出 "汪汪汪"）
        /// 3. 创建 Dog 对象，调用继承来的 Eat() 和自己的 Bark()
        /// 思考：Dog 没有定义 Eat，为什么能调用？
        /// </summary>
        public static void Exercise09_Inheritance()
        {
            // TODO: 在这里编写代码
        }

        /// <summary>
        /// 练习10：virtual 与 override
        /// 1. 为 Animal 添加 virtual 方法 MakeSound()（输出 "动物发出声音"）
        /// 2. Dog 用 override 重写为 "汪汪汪"；再定义 Cat 类重写为 "喵喵喵"
        /// 3. 分别创建 Animal、Dog、Cat 对象调用 MakeSound() 观察输出
        /// </summary>
        public static void Exercise10_VirtualOverride()
        {
            // TODO: 在这里编写代码
        }

        /// <summary>
        /// 练习11：多态（本周重点）
        /// 1. 声明 Animal 类型的数组，存入 Dog 和 Cat 对象各两个
        /// 2. 用 foreach 遍历，统一调用 MakeSound()
        /// 3. 观察输出：同一个方法调用，为何结果不同？
        /// 回顾：这里综合了第一周的数组 + foreach 循环
        /// </summary>
        public static void Exercise11_Polymorphism()
        {
            // TODO: 在这里编写代码
        }

        /// <summary>
        /// 练习12：base 关键字
        /// 1. 定义 Vehicle 类，构造函数接收 brand 并输出 "创建了品牌为XX的车"
        /// 2. 定义 Car 类继承 Vehicle，构造函数接收 brand 和 seats，
        ///    用 : base(brand) 调用父类构造函数，并输出 "这是一辆X座的车"
        /// 3. 创建 Car("比亚迪", 5)，观察两个构造函数的调用顺序
        /// </summary>
        public static void Exercise12_BaseKeyword()
        {
            // TODO: 在这里编写代码
        }

        /// <summary>
        /// 练习13：is / as 类型判断
        /// 1. 使用练习11的 Animal 数组（Dog、Cat 混合）
        /// 2. 遍历时用 is 判断：如果是 Dog，额外调用 Bark()
        /// 3. 用 as 尝试转换，转换失败（结果为 null）时输出"这不是一只狗"
        /// </summary>
        public static void Exercise13_IsAndAs()
        {
            // TODO: 在这里编写代码
        }

        #endregion

        #region 四、对象数组与方法综合

        /// <summary>
        /// 练习14：对象数组
        /// 1. 创建 Student 数组，存入 5 个学生（姓名、年龄各不相同）
        /// 2. 遍历输出所有学生的介绍信息
        /// 3. 找出年龄最大的学生并输出
        /// 回顾：第一周练习16的"找最大值"思路，只不过这次比较的是对象的属性
        /// </summary>
        public static void Exercise14_ObjectArray()
        {
            // TODO: 在这里编写代码
        }

        /// <summary>
        /// 练习15：对象作为方法参数和返回值
        /// 1. 定义方法 PrintStudent(Student s)，输出学生信息
        /// 2. 定义方法 CreateStudent(string name, int age)，返回一个新的 Student 对象
        /// 3. 定义方法 CompareAge(Student a, Student b)，返回年龄较大的那个学生
        /// 4. 在方法体内测试以上三个方法
        /// 回顾：第一周练习12的方法定义、练习14的 ref/out——思考对象传递和 int 传递有何不同
        /// </summary>
        public static void Exercise15_ObjectAsParameter()
        {
            // TODO: 在这里编写代码
        }

        /// <summary>
        /// 练习16：值类型 vs 引用类型（本周难点）
        /// 1. int a = 10; int b = a; b = 20; 输出 a 是多少？为什么？
        /// 2. Student s1 = new Student("小明", 18); Student s2 = s1; s2.Age = 20;
        ///    输出 s1 的年龄是多少？为什么和上面结果不同？
        /// 3. 用注释写出你的理解（值类型复制数据，引用类型复制地址）
        /// </summary>
        public static void Exercise16_ValueVsReference()
        {
            // TODO: 在这里编写代码
        }

        /// <summary>
        /// 练习17：字符串与对象结合
        /// 1. 给定字符串数组：{ "张三,25", "李四,30", "王五,22" }
        /// 2. 用 Split(',') 解析每行，创建 Student 对象存入数组
        /// 3. 输出解析后的所有学生信息
        /// 回顾：第一周练习18的字符串操作 + 本周的对象数组
        /// </summary>
        public static void Exercise17_StringToObject()
        {
            // TODO: 在这里编写代码
        }

        #endregion

        #region 五、综合挑战

        /// <summary>
        /// 练习18：学生成绩管理系统（综合挑战）
        /// 设计一个简化的成绩管理系统：
        /// 1. 升级 Student 类（或新定义 StudentV2 类）：姓名、语文、数学、英语三科成绩
        /// 2. 添加方法 GetAverage() 返回平均分、GetLevel() 返回等级（复用第一周练习8的规则）
        /// 3. 创建 3 个学生存入数组，输出每个人的平均分和等级
        /// 4. 找出全班平均分最高的学生
        /// </summary>
        public static void Exercise18_GradeManagement()
        {
            // TODO: 在这里编写代码
        }

        /// <summary>
        /// 练习19：银行账户系统（终极挑战）
        /// 设计 BankAccount 类：
        /// 1. 私有字段 balance（余额），通过只读属性 Balance 对外暴露
        /// 2. 方法 Deposit(double amount)：存款，金额必须大于 0
        /// 3. 方法 Withdraw(double amount)：取款，余额不足时输出"余额不足"并拒绝
        /// 4. 静态字段 TotalAccounts 记录开户总数
        /// 5. 模拟操作：开户(初始1000) -> 存500 -> 取2000(应失败) -> 取300 -> 输出余额
        /// 综合考点：封装、验证、静态成员、方法设计
        /// </summary>
        public static void Exercise19_BankAccount()
        {
            // TODO: 在这里编写代码
        }

        #endregion
    }
}
