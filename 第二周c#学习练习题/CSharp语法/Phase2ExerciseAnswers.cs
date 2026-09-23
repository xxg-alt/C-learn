namespace HelloDotNetGuide.CSharp语法
{
    /// <summary>
    /// 第二阶段练习题参考答案
    /// 建议先独立完成 Phase2Exercises.cs，再对照本文件检查。
    /// 注释中带【解析】标记的是本题的核心考点。
    /// </summary>
    public class Phase2ExerciseAnswers
    {
        #region 一、类和对象

        public static void Exercise01_DefineClass()
        {
            Student s = new Student();
            s.Name = "张三";
            s.Age = 20;
            s.Introduce();
            // 【解析】类是"图纸"，对象是"实物"。new 关键字根据图纸造出一个对象，
            // 每个对象的字段相互独立，互不影响。
        }

        public static void Exercise02_Constructor()
        {
            Student s1 = new Student("李四", 22);
            Student s2 = new Student();
            s1.Introduce();
            s2.Introduce();
            // 【解析】构造函数在 new 时自动执行，保证对象"一出生就是完整的"。
            // 一旦自己定义了构造函数，编译器就不再免费提供无参构造函数，需要手动补上。
        }

        public static void Exercise03_ThisKeyword()
        {
            Rectangle rect = new Rectangle(3, 4);
            Console.WriteLine($"面积：{rect.GetArea()}, 周长：{rect.GetPerimeter()}");
            // 【解析】当参数名和字段名相同时，参数会"遮蔽"字段，
            // this.width 指字段，width 指参数。this 就是"当前这个对象自己"。
        }

        public static void Exercise04_StaticMember()
        {
            new Student("小明", 18);
            new Student("小红", 19);
            new Student("小刚", 20);
            Student.ShowCount();
            // 【解析】static 成员属于"类"而不是某个对象，所有对象共享同一份。
            // 如果 Count 不加 static，每个对象各自有一份 Count，永远只会是 1。
        }

        #endregion

        #region 二、属性与封装

        public static void Exercise05_AutoProperty()
        {
            Book book = new Book { Title = "C#入门", Price = 59.9 };
            Console.WriteLine($"书名：{book.Title}, 价格：{book.Price}");
            // 【解析】自动属性 public string Title { get; set; } 背后由编译器
            // 自动生成一个私有字段，是"字段 + get/set 方法"的语法糖。
        }

        public static void Exercise06_PropertyAccess()
        {
            Book book = new Book("978-7-111-00000-0") { Title = "C#进阶", Price = 79.9 };
            Console.WriteLine($"ISBN：{book.ISBN}");
            // book.ISBN = "123"; // 编译报错：set 访问器不可访问
            // 【解析】private set 让属性"对外只读、对内可写"，
            // 这就是封装：把"怎么改"的权力留在类自己手里。
        }

        public static void Exercise07_PropertyValidation()
        {
            Person p = new Person();
            p.Age = 25;
            Console.WriteLine($"年龄：{p.Age}");
            p.Age = -5; // 验证拦截
            Console.WriteLine($"年龄：{p.Age}");
            // 【解析】属性是字段的"门卫"。字段设为 private 后，
            // 外部想改值必须经过属性的 set，验证逻辑就有机会执行。
        }

        public static void Exercise08_ReadOnlyProperty()
        {
            Circle c = new Circle();
            c.Radius = 5;
            Console.WriteLine($"半径 5 的圆面积：{c.Area:F2}");
            // 【解析】只有 get 没有 set 的属性就是只读属性。
            // Area 不存数据，每次 get 时现场计算，保证结果永远和 Radius 同步。
        }

        #endregion

        #region 三、继承与多态

        public static void Exercise09_Inheritance()
        {
            Dog dog = new Dog();
            dog.Name = "旺财";
            dog.Eat();
            dog.Bark();
            // 【解析】Dog 继承 Animal 后，自动拥有 Animal 的所有 public 成员。
            // 继承表达的是"is-a"关系：狗"是"一种动物。
        }

        public static void Exercise10_VirtualOverride()
        {
            Animal a = new Animal();
            Dog d = new Dog();
            Cat c = new Cat();
            a.MakeSound(); // 动物发出声音
            d.MakeSound(); // 汪汪汪
            c.MakeSound(); // 喵喵喵
            // 【解析】virtual 表示"允许子类重写"，override 表示"我来重写"。
            // 两者必须配对出现，少了 virtual 就不能 override。
        }

        public static void Exercise11_Polymorphism()
        {
            Animal[] animals = { new Dog(), new Cat(), new Dog(), new Cat() };
            foreach (Animal animal in animals)
            {
                animal.MakeSound();
            }
            // 【解析】多态 = 同一个调用，不同的对象给出不同的响应。
            // 编译时变量类型是 Animal，但运行时看的是"实际装着什么对象"，
            // 实际装的是 Dog 就执行 Dog 的重写版本。
        }

        public static void Exercise12_BaseKeyword()
        {
            Car car = new Car("比亚迪", 5);
            // 输出顺序：
            // 创建了品牌为比亚迪的车
            // 这是一辆5座的车
            // 【解析】子类构造前，必须先完成父类构造（先有"车"才有"轿车"），
            // : base(brand) 把参数传递给父类构造函数。
        }

        public static void Exercise13_IsAndAs()
        {
            Animal[] animals = { new Dog(), new Cat(), new Dog() };
            foreach (Animal animal in animals)
            {
                animal.MakeSound();

                // is 判断类型
                if (animal is Dog d)
                {
                    d.Bark();
                }

                // as 尝试转换，失败返回 null 而不抛异常
                Dog? dog = animal as Dog;
                if (dog == null)
                {
                    Console.WriteLine("这不是一只狗");
                }
            }
            // 【解析】is 用于"判断"，as 用于"尝试转换"。
            // 强转 (Dog)animal 失败会抛异常，as 失败只是返回 null，更安全。
        }

        #endregion

        #region 四、对象数组与方法综合

        public static void Exercise14_ObjectArray()
        {
            Student[] students =
            {
                new Student("张三", 18),
                new Student("李四", 22),
                new Student("王五", 20),
                new Student("赵六", 25),
                new Student("钱七", 19)
            };

            foreach (Student s in students)
            {
                s.Introduce();
            }

            // 找年龄最大：思路和第一周"找数组最大值"完全一致，只是比较 .Age
            Student oldest = students[0];
            foreach (Student s in students)
            {
                if (s.Age > oldest.Age)
                {
                    oldest = s;
                }
            }
            Console.WriteLine($"年龄最大的是：{oldest.Name}，{oldest.Age}岁");
        }

        public static void Exercise15_ObjectAsParameter()
        {
            Student a = CreateStudent("小明", 18);
            Student b = CreateStudent("小红", 21);
            PrintStudent(a);
            PrintStudent(b);
            Student older = CompareAge(a, b);
            Console.WriteLine($"年龄较大的是：{older.Name}");
            // 【解析】对象作为参数传递的是"引用"（地址），
            // 方法内修改对象属性会影响方法外——这和 int 参数完全不同（见练习16）。
        }

        private static void PrintStudent(Student s) => s.Introduce();

        private static Student CreateStudent(string name, int age) => new Student(name, age);

        private static Student CompareAge(Student a, Student b) => a.Age > b.Age ? a : b;

        public static void Exercise16_ValueVsReference()
        {
            // 1. 值类型
            int a = 10;
            int b = a;
            b = 20;
            Console.WriteLine($"a = {a}"); // a = 10
            // int 是值类型，b = a 复制的是"数据本身"，b 改了不影响 a。

            // 2. 引用类型
            Student s1 = new Student("小明", 18);
            Student s2 = s1;
            s2.Age = 20;
            Console.WriteLine($"s1.Age = {s1.Age}"); // s1.Age = 20
            // 类是引用类型，s2 = s1 复制的是"地址"，
            // s1 和 s2 指向同一个对象，所以通过 s2 修改，s1 也能看到变化。
        }

        public static void Exercise17_StringToObject()
        {
            string[] lines = { "张三,25", "李四,30", "王五,22" };
            Student[] students = new Student[lines.Length];

            for (int i = 0; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split(',');
                students[i] = new Student(parts[0], int.Parse(parts[1]));
            }

            foreach (Student s in students)
            {
                s.Introduce();
            }
            // 【解析】这是"文本数据 -> 对象"的经典转换，
            // 字符串负责存储/传输，对象负责承载行为（方法）。
        }

        #endregion

        #region 五、综合挑战

        public static void Exercise18_GradeManagement()
        {
            StudentV2[] students =
            {
                new StudentV2("张三", 90, 85, 88),
                new StudentV2("李四", 70, 65, 72),
                new StudentV2("王五", 95, 92, 96)
            };

            foreach (StudentV2 s in students)
            {
                Console.WriteLine($"{s.Name}：平均分={s.GetAverage():F1}，等级={s.GetLevel()}");
            }

            StudentV2 top = students[0];
            foreach (StudentV2 s in students)
            {
                if (s.GetAverage() > top.GetAverage())
                {
                    top = s;
                }
            }
            Console.WriteLine($"全班第一是：{top.Name}，平均分 {top.GetAverage():F1}");
            // 【解析】把数据和操作数据的方法放进同一个类，就是面向对象的核心思想。
            // GetLevel 内部直接复用了第一周的 if-else if-else 分数段判断。
        }

        public static void Exercise19_BankAccount()
        {
            BankAccount account = new BankAccount(1000);
            account.Deposit(500);
            account.Withdraw(2000); // 余额不足，拒绝
            account.Withdraw(300);
            Console.WriteLine($"最终余额：{account.Balance}");
            Console.WriteLine($"开户总数：{BankAccount.TotalAccounts}");
            // 【解析】balance 是私有字段，外部无法直接修改，
            // 所有资金变动都必须经过 Deposit/Withdraw 的验证——
            // 这就是封装保护数据安全的实际价值。
        }

        #endregion
    }

    #region 参考答案所需的类定义

    /// <summary>
    /// 练习1-4、14-17 使用的学生类
    /// </summary>
    public class Student
    {
        // 静态字段：所有 Student 对象共享，记录创建总数
        public static int Count = 0;

        public string Name;
        public int Age;

        // 无参构造函数
        public Student()
        {
            Name = "未命名";
            Age = 0;
            Count++;
        }

        // 带参构造函数
        public Student(string name, int age)
        {
            Name = name;
            Age = age;
            Count++;
        }

        public void Introduce()
        {
            Console.WriteLine($"大家好，我是{Name}，今年{Age}岁");
        }

        public static void ShowCount()
        {
            Console.WriteLine($"当前学生总数：{Count}");
        }
    }

    /// <summary>
    /// 练习3 使用的矩形类
    /// </summary>
    public class Rectangle
    {
        private double width;
        private double height;

        // 参数名与字段名相同，用 this 区分
        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public double GetArea() => width * height;

        public double GetPerimeter() => 2 * (width + height);
    }

    /// <summary>
    /// 练习5-6 使用的图书类
    /// </summary>
    public class Book
    {
        public string Title { get; set; } = "";
        public double Price { get; set; }

        // 对外只读，只能在类内部（构造函数中）赋值
        public string ISBN { get; private set; }

        public Book() { ISBN = ""; }

        public Book(string isbn)
        {
            ISBN = isbn;
        }
    }

    /// <summary>
    /// 练习7 使用的人类（属性验证）
    /// </summary>
    public class Person
    {
        private int age;

        public int Age
        {
            get { return age; }
            set
            {
                if (value >= 0 && value <= 150)
                {
                    age = value;
                }
                else
                {
                    Console.WriteLine("年龄无效");
                }
            }
        }
    }

    /// <summary>
    /// 练习8 使用的圆形类（计算属性）
    /// </summary>
    public class Circle
    {
        public double Radius { get; set; }

        // 只读计算属性：不存储，get 时现场计算
        public double Area
        {
            get { return Math.PI * Radius * Radius; }
        }
    }

    /// <summary>
    /// 练习9-13 使用的动物继承体系
    /// </summary>
    public class Animal
    {
        public string Name { get; set; } = "";

        public void Eat()
        {
            Console.WriteLine($"{Name}正在吃东西");
        }

        public virtual void MakeSound()
        {
            Console.WriteLine("动物发出声音");
        }
    }

    public class Dog : Animal
    {
        public Dog() { Name = "狗"; }

        public void Bark()
        {
            Console.WriteLine("汪汪汪");
        }

        public override void MakeSound()
        {
            Console.WriteLine("汪汪汪");
        }
    }

    public class Cat : Animal
    {
        public Cat() { Name = "猫"; }

        public override void MakeSound()
        {
            Console.WriteLine("喵喵喵");
        }
    }

    /// <summary>
    /// 练习12 使用的车辆继承体系
    /// </summary>
    public class Vehicle
    {
        public string Brand { get; set; }

        public Vehicle(string brand)
        {
            Brand = brand;
            Console.WriteLine($"创建了品牌为{brand}的车");
        }
    }

    public class Car : Vehicle
    {
        public int Seats { get; set; }

        public Car(string brand, int seats) : base(brand)
        {
            Seats = seats;
            Console.WriteLine($"这是一辆{seats}座的车");
        }
    }

    /// <summary>
    /// 练习18 使用的升级版学生类
    /// </summary>
    public class StudentV2
    {
        public string Name { get; set; }
        public double Chinese { get; set; }
        public double Math { get; set; }
        public double English { get; set; }

        public StudentV2(string name, double chinese, double math, double english)
        {
            Name = name;
            Chinese = chinese;
            Math = math;
            English = english;
        }

        public double GetAverage() => (Chinese + Math + English) / 3;

        // 复用第一周练习8的分数段规则
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

    /// <summary>
    /// 练习19 使用的银行账户类
    /// </summary>
    public class BankAccount
    {
        public static int TotalAccounts = 0;

        // 私有字段：外部无法直接访问和修改
        private double balance;

        // 只读属性：只能看，不能改
        public double Balance
        {
            get { return balance; }
        }

        public BankAccount(double initialBalance)
        {
            balance = initialBalance;
            TotalAccounts++;
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"存入 {amount}，余额：{balance}");
            }
            else
            {
                Console.WriteLine("存款金额必须大于0");
            }
        }

        public void Withdraw(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("取款金额必须大于0");
            }
            else if (amount > balance)
            {
                Console.WriteLine("余额不足");
            }
            else
            {
                balance -= amount;
                Console.WriteLine($"取出 {amount}，余额：{balance}");
            }
        }
    }

    #endregion
}
