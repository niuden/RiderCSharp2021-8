namespace RiderCSharp2021
{
    public class TestStatements
    {
        //
            //TestCreateClass tcs = new TestCreateClass();
            //tcs.printnumber();

            //12-1
            //Rectangle r = new Rectangle();
            //r.length = 4.5;
            //r.width = 3.5;
            //r.Display();
            //Console.ReadLine();

            //12-2
            //Rectangle2 r = new Rectangle2();
            //r.Acceptdetails();
            //r.Display();
            //Console.ReadLine();


            //12-3
            //Rectangle3 r = new Rectangle3();
            //r.length = 4.5;
            //r.width = 3.5;
            //r.Display();
            //Console.ReadLine();

            //13-2
            /* 局部变量定义 */
            //int a = 100;
            //int b = 200;
            //int ret;
            ////NumberManipulator n = new NumberManipulator();
            //CSharpStudy.NumberManipulator2 n = new CSharpStudy.NumberManipulator2();
            ////调用 FindMax 方法
            //ret = n.FindMax(a, b);
            //Console.WriteLine("最大值是： {0}", ret);

            //13-3
            //NumberManipulator3 n = new NumberManipulator3();
            ////调用 factorial 方法
            //Console.WriteLine("6 的阶乘是： {0}", n.factorial(6));
            //Console.WriteLine("7 的阶乘是： {0}", n.factorial(7));
            //Console.WriteLine("8 的阶乘是： {0}", n.factorial(8));

            //13-4
            //NumberManipulator4 n = new NumberManipulator4();
            ///* 局部变量定义 */
            //int a = 100;
            //int b = 200;

            //Console.WriteLine("在交换之前，a 的值： {0}", a);
            //Console.WriteLine("在交换之前，b 的值： {0}", b);

            ///* 调用函数来交换值 */
            //n.swap(a, b);

            //Console.WriteLine("在交换之后，a 的值： {0}", a);
            //Console.WriteLine("在交换之后，b 的值： {0}", b);

            //13-5
            //NumberManipulator5 n = new NumberManipulator5();
            ///* 局部变量定义 */
            //int a = 100;
            //int b = 200;

            //Console.WriteLine("在交换之前，a 的值： {0}", a);
            //Console.WriteLine("在交换之前，b 的值： {0}", b);

            ///* 调用函数来交换值 */
            //n.swap(ref a, ref b);

            //Console.WriteLine("在交换之后，a 的值： {0}", a);
            //Console.WriteLine("在交换之后，b 的值： {0}", b);

            //13-6
            //NumberManipulator6 n = new NumberManipulator6();
            ///* 局部变量定义 */
            //int a = 100;

            //Console.WriteLine("在方法调用之前，a 的值： {0}", a);

            ///* 调用函数来获取值 */
            //n.getValue(out a);

            //Console.WriteLine("在方法调用之后，a 的值： {0}", a);

            //14-1
            //int? num1 = null;
            //int? num2 = 45;
            //double? num3 = new double?();
            //double? num4 = 3.14157;

            //bool? boolval = new bool?();

            //// 显示值

            //Console.WriteLine("显示可空类型的值： {0}, {1}, {2}, {3}",
            //                   num1, num2, num3, num4);
            //Console.WriteLine("一个可空的布尔值： {0}", boolval);
            //Console.ReadLine();

            //14-2
            //double? num1 = null;
            //double? num2 = 3.14157;
            //double num3;
            //num3 = num1 ?? 5.34;      // num1 如果为空值则返回 5.34
            //Console.WriteLine("num3 的值： {0}", num3);
            //num3 = num2 ?? 5.34;
            //Console.WriteLine("num3 的值： {0}", num3);
            //Console.ReadLine();

            //15-1
            //int[] n = new int[10]; /* n 是一个带有 10 个整数的数组 */
            //int i, j;
            ///* 初始化数组 n 中的元素 */
            //for (i = 0; i < 10; i++)
            //{
            //    n[i] = i + 100;
            //}
            ///* 输出每个数组元素的值 */
            //for (j = 0; j < 10; j++)
            //{
            //    Console.WriteLine("Element[{0}] = {1}", j, n[j]);
            //}


            //15-2
            //MyArray2.show();

            //16-1
            //StringApplication sa = new StringApplication();
            //sa.show();

            //16-2
            //StringProg sp = new StringProg();
            //sp.show();

            //16-3
            //C17_Struct1Define cs = new C17_Struct1Define();
            //cs.show();

            //17-2
            //testStructure ts = new testStructure();
            //ts.show();

            //18-1
            //C18_Enum ce = new C18_Enum();
            //ce.show();

            //18-2
            //C18_Enum2Accumulate cea = new C18_Enum2Accumulate();
            //cea.show();

            //19-1
            //C19_Class1Value ccv = new C19_Class1Value();
            //ccv.show();

            //19-2
            //C19_Class2Package ctp = new C19_Class2Package();
            //ctp.show();

            //19-3
            //C19_Class3Constructor c3c = new C19_Class3Constructor();
            //c3c.show();

            //19-4
            //C19_Class4Destructor c4d = new C19_Class4Destructor();
            //c4d.show();

            //19-5-1
            //C19_Class5Static1 c5s = new C19_Class5Static1();
            //c5s.show();

            //19-5-2   测试某命名空间的类内静态变量
            //Console.WriteLine(TestStatic.StaticVar2.num);
    }
}