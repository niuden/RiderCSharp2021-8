using System;
using System.Collections;
namespace RiderCSharp2021
{
    //这是基类，
//也称为父类。
    public class Fruit 
    {
        public string color;

        //这是 Fruit 类的第一个构造函数，
        //不会被任何派生类继承。
        public Fruit()
        {
            color = "orange";
            Console.WriteLine("1st Fruit Constructor Called");
        }

        //这是 Fruit 类的第二个构造函数，
        //不会被任何派生类继承。
        public Fruit(string newColor)
        {
            color = newColor;
            Console.WriteLine("2nd Fruit Constructor Called");
        }

        public void Chop()
        {
            Console.WriteLine("The " + color + " fruit has been chopped.");        
        }

        public void SayHello()
        {
            Console.WriteLine("Hello, I am a fruit.");
        }
    }
    //这是派生类，
//也称为子类。
    public class Apple : Fruit 
    {
        //这是 Apple 类的第一个构造函数。
        //它立即调用父构造函数，甚至
        //在它运行之前调用。
        public Apple()
        {
            //注意 Apple 如何访问公共变量 color，
            //该变量是父 Fruit 类的一部分。
            color = "red";
            Console.WriteLine("1st Apple Constructor Called");
        }

        //这是 Apple 类的第二个构造函数。
        //它使用“base”关键字指定
        //要调用哪个父构造函数。
        public Apple(string newColor) : base(newColor)
        {
            //请注意，该构造函数不会设置 color，
            //因为基构造函数会设置作为参数
            //传递的 color。
            Console.WriteLine("2nd Apple Constructor Called");
        }
    }
    public class C20_Heritage4Polymorphism
    {
        public void show()
        {
            //让我们用默认构造函数
            //来说明继承。
            Console.WriteLine("Creating the fruit");
            Fruit myFruit = new Fruit();
            Console.WriteLine("Creating the apple");
            Apple myApple = new Apple();

            //调用 Fruit 类的方法。
            myFruit.SayHello();
            myFruit.Chop();
            Console.WriteLine("*****************************");
            
            //调用 Apple 类的方法。
            //注意 Apple 类如何访问
            //Fruit 类的所有公共方法。
            myApple.SayHello();
            myApple.Chop();
            Console.WriteLine("*****************************");
            
            //现在，让我们用读取字符串的
            //构造函数来说明继承。
            Console.WriteLine("Creating the fruit");
            myFruit = new Fruit("yellow");
            Console.WriteLine("Creating the apple");
            myApple = new Apple("green");
            Console.WriteLine("*****************************");
            
            //调用 Fruit 类的方法。
            myFruit.SayHello();
            myFruit.Chop();
            Console.WriteLine("*****************************");
            
            //调用 Apple 类的方法。
            //注意 Apple 类如何访问
            //Fruit 类的所有公共方法。
            myApple.SayHello();
            myApple.Chop();
            Console.WriteLine("*****************************");
            // 测试结果
            
        }
    }
}

/*
Creating the fruit
1st Fruit Constructor Called
Creating the apple
1st Fruit Constructor Called
1st Apple Constructor Called
Hello, I am a fruit.
The orange fruit has been chopped.
*****************************
Hello, I am a fruit.
The red fruit has been chopped.
*****************************
Creating the fruit
2nd Fruit Constructor Called
Creating the apple
2nd Fruit Constructor Called
2nd Apple Constructor Called
*****************************
Hello, I am a fruit.
The yellow fruit has been chopped.
*****************************
Hello, I am a fruit.
The green fruit has been chopped.
*****************************
 */