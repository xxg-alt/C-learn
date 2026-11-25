using System;
using System.Collections.Generic;

namespace HelloDotNetGuide.CSharp语法
{
/// <summary>
/// 前三周综合复习题：和原题同一个题型、同一个知识点，但换了场景和数据。
/// 目的不是背答案，是验你离开原来的题目还写不写得出来。
///
/// 用法（和前四周一样）：
/// 1. 每题只有任务说明、三级提示和一行“待完成”占位，没有答案。
/// 先自己写；卡住看提示1，还卡看提示2，提示3 接近骨架。
/// 2. 写完删掉占位行，在 Program.cs 里取消对应调用的注释来运行。
/// 3. 新类型照旧定义在本类，避免同名冲突（CS0101）。
/// 4. 对照表：01-05 对应第1周，06-10 对应第2周，11-15 对应第3周，
/// 16-19 是把三周揉在一起的综合题（图书馆借阅系统，一题接一题往下做）。
/// 哪一题写不出来，就说明那一周的那个知识点没真过关，回去翻那一周的那一题。
/// </summary>
public class PhaseReviewExercises
{
#region 一、第1周复习：基础语法

/// <summary>
/// 复习1（对应第1周：变量与运算符）：购物小票
/// 1. 定义变量：单价 double price = 12.5，数量 int count = 4，会员折扣 double discount = 0.8
/// 2. 计算原价总价和折后总价，各输出一行，折后价保留 2 位小数
/// 3. 再算：如果付 50 元，应找零多少？
/// 提示1：折后总价 = price * count * discount
/// 提示2：保留 2 位小数用格式占位：$"{value:F2}"
/// 提示3：找零 = 50 - 折后总价，先把折后总价存进变量再算
/// </summary>
public static void Review01_VariablesAndOperators()
{
// TODO: 在这里写你的实现，写完删掉下面这行占位
Console.WriteLine("复习01：待完成");
}

/// <summary>
/// 复习2（对应第1周：if-else）：电影票分档定价
/// 1. 定义 int age，分别用 8、15、30、70 四个年龄测试
/// 2. 规则：12 岁以下 20 元；12-17 岁 30 元；18-59 岁 50 元；60 岁及以上 25 元
/// 3. 写一个方法 string TicketPrice(int age) 返回价格说明，在本练习里循环测四个年龄并输出
/// 提示1：从小到大判断，用 if / else if / else，别写四个独立 if
/// 提示2：边界想清楚：12 岁算哪一档？题目说“12 岁以下”是小于 12，12 本人进第二档
/// 提示3：方法里 return $"年龄{age}：票价{price}元"; 主练习里 foreach 一个 int 数组来测
/// </summary>
public static void Review02_IfElse()
{
// TODO: 在这里写你的实现，写完删掉下面这行占位
Console.WriteLine("复习02：待完成");
}

/// <summary>
/// 复习3（对应第1周：循环）：奇数累加 + 乘法表一角
/// 1. 用 for 循环算 1 到 100 之间所有奇数的和，输出结果（正确答案是 2500，自己算出来对一下）
/// 2. 用嵌套循环打印九九乘法表的前 5 行（1x1 到 5x5），每行一排
/// 提示1：判断奇数用 i % 2 == 1，% 是取余数
/// 提示2：乘法表外层循环控制行 i，内层循环 j 从 1 到 i
/// 提示3：内层用 Console.Write($"{j}x{i}={i * j}\t"); 每行结束 Console.WriteLine();
/// </summary>
public static void Review03_Loops()
{
// TODO: 在这里写你的实现，写完删掉下面这行占位
Console.WriteLine("复习03：待完成");
}

/// <summary>
/// 复习4（对应第1周：方法）：两个工具方法
/// 1. 写方法 double RectangleArea(double w, double h) 返回矩形面积，测一组 3.5 和 2
/// Rectangle = 矩形，Area = 面积
/// 2. 写方法 bool IsLeapYear(int year) 判断闰年，测 2024、2023、2000、1900 四个年份
/// LeapYear = 闰年；规则：能被 400 整除是闰年；能被 100 整除不是；能被 4 整除是
/// 3. 两个方法都写成 static，放在本类内部（和复习2 的 TicketPrice 同样放法）
/// 提示1：闰年判断的顺序不能反：先判 400，再判 100，最后判 4
/// 提示2：IsLeapYear 可以写成一行 return：(year % 400 == 0) || (year % 4 == 0 && year % 100!= 0)
/// 提示3：2000 是闰年、1900 不是——这两个就是专门验你顺序对不对的
/// </summary>
public static void Review04_Methods()
{
// TODO: 在这里写你的实现，写完删掉下面这行占位
Console.WriteLine("复习04：待完成");
}

/// <summary>
/// 复习5（对应第1周：数组与字符串）：数组统计 + 单词计数
/// 1. 给定 int[] nums = { 7, 3, 9, 3, 12, 5}，用循环（不用内置方法）找最大值、最小值、平均值并输出
/// 2. 给定 string sentence = "the cat and the dog and the bird"，用 Split 按空格拆开，
/// 输出单词总数，并统计 "the" 出现了几次（先只用循环统计，字典版在复习12）
/// 提示1：最大值先假设第一个就是最大，再逐个比较替换
/// 提示2：平均值注意整数除法坑：总和是 int 时先转 double 再除
/// 提示3：string[] words = sentence.Split(' '); 统计就是遍历 words 数相等的
/// </summary>
public static void Review05_ArrayAndString()
{
// TODO: 在这里写你的实现，写完删掉下面这行占位
Console.WriteLine("复习05：待完成");
}

#endregion

#region 二、第2周复习：面向对象

/// <summary>
/// 复习6（对应第2周：类与构造函数重载）：Book 类
/// 1. 在本类内部定义小类 ReviewBook：属性 Title（书名）、Author（作者）、Pages（页数）
/// 2. 写两个构造函数：一个三样都要传；一个只传书名和作者，页数默认 0（用: this(...) 链式调用）
/// 3. 写方法 Introduce() 输出“《书名》- 作者，共 X 页”；在本练习里用两个构造函数各建一本书并调用
/// 提示1：构造函数名和类名相同、没有返回值类型
/// 提示2：链式写法：public ReviewBook(string title, string author): this(title, author, 0) {}
/// 提示3：第2周练习2 就是这个题型，写不出说明构造函数重载没过关
/// </summary>
public static void Review06_ClassAndConstructor()
{
// TODO: 在这里写你的实现，写完删掉下面这行占位
Console.WriteLine("复习06：待完成");
}

/// <summary>
/// 复习7（对应第2周：属性验证）：Product 商品类
/// 1. 在本类内部定义小类 ReviewProduct：Name 属性自由读写；
/// Price（价格）用完整属性写法验证：小于 0 时抛 ArgumentException("价格不能为负")
/// 2. 正常建一个商品输出价格；再用 try-catch 试着把价格设成 -5，输出抓到的异常信息
/// ArgumentException：Argument（参数）+ Exception（异常）= “参数不对”异常
/// 提示1：完整属性要有私有字段打底：private double price; 属性的 set 里先判断再赋值
/// 提示2：throw new ArgumentException("...") —— 第2周练习7、第3周练习16 都练过这个动作
/// 提示3：验证写在 set 里，构造时赋值也会走 set，所以构造函数里用属性赋值就能顺带验证
/// </summary>
public static void Review07_PropertyValidation()
{
// TODO: 在这里写你的实现，写完删掉下面这行占位
Console.WriteLine("复习07：待完成");
}

/// <summary>
/// 复习8（对应第2周：继承与多态）：形状面积
/// 1. 定义基类 ReviewShape：虚方法 virtual double GetArea() 默认返回 0，方法 Describe() 输出“面积是 X”
/// Shape = 形状，GetArea = 拿面积
/// 2. 子类 ReviewCircle（圆，半径 Radius）：override GetArea 返回 3.14 * 半径 * 半径
/// 3. 子类 ReviewRectangleShape（矩形，宽高）：override GetArea 返回宽 * 高
/// 注意别和复习4 的方法名混淆，这里是类
/// 4. 建一个 ReviewShape 数组装一个圆一个矩形，统一遍历调用 Describe()——多态验的就是这一幕
/// 提示1：子类写法：class ReviewCircle: ReviewShape，冒号 = 继承
/// 提示2：Describe 写在基类里、内部调用 GetArea()，子类不用重写 Describe 也能出各自的面积，这正是虚方法的用处
/// 提示3：第2周练习10、11 是原题型；数组类型写基类，装子类对象
/// </summary>
public static void Review08_InheritancePolymorphism()
{
// TODO: 在这里写你的实现，写完删掉下面这行占位
Console.WriteLine("复习08：待完成");
}

/// <summary>
/// 复习9（对应第2周：静态成员）：注册计数器
/// 1. 定义小类 ReviewUser：实例属性 Name；静态属性 static int Count；静态方法 static void ShowCount()
/// 2. 每创建一个用户，构造函数里让 Count 加 1
/// 3. 在本练习里连建 3 个用户，最后用 ReviewUser.ShowCount() 输出总人数
/// 提示1：static 的东西属于“类本身”，不属于某一个对象，所以用类名点出来
/// 提示2：构造函数里 Count++; 就够了，静态属性不用 this
/// 提示3：想一想：为什么 Count 必须是 static？写成普通属性，每个人就只会数到 1（写一行注释）
/// </summary>
public static void Review09_StaticMembers()
{
// TODO: 在这里写你的实现，写完删掉下面这行占位
Console.WriteLine("复习09：待完成");
}

/// <summary>
/// 复习10（对应第2周：对象数组 + 对象作参数和返回值）：找最贵商品
/// 1. 复用复习7 的 ReviewProduct，建一个对象数组，装 4 个商品（名字、价格自定）
/// 2. 写静态方法 ReviewProduct FindMostExpensive(ReviewProduct[] items)：返回最贵的那个对象
/// MostExpensive：Most（最）+ Expensive（贵的）
/// 3. 调用方法并输出最贵商品的名字和价格；再想一下：如果有两个并列最贵，这个方法返回哪个？（写一行注释）
/// 提示1：方法和复习5 找最大值的思路一样，只不过比较的是对象的 Price 属性、记住的是对象本身
/// 提示2：先假设数组第 0 个最贵，逐个用.Price 比较
/// 提示3：返回值类型写类名——对象可以像数字一样被返回，这是第2周练习15 的题型
/// </summary>
public static void Review10_ObjectArrayAndReturn()
{
// TODO: 在这里写你的实现，写完删掉下面这行占位
Console.WriteLine("复习10：待完成");
}

#endregion

#region 三、第3周复习：集合与异常

/// <summary>
/// 复习11（对应第3周：List 基础）：待办清单
/// 1. 创建 List&lt;string&gt; todos，用集合初始化器存入“写作业”“练 C#”“跑步”
/// 2. Add 追加“看书”；Insert 在索引 0 插入“起床”；Remove 删除“跑步”；每步之后输出一遍清单和 Count
/// 3. 用 Contains 判断清单里有没有“练 C#”，输出结果
/// 提示1：第3周练习1、2 的原题型，方法名一个没变：Add / Insert / Remove / Contains / Count
/// 提示2：输出清单写个小循环，别一行行手写 WriteLine
/// 提示3：Remove 删的是“第一个长这样的”，RemoveAt 删的是“第几个”，别用混
/// </summary>
public static void Review11_ListBasics()
{
// TODO: 在这里写你的实现，写完删掉下面这行占位
Console.WriteLine("复习11：待完成");
}

/// <summary>
/// 复习12（对应第3周：Dictionary）：投票统计
/// 1. 给定 string[] votes = { "A", "B", "A", "C", "B", "A"}（A/B/C 是三个候选人）
/// 2. 用 Dictionary&lt;string, int&gt; 统计每人票数：遍历 votes，有这个键就 +1，没有就新建为 1
/// 3. 遍历字典输出每人票数；再用 TryGetValue 安全地查一次不存在的 "D"，输出“查无此人”
/// 提示1：这就是第3周练习8 词频统计换了层皮：先 ContainsKey 判断，再决定新建还是 +1
/// 提示2：也可以用三元写法：dict[v] = dict.ContainsKey(v)? dict[v] + 1: 1;
/// 提示3：TryGetValue 返回 bool，第二个参数用 out 接收值；复习5 里数 "the" 的字典版就是这题
/// </summary>
public static void Review12_DictionaryVoteCount()
{
// TODO: 在这里写你的实现，写完删掉下面这行占位
Console.WriteLine("复习12：待完成");
}

/// <summary>
/// 复习13（对应第3周：泛型方法）：通用打印与交换
/// 1. 写泛型方法 void PrintAll&lt;T&gt;(T[] arr)：把任意类型数组逐个输出
/// 分别用 int 数组和 string 数组调用两次
/// 2. 写泛型方法 void Swap&lt;T&gt;(ref T a, ref T b)：交换两个变量的值
/// Swap = 交换；分别交换两个 int 和两个 string 并输出验证
/// 提示1：泛型方法在方法名后写 &lt;T&gt;，T 是占位符，用的时候编译器自己推断类型，连 &lt;int&gt; 都可以不写
/// 提示2：Swap 必须用 ref，不然交换的只是复印件——第2周练习16 值类型/引用类型的坑在这里等着你
/// 提示3：第3周练习12 写的是 Max&lt;T&gt;，这题换成 PrintAll 和 Swap，套路相同
/// </summary>
public static void Review13_GenericMethods()
{
// TODO: 在这里写你的实现，写完删掉下面这行占位
Console.WriteLine("复习13：待完成");
}

/// <summary>
/// 复习14（对应第3周：异常处理）：安全数字输入
/// 1. 写方法 int SafeParse(string text)：用 int.TryParse 转换，成功返回数字，
/// 失败时 throw new FormatException("不是合法数字：" + text)
/// 2. 在本练习里依次测 "42"、"3.5"、"abc" 三个字符串，每个都包在 try-catch 里：
/// 成功输出数字，失败输出异常信息；最后用 finally 输出一句“本轮测试结束”
/// 提示1：int.TryParse(text, out int value) 返回 bool，比直接 Parse 更温和
/// 提示2：catch (FormatException ex) 抓指定类型，输出 ex.Message
/// 提示3：finally 里的代码无论成败都执行——第3周练习13、14、15 三题揉在这一题里
/// </summary>
public static void Review14_ExceptionHandling()
{
// TODO: 在这里写你的实现，写完删掉下面这行占位
Console.WriteLine("复习14：待完成");
}

/// <summary>
/// 复习15（对应第3周：Stack 与 Queue）：浏览器后退 + 打印队列
/// 1. 用 Stack&lt;string&gt; 模拟浏览器：依次 Push 三个网页（首页、列表页、详情页），
/// 然后 Pop 两次模拟点两次“后退”，每次输出回到了哪个页面（Peek 看栈顶）
/// Stack = 栈，后进先出；Push = 压入，Pop = 弹出，Peek = 只看不拿
/// 2. 用 Queue&lt;string&gt; 模拟打印队列：Enqueue 三个文件名，逐个 Dequeue 打印“正在打印 X”
/// Queue = 队列，先进先出
/// 提示1：第3周练习11 的原题型，两个容器的方法名别记反：栈是 Push/Pop，队列是 Enqueue/Dequeue
/// 提示2：后退的动作 = Pop 掉当前页，然后 Peek 看新栈顶就是回到的页面
/// 提示3：队列循环写法：while (q.Count > 0) {... Dequeue()...}
/// </summary>
public static void Review15_StackQueue()
{
// TODO: 在这里写你的实现，写完删掉下面这行占位
Console.WriteLine("复习15：待完成");
}

#endregion

#region 四、综合复习：图书馆借阅系统（16-19 连做）

/// <summary>
/// 复习16（综合第 1 步：建模）：定义 Book 与 Library
/// 1. 在本类内部定义小类 LibraryBook：属性 Title、Category（类别）、Stock（库存数量），
/// 构造函数一次传齐三样；方法 Introduce() 输出“《书名》[类别] 库存 X”
/// Category = 类别，Stock = 库存
/// 2. 定义小类 Library：内部有一个 List&lt;LibraryBook&gt;（private），
/// 方法 AddBook(LibraryBook book) 把书加入；方法 ShowAll() 遍历输出所有书
/// 3. 在本练习里建图书馆、加 3 本书、调用 ShowAll()
/// 提示1：这一题只用第2周（类、构造函数、属性）+ 第3周（List）的知识
/// 提示2：List 设为 private、只给 AddBook 和 ShowAll 两个口子，这叫封装，第2周的主线
/// 提示3：后面 17-19 题继续用这两个类，先把这一题写扎实，类定义只写一份、四题共用
/// </summary>
public static void Review16_LibraryModel()
{
// TODO: 在这里写你的实现，写完删掉下面这行占位
Console.WriteLine("复习16：待完成");
}

/// <summary>
/// 复习17（综合第 2 步：借还 + 异常）：给 Library 加借书和还书
/// 1. 自定义异常类 BookNotFoundException（写在本类内部，继承 Exception），
/// 构造时接收书名，消息为“查无此书：X”
/// 2. Library 加方法 Borrow(string title)：先用 Find 按书名找书，
/// 找不到 throw BookNotFoundException；找到但 Stock 为 0 时 throw InvalidOperationException("已借完")；
/// 正常则 Stock 减 1 并输出“借出《X》，剩余 Y”
/// Borrow = 借，InvalidOperationException = “当前状态不允许这个操作”异常
/// 3. Library 加方法 Return(string title)：找到书 Stock 加 1，找不到同样抛 BookNotFoundException
/// 4. 在本练习里：正常借一本、借一本不存在的书、把一本借到库存为 0 再借一次，三种情况分别 try-catch 输出结果
/// 提示1：Find 的 Lambda 和第3周一样：books.Find(b => b.Title == title)
/// 提示2：自定义异常的写法在第3周练习16：class XxxException: Exception，构造函数用 base(message) 传话
/// 提示3：判断顺序别反：先判“有没有这本书”，再判“还有没有库存”
/// </summary>
public static void Review17_LibraryBorrowReturn()
{
// TODO: 在这里写你的实现，写完删掉下面这行占位
Console.WriteLine("复习17：待完成");
}

/// <summary>
/// 复习18（综合第 3 步：查找与统计）：给 Library 加搜索和分类统计
/// 1. 方法 SearchByCategory(string category)：用 FindAll 找出该类别所有书并逐个 Introduce()，
/// 一本都没有时输出“该类别暂无图书”
/// 2. 方法 CountByCategory()：用 Dictionary&lt;string, int&gt; 统计每个类别各有几种书
/// （数的是种类数，不是库存总数，想清楚再写），遍历字典输出
/// 3. 在本练习里建至少 4 本书（至少 2 个类别）测试两个方法
/// 提示1：FindAll 的 Lambda：b => b.Category == category
/// 提示2：统计的套路和复习12 一模一样：遍历书单，字典里有这个类别就 +1，没有就记 1
/// 提示3：注意区分“几种书”和“共有几本”：这题数 List 里有几条记录，别把 Stock 加进去
/// </summary>
public static void Review18_LibrarySearchStats()
{
// TODO: 在这里写你的实现，写完删掉下面这行占位
Console.WriteLine("复习18：待完成");
}

/// <summary>
/// 复习19（综合第 4 步：完整系统）：图书馆借阅系统菜单版
/// 把 16-18 的 Library 组装成一个能用的控制台程序：
/// 1. 启动时预置 4 本书（至少 2 个类别，其中一本库存只有 1）
/// 2. 菜单循环（while + switch）：1 查看所有书、2 借书、3 还书、4 按类别搜索、5 分类统计、0 退出
/// 3. 借/还时让用户输入书名；所有借还操作包在 try-catch 里，
/// 抓到异常只输出异常信息、不许程序崩溃，菜单继续循环
/// 4. 输入非数字菜单时不能崩（复习14 的 TryParse 思路用在这里）
/// 这题就是第3周练习19 成绩系统 V3 的同题型毕业题：模型 + 集合 + 字典 + 异常 + 菜单，五样齐全才算过。
/// 提示1：拆开做：先把菜单壳子和 switch 分支写出来，每个分支只调 Library 现成的方法，不要把逻辑写进菜单里
/// 提示2：try-catch 包在每个分支内部，不要包住整个 while，不然抓一次异常就退出循环了
/// 提示3：做完自测四条线：正常借还一轮、借不存在的书、把库存 1 的书连借两次、乱输一个字母当菜单
/// </summary>
public static void Review19_LibrarySystem()
{
// TODO: 在这里写你的实现，写完删掉下面这行占位
Console.WriteLine("复习19：待完成");
}

#endregion
}
}
