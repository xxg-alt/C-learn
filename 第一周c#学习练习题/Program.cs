using HelloDotNetGuide.CSharp语法;
using HelloDotNetGuide.常见算法;
using HelloDotNetGuide.异步多线程编程;
using HelloDotNetGuide.数组相关;
using HelloDotNetGuide.正则表达式;
using static HelloDotNetGuide.设计模式.单例模式;

namespace HelloDotNetGuide
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("欢迎来到DotNetGuide练习空间！！！");

            #region Phase1Exercises（第一阶段练习题）

            //Phase1Exercises.Exercise01_DeclareVariables();
            //Phase1Exercises.Exercise02_TypeConversion();
            //Phase1Exercises.Exercise03_NullableAndVar();
            //Phase1Exercises.Exercise04_ArithmeticOperators();
            //Phase1Exercises.Exercise05_IncrementAndCompound();
            //Phase1Exercises.Exercise06_LeapYear();
            //Phase1Exercises.Exercise07_TernaryOperator(7);
            //Phase1Exercises.Exercise08_ScoreLevel(85);
            //Phase1Exercises.Exercise09_DayOfWeek();
            //Phase1Exercises.Exercise10_ForLoop();
            //Phase1Exercises.Exercise11_GuessNumber();
            //Phase1Exercises.Exercise12_MethodDefinition();
            Phase1Exercises.Exercise13_MethodOverload();
            //Phase1Exercises.Exercise14_RefAndOut();
            //Phase1Exercises.Exercise15_ParamsAndRecursion();
            //Phase1Exercises.Exercise16_OneDimensionalArray();
            //Phase1Exercises.Exercise17_TwoDimensionalArray();
            //Phase1Exercises.Exercise18_StringOperations();
            //Phase1Exercises.Exercise19_Palindrome("A man a plan a canal Panama");

            // 参考答案调用示例：
            //Phase1ExerciseAnswers.Exercise11_GuessNumber();
            //Phase1ExerciseAnswers.Exercise19_Palindrome("A man a plan a canal Panama");

            #endregion

            #region ExtensionMethodExercise

            //ExtensionMethodExercise.CheckEmail();

            #endregion

            #region ParallelExample

            //ParallelExample.ParallelForExample();
            //ParallelExample.ParallelForEachExample();
            //ParallelExample.ParallelForCounterexample();

            #endregion

            #region ConstAndReadonlyExercise

            //ConstAndReadonlyExercise.UpdateApplicationNameValue();

            #endregion

            #region CSharp13GrammarExercise

            //CSharp13GrammarExercise.SpanDataPrintRun();

            //CSharp13GrammarExercise.NewEscapeSequence();

            #endregion

            #region DictionaryExercise

            //DictionaryExercise.DictionaryOperation();

            #endregion

            #region YieldExercise

            //YieldExercise.IteratorComparisonRun();

            //YieldExercise.LazyLoadingRun();

            //YieldExercise.YieldBreakRun();

            #endregion

            #region 正则表达式

            //RegularExpressions.SplitString();

            #endregion

            #region LinqExercise

            //LinqExercise.CountByExample();
            //LinqExercise.AggregateByExample();
            //LinqExercise.IndexExample();
            //LinqExercise.CommonMethodsInLINQ();
            //LinqExercise.ToDictionaryExamples();
            //LinqExercise.ToLookupExamples();
            //LinqExercise.SelectManyAndSelectExamples();
            //LinqExercise.StringProcessingExample();
            //LinqExercise.CartesianProductExample();

            #endregion

            #region 设计模式

            //SingletonEager.Instance.DoSomething();

            //SingletonLazy.Instance.DoSomething();

            //SingletonByLazy.Instance.DoSomething();

            #endregion

            #region CSharp12GrammarExercise

            //CSharp12GrammarExercise.OutputPrint();

            #endregion

            #region GotoExercise

            //GotoExercise.GotoRetryUseExample();
            //GotoExercise.NonGotoRetryUseExample();

            #endregion

            #region 异步多线程编程

            //var getFileContent = ReadFileAsyncExample.ReadFileAsync("D:\\Desktop\\数据读取.txt").ConfigureAwait(false);

            //MultithreadingExample.ParallelMethod();

            //AsyncProgrammingExample.TestEAPAsync();

            #endregion

            #region 常见算法

            //线性查找算法.LinearSearchRun();
            //哈希查找算法.HashSearchFunctionRun(2);
            //二分查找算法.BinarySearchRun();
            //二叉搜索树算法.BinarySearchTreeRun();
            //递归算法.RecursiveFactorial();
            //递归算法.RecursiveArraySum();
            //递归算法.FibonacciSum();
            //递归算法.RecursiveAlgorithmSum();
            //基数排序算法.RadixSortRun();
            //桶排序算法.BucketSortRun();
            //计数排序算法.CountingSortRun();
            //堆排序算法.HeapSortRun();
            //归并排序算法.MergeSortRun();
            //希尔排序算法.ShellSortRun();
            //插入排序算法.InsertionSortRun();
            //快速排序算法.QuickSortRun();
            //冒泡排序算法.RecursiveBubbleSortRun();
            //List集合相关算法.GetAfterRemoveListData();
            //选择排序算法.SelectionSortAlgorithmMain();

            #endregion

            #region 数组相关

            //ArrayDeduplication.LoopTraversalDuplicate();

            #endregion
        }
    }
}