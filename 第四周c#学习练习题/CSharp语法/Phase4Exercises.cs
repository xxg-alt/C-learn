using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text.Json;

namespace HelloDotNetGuide.CSharp语法
{
/// <summary>
/// 第四阶段练习题：枚举与结构体、接口、委托与事件、LINQ、文件与 JSON 存档
/// 主题一句话：让第三周的成绩管理系统能存档、能通知、能换玩法，并为 Unity 做准备。
///
/// 用法（和前三周一样）：
/// 1. 每个方法里只有任务说明、三级提示和一行“待完成”占位，没有答案。
/// 先看任务自己写；卡住看提示1，还卡看提示2，提示3 是接近骨架的最后一级。
/// 2. 写完把占位那行删掉，换成你的实现；在 Program.cs 里取消对应调用的注释来运行。
/// 3. 本周新定义的类型都写在 Phase4Exercises 类（和第三周同一个规矩，
/// 避免和以后答案文件的同名类型冲突，报 CS0101）。
///
/// 英文拆词（先认词，再写码）：
/// enum = enumerate（列举） interface = 接口（只定规矩的地方）
/// delegate = 委托（把方法交给它保管） event = 事件（事情发生了，通知大家）
/// struct = structure（结构） query = 查询 save = 保存 load = 读取
/// damage = 伤害 able = 能……的（IDamageable = 能被打的）
/// </summary>
public class Phase4Exercises
{
#region 本周共用的类型（先读一遍，后面的练习会反复用到）

/// <summary>
/// 学生状态枚举：不用 0/1/2 这种看不懂的数字，直接用名字。
/// Enrolled = 在读，Suspended = 休学，Graduated = 毕业。
/// </summary>
public enum StudentStatus
{
Enrolled,
Suspended,
Graduated
}

/// <summary>
/// 分数结构体：三科分数打包成一个小数据包。
/// struct 是值类型，赋值时会复制一份（练习3 里要亲手验证这一点）。
/// </summary>
public struct Score
{
public int Chinese;
public int Math;
public int English;

public Score(int chinese, int math, int english)
{
Chinese = chinese;
Math = math;
English = english;
}

public double Average()
{
return (Chinese + Math + English) / 3.0;
}
}

/// <summary>
/// 接口 ISaveable：规矩只有一条——你得能把自己变成一行可保存的文本。
/// ToSaveText：To（去）+ Save（保存）+ Text（文本）。
/// 接口里只写签名，不写实现，实现留给每个类自己。
/// </summary>
public interface ISaveable
{
string ToSaveText();
}

/// <summary>
/// 接口 IDamageable：能被打的。Health = 血量（只读），
/// TakeDamage：Take（承受）+ Damage（伤害），参数是伤害值。
/// 这是 Unity 里非常常见的写法，敌人、箱子、城墙都可以实现它。
/// </summary>
public interface IDamageable
{
int Health { get;}
void TakeDamage(int amount);
}

#endregion

#region 一、枚举与结构体

/// <summary>
/// 练习1：枚举基础
/// 1. 定义一个 StudentStatus 类型的变量，值设为 Enrolled
/// 2. 输出这个变量，再把它转成 int 输出（看看它背后的数字是几）
/// 3. 把变量改成 Graduated，再输出一次
/// 提示1：枚举取值用点：StudentStatus.Enrolled —— 点 = “它身上的”
/// 提示2：转数字要强制转换：(int)变量名
/// 提示3：StudentStatus s = StudentStatus.Enrolled; Console.WriteLine(s); Console.WriteLine((int)s);
/// </summary>
public static void Exercise01_EnumBasics()
{
// TODO: 在这里写你的实现，写完删掉下面这行占位
Console.WriteLine("练习01：待完成");
}

/// <summary>
/// 练习2：用枚举改成绩系统
/// 1. 新建一个小类 StudentStatusDemo（写在本类内部），包含 Name 属性和 Status 属性（类型 StudentStatus）
/// 2. 创建 3 个学生，状态分别是在读、休学、毕业
/// 3. 遍历输出：姓名 + 状态；想一想：如果用 0/1/2 存状态，读代码的人要多付什么代价？（写一行注释）
/// 提示1：属性写法回顾第二周：public StudentStatus Status { get; set;}
/// 提示2：对象初始化器：new StudentStatusDemo { Name = "小明", Status = StudentStatus.Enrolled}
/// 提示3：先把小类写出来，再在方法里建 List&lt;StudentStatusDemo&gt; 遍历输出
/// </summary>
public static void Exercise02_EnumInGradeSystem()
{
// TODO: 在这里写你的实现，写完删掉下面这行占位
Console.WriteLine("练习02：待完成");
}

/// <summary>
/// 练习3：结构体 Score
/// 1. 创建一个 Score，语文 90、数学 95、英语 84，输出它的 Average()
/// 2. 把它赋给另一个变量，改新变量的 Math 为 60，再输出的 Math
/// 3. 用一行注释写下你看到的现象：原变量被影响了吗？这就是 struct 和 class 最大的区别
/// 提示1：Score s1 = new Score(90, 95, 84);
/// 提示2：Score s2 = s1; 之后改 s2.Math，struct 会复制一份，s1 不变
/// 提示3：如果这里换成 class（引用类型），s1 会跟着变——第二周练习16 复习过
/// </summary>
public static void Exercise03_StructScore()
{
// TODO: 在这里写你的实现，写完删掉下面这行占位
Console.WriteLine("练习03：待完成");
}

/// <summary>
/// 练习4：枚举 + switch
/// 1. 写一个方法 string DescribeStatus(StudentStatus s)，用 switch 按状态返回中文说明：
/// Enrolled → "在读，好好上课"；Suspended → "休学中"；Graduated → "已毕业"
/// 2. 在本练习里对三个状态各调用一次并输出
/// 提示1：switch 表达式写法：s switch { StudentStatus.Enrolled => "...",...}
/// 提示2：最后一个分支用 _ 表示“其他所有情况”，避免漏掉
/// 提示3：Unity 里按游戏状态（菜单/游戏中/暂停/结束）切换逻辑，用的就是这一套
/// </summary>
public static void Exercise04_EnumSwitch()
{
// TODO: 在这里写你的实现，写完删掉下面这行占位
Console.WriteLine("练习04：待完成");
}

#endregion

#region 二、接口

/// <summary>
/// 练习5：第一个接口实现
/// 1. 新建小类 SaveableStudent（写在本类内部），包含 Name 和 Score 两个属性，并实现 ISaveable
/// 2. ToSaveText() 返回一行文本，格式自定，例如："小明,90"
/// 3. 创建对象，用 ISaveable 类型的变量装它，调用 ToSaveText() 输出
/// 提示1：实现接口的写法：class SaveableStudent: ISaveable —— 冒号 = “遵守这份规矩”
/// 提示2：类里必须把接口的方法原样写出来，不然编译不过（这正是接口的用处：逼你实现）
/// 提示3：ISaveable thing = new SaveableStudent {...}; Console.WriteLine(thing.ToSaveText());
/// </summary>
public static void Exercise05_InterfaceBasics()
{
// TODO: 在这里写你的实现，写完删掉下面这行占位
Console.WriteLine("练习05：待完成");
}

/// <summary>
/// 练习6：两个类，同一个接口
/// 1. 再新建小类 SaveableContact（通讯录联系人：姓名 + 电话），也实现 ISaveable
/// 2. 建一个 List&lt;ISaveable&gt;，把练习5 的学生和这里的联系人一起装进去
/// 3. 遍历列表，逐个调用 ToSaveText() 输出——体会：装的东西不同，调用方式完全一样
/// 提示1：List 的元素类型写接口名，就能装所有实现它的类
/// 提示2：遍历时不用管它到底是学生还是联系人，只管调 ToSaveText()
/// 提示3：这就是“多态”的另一种长相：第二周是靠继承，这里是靠接口
/// </summary>
public static void Exercise06_TwoClassesOneInterface()
{
// TODO: 在这里写你的实现，写完删掉下面这行占位
Console.WriteLine("练习06：待完成");
}

/// <summary>
/// 练习7：接口当参数
/// 1. 写一个静态方法 PrintSaveText(ISaveable item)，作用是把 item 的 ToSaveText() 输出出来
/// 2. 分别传入一个学生、一个联系人调用它
/// 3. 用一行注释回答：这个方法需要知道传进来的是学生还是联系人吗？为什么？
/// 提示1：方法参数类型写接口名，什么实现类都能传
/// 提示2：方法内部只调用接口里有的方法，别去访问类自己的属性
/// 提示3：Unity 里“交互系统”就是这么干的：只认“可交互”接口，不管你是门还是宝箱
/// </summary>
public static void Exercise07_InterfaceAsParameter()
{
// TODO: 在这里写你的实现，写完删掉下面这行占位
Console.WriteLine("练习07：待完成");
}

/// <summary>
/// 练习8：IDamageable（Unity 原味练习）
/// 1. 新建小类 TrainingDummy（训练假人）实现 IDamageable：血量 100，
/// TakeDamage(amount) 让血量减 amount，并输出剩余血量；血量小于等于 0 时输出“假人倒下了”
/// 2. 再新建小类 WoodenBox（木箱）也实现 IDamageable：血量 30，倒下时输出“箱子碎了”
/// 3. 建 List&lt;IDamageable&gt; 装一个假人一个箱子，统一对每个调用 TakeDamage(20) 两次
/// 提示1：Health 属性要能被类内部改、外部只读：public int Health { get; private set;}
/// 提示2：TakeDamage 里先扣血，再判断 Health &lt;= 0
/// 提示3：攻击方只认接口——以后在 Unity 里，子弹不需要知道打中的是敌人还是箱子
/// </summary>
public static void Exercise08_DamageableUnityStyle()
{
// TODO: 在这里写你的实现，写完删掉下面这行占位
Console.WriteLine("练习08：待完成");
}

#endregion

#region 三、委托与事件

/// <summary>
/// 练习9：委托基础
/// 1. 在本类内部定义委托：public delegate void Notify(string message);
/// delegate = 委托，它是一种“能装方法的类型”
/// 2. 写两个普通方法：PrintToConsole(string) 输出到控制台；PrintWithStars(string) 输出时前后加 ★
/// 3. 用 Notify 变量分别装这两个方法并调用，观察：同一个变量，装谁就执行谁
/// 提示1：Notify n = PrintToConsole; n("你好"); —— 装方法时不加括号，加括号就变成调用了
/// 提示2：两个被装的方法，参数和返回值必须和委托定义一模一样
/// 提示3：把委托想成“遥控器”：遥控器本身不干活，按下去执行的是被它指向的那个方法
/// </summary>
public static void Exercise09_DelegateBasics()
{
// TODO: 在这里写你的实现，写完删掉下面这行占位
Console.WriteLine("练习09：待完成");
}

/// <summary>
/// 练习10：Action 与 Func（不用自己定义委托）
/// 1. 用 Action&lt;string&gt; 装一个 Lambda：收到文本就输出“通知：”+ 文本，调用一次
/// Action = 系统自带委托，没有返回值
/// 2. 用 Func&lt;int, int, int&gt; 装一个 Lambda：两个 int 相加返回结果，调用并输出
/// Func = 系统自带委托，有返回值；尖括号里最后一个是返回值类型，前面的是参数
/// 3. 用一行注释总结：Action 和 Func 的区别是什么？
/// 提示1：Action&lt;string&gt; a = msg => Console.WriteLine("通知：" + msg);
/// 提示2：Func&lt;int, int, int&gt; add = (x, y) => x + y;
/// 提示3：第3周 Find 里用的 x => x > 10，本质就是被装进委托的 Lambda
/// </summary>
public static void Exercise10_ActionFunc()
{
// TODO: 在这里写你的实现，写完删掉下面这行占位
Console.WriteLine("练习10：待完成");
}

/// <summary>
/// 练习11：事件基础
/// 1. 新建小类 ScoreBoard（记分牌，写在本类内部）：属性 Score（private set），
/// 事件 public event Action&lt;int&gt;? ScoreChanged; 方法 AddScore(int points)：
/// 先加分，再用 ScoreChanged?.Invoke(Score) 把新分数通知出去
/// event = 事件，只能在类的内部触发，外部只能订阅（+=）和取消订阅（-=）
/// 2. 在本练习里创建记分牌，订阅事件：分数一变就输出“分数变了，现在是 X”
/// 3. 调用 AddScore 两次，观察输出
/// 提示1：订阅写法：board.ScoreChanged += newScore => Console.WriteLine(...);
/// 提示2：?. 的意思是“有人订阅才通知，没人订阅就跳过”，不写会在没人订阅时报错
/// 提示3：Unity 里最像这套的是按钮 onClick（用的 UnityEvent，同样是 += 挂方法、发生时通知）；碰撞回调 OnCollisionEnter 不一样，它是 Unity 按约定直接调用的方法，不是 C# 事件，别混。C# 事件在 Unity 里最常见的用处，就是这一题这种“分数/血量变了 → 通知 UI 更新”
/// </summary>
public static void Exercise11_EventBasics()
{
// TODO: 在这里写你的实现，写完删掉下面这行占位
Console.WriteLine("练习11：待完成");
}

/// <summary>
/// 练习12：事件实战——成绩变化通知
/// 1. 给练习11 的思路换个场景：小类 StudentScore，包含 Name、Score（private set）和
/// 事件 ScoreChanged（通知内容：姓名 + 旧分数 + 新分数，想想参数要几个）
/// 2. 方法 ChangeScore(int newScore)：改分并触发事件
/// 3. 订阅两个“听众”：一个输出提醒，一个在新分数低于 60 时输出“警告：不及格”
/// 一次改分，两个听众都收到——这就是事件的价值：改分的人不用知道谁在关心分数
/// 提示1：事件参数可以多带几个：Action&lt;string, int, int&gt; 表示（姓名， 旧， 新）
/// 提示2：订阅两次 += 就会有两个听众，触发一次两个都执行
/// 提示3：以后在 Unity 里“血量变了 → 血条 UI 自动更新”，就是这一题的放大版
/// </summary>
public static void Exercise12_EventGradeNotify()
{
// TODO: 在这里写你的实现，写完删掉下面这行占位
Console.WriteLine("练习12：待完成");
}

#endregion

#region 四、LINQ 查询

/// <summary>
/// 练习13：Where 筛选
/// 给定 List&lt;int&gt; scores = { 88, 45, 92, 60, 73, 59, 100}（自己在方法里建）
/// 1. 用 Where 挑出所有大于等于 60 的分数，遍历输出
/// 2. 用 Where 挑出所有不及格的，输出个数（Count）
/// 3. 对比第3周的手写循环版，用一行注释写：LINQ 版少写了什么？
/// 提示1：开头要 using System.Linq;（本文件已经写好了）
/// 提示2：var passed = scores.Where(x => x >= 60);
/// 提示3：Where 返回的不是 List，要马上遍历就直接 foreach；要装起来用.ToList()
/// </summary>
public static void Exercise13_LinqWhere()
{
// TODO: 在这里写你的实现，写完删掉下面这行占位
Console.WriteLine("练习13：待完成");
}

/// <summary>
/// 练习14：OrderBy + Select 做排行榜
/// 1. 复用第3周的思路，建一个 List，装 4 个学生（姓名 + 总分），类型自己定义或复用前面的小类
/// 2. 用 OrderByDescending 按总分从高到低排，输出名次、姓名、总分
/// OrderByDescending：Order（排序）+ Descending（从大到小）
/// 3. 用 Select 只挑出所有姓名，组成一个新列表输出
/// Select = 从每个对象身上“挑一个字段出来”
/// 提示1：var rank = students.OrderByDescending(s => s.Total);
/// 提示2：名次用一个计数变量，在 foreach 里逐个 +1
/// 提示3：var names = students.Select(s => s.Name).ToList();
/// </summary>
public static void Exercise14_LinqOrderSelect()
{
// TODO: 在这里写你的实现，写完删掉下面这行占位
Console.WriteLine("练习14：待完成");
}

/// <summary>
/// 练习15：LINQ 统计一行搞定
/// 给定一个学生列表（可复用练习14 的数据）：
/// 1. Average 求平均分；Max 求最高分；Min 求最低分，各输出一行
/// 2. Any 判断“有没有满分的人”，输出 true/false
/// 3. FirstOrDefault 找第一个不及格的人：找到输出姓名，没找到输出“全员及格”
/// FirstOrDefault：First（第一个）+ OrDefault（没有就给默认值 null），不会像 First 那样报错
/// 提示1：students.Average(s => s.Total) —— 统计时要告诉它按哪个字段算
/// 提示2：students.Any(s => s.Total == 100)
/// 提示3：找出来的可能是 null，用之前先判断，这是第3周异常处理之外更温和的办法
/// </summary>
public static void Exercise15_LinqStats()
{
// TODO: 在这里写你的实现，写完删掉下面这行占位
Console.WriteLine("练习15：待完成");
}

/// <summary>
/// 练习16：Lambda 到底是什么
/// 1. 写一个普通方法 bool IsPass(int score) { return score >= 60;}
/// 2. 再写一个 Lambda 版本：Func&lt;int, bool&gt; isPass = x => x >= 60;
/// 3. 两个版本各测 3 个分数，输出结果应当完全一样
/// 4. 用 List 的 FindAll 分别配合和各筛一次不及格名单
/// 提示1：FindAll 的参数位置既能放方法名（不加括号），也能放 Lambda
/// 提示2：看清楚：这里的 Lambda 是“匿名函数表达式”——在 Func、FindAll 这类场景里，它会被转换成委托，可以当作一段没单独起名的小行为来用
/// 提示3：这一题通了，前三周所有 x =>... 就都通了
/// </summary>
public static void Exercise16_LambdaDeepDive()
{
// TODO: 在这里写你的实现，写完删掉下面这行占位
Console.WriteLine("练习16：待完成");
}

#endregion

#region 五、综合挑战：文件与存档

/// <summary>
/// 练习17：文件保存（纯文本）
/// 1. 建 3 个练习5 的 SaveableStudent，用 ToSaveText() 把每人变成一行文本
/// 2. 用 File.WriteAllLines("students.txt", lines) 存进文件
/// File = 文件，WriteAllLines = 把一串文本按行全部写进去
/// 3. 再用 File.ReadAllLines 读回来逐行输出，并输出文件完整路径，方便你去文件夹里亲眼找到它
/// 提示1：lines 可以用 List&lt;string&gt;，也可以用 LINQ 的 Select 一行生成
/// 提示2：文件默认存在程序运行目录（bin/Debug/net9.0 下面），用 Path.GetFullPath("students.txt") 看全路径
/// 提示3：整个练习包在 try-catch 里，文件出问题时输出异常信息（复习第3周）
/// </summary>
public static void Exercise17_FileSave()
{
// TODO: 在这里写你的实现，写完删掉下面这行占位
Console.WriteLine("练习17：待完成");
}

/// <summary>
/// 练习18：JSON 存档
/// 1. 定义一个可被 JSON 序列化的学生类 JsonStudent：Name、Chinese、Math、English 全用属性（不要用字段）
/// 序列化 = 把对象变成文本；JsonSerializer 默认只处理公有属性，字段默认不参与，所以本题统一用属性，这是最常见的坑
/// 2. 建 3 个学生装进 List，用 JsonSerializer.Serialize(list, new JsonSerializerOptions { WriteIndented = true})
/// 变成带缩进的 JSON 文本，输出看看它长什么样
/// 3. 把 JSON 存进 students.json，再读回来用 Deserialize&lt;List&lt;JsonStudent&gt;&gt; 还原成对象，遍历输出
/// 提示1：Serialize = 序列化（对象 → 文本），Deserialize = 反序列化（文本 → 对象）
/// 提示2：读回来的可能是 null，还原后先判空再遍历
/// 提示3：Unity 的 JsonUtility 是同一个原理：对象 ↔ JSON 文本 ↔ 文件，就是一份存档
/// </summary>
public static void Exercise18_JsonSave()
{
// TODO: 在这里写你的实现，写完删掉下面这行占位
Console.WriteLine("练习18：待完成");
}

/// <summary>
/// 练习19：成绩管理系统 V4（第四周毕业题，三周 + 本周总集成）
/// 在第3周 V3 的基础上升级，五个要求缺一不可：
/// 1. 学生类 StudentV4：姓名、三科分数、Status（用练习1 的 StudentStatus 枚举），
/// 并实现 ISaveable；总分和平均分用计算属性
/// 2. 改分走 ChangeScore 方法并触发 ScoreChanged 事件；订阅事件输出“XX 的分数已更新”
/// 3. 排行榜用 LINQ：按平均分 OrderByDescending 输出前 3 名
/// 4. 统计用 LINQ：一行求全班平均的平均、一行判断有没有满分（满分 = 任一单科考到 100 分）
/// 5. 存档：把全班存成 JSON（students_v4.json），然后清空内存里的列表，
/// 再从文件读回来输出，证明“关掉重开数据还在”
/// 菜单做不做随你，V3 的菜单能搬就搬；重点是上面 5 条全部落地。
/// 提示1：拆开做：先写类，再写事件，再在主方法里组装流程，不要一口气全写
/// 提示2：第 2、3、4、5 条分别对应练习12、14、15、18，卡住就回去翻那一题
/// 提示3：做完这一题，你手里就是一个带存档的小系统了——这正是 Unity 存档系统的控制台版
/// </summary>
public static void Exercise19_GradeSystemV4()
{
// TODO: 在这里写你的实现，写完删掉下面这行占位
Console.WriteLine("练习19：待完成");
}

#endregion
}
}
