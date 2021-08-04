using System;
namespace RiderCSharp2021
{
    class Box2o
    {
       private double length;      // 长度
       private double breadth;     // 宽度
       private double height;      // 高度
     
       public double getVolume()
       {
         return length * breadth * height;
       }
      public void setLength( double len )
      {
          length = len;
      }

      public void setBreadth( double bre )
      {
          breadth = bre;
      }

      public void setHeight( double hei )
      {
          height = hei;
      }
      // 重载 + 运算符来把两个 Box 对象相加
      public static Box2o operator+ (Box2o b, Box2o c)
      {
          Box2o box = new Box2o();
          box.length = b.length + c.length;
          box.breadth = b.breadth + c.breadth;
          box.height = b.height + c.height;
          return box;
      }
     
      public static bool operator == (Box2o lhs, Box2o rhs)
      {
          bool status = false;
          if (lhs.length == rhs.length && lhs.height == rhs.height
             && lhs.breadth == rhs.breadth)
          {
              status = true;
          }
          return status;
      }
      public static bool operator !=(Box2o lhs, Box2o rhs)
      {
          bool status = false;
          if (lhs.length != rhs.length || lhs.height != rhs.height
              || lhs.breadth != rhs.breadth)
          {
              status = true;
          }
          return status;
      }
      public static bool operator <(Box2o lhs, Box2o rhs)
      {
          bool status = false;
          if (lhs.length < rhs.length && lhs.height
              < rhs.height && lhs.breadth < rhs.breadth)
          {
              status = true;
          }
          return status;
      }

      public static bool operator >(Box2o lhs, Box2o rhs)
      {
          bool status = false;
          if (lhs.length > rhs.length && lhs.height
              > rhs.height && lhs.breadth > rhs.breadth)
          {
              status = true;
          }
          return status;
      }

      public static bool operator <=(Box2o lhs, Box2o rhs)
      {
          bool status = false;
          if (lhs.length <= rhs.length && lhs.height
              <= rhs.height && lhs.breadth <= rhs.breadth)
          {
              status = true;
          }
          return status;
      }

      public static bool operator >=(Box2o lhs, Box2o rhs)
      {
          bool status = false;
          if (lhs.length >= rhs.length && lhs.height
             >= rhs.height && lhs.breadth >= rhs.breadth)
          {
              status = true;
          }
          return status;
      }
      public override string ToString()
      {
          return String.Format("({0}, {1}, {2})", length, breadth, height);
      }
   
   }
    
    public class C22_Overload2More
    {
        public void show()
        {
            Box2o Box1 = new Box2o();          // 声明 Box1，类型为 Box
                    Box2o Box2 = new Box2o();          // 声明 Box2，类型为 Box
                    Box2o Box3 = new Box2o();          // 声明 Box3，类型为 Box
                    Box2o Box4 = new Box2o();
                    double volume = 0.0;   // 体积
            
                    // Box1 详述
                    Box1.setLength(6.0);
                    Box1.setBreadth(7.0);
                    Box1.setHeight(5.0);
            
                    // Box2 详述
                    Box2.setLength(12.0);
                    Box2.setBreadth(13.0);
                    Box2.setHeight(10.0);
            
                    // 使用重载的 ToString() 显示两个盒子
                    Console.WriteLine("Box1： {0}", Box1.ToString());
                    Console.WriteLine("Box2： {0}", Box2.ToString());
                   
                    // Box1 的体积
                    volume = Box1.getVolume();
                    Console.WriteLine("Box1 的体积： {0}", volume);
            
                    // Box2 的体积
                    volume = Box2.getVolume();
                    Console.WriteLine("Box2 的体积： {0}", volume);
            
                    // 把两个对象相加
                    Box3 = Box1 + Box2;
                    Console.WriteLine("Box3： {0}", Box3.ToString());
                    // Box3 的体积
                    volume = Box3.getVolume();
                    Console.WriteLine("Box3 的体积： {0}", volume);
            
                    //comparing the boxes
                    if (Box1 > Box2)
                    Console.WriteLine("Box1 大于 Box2");
                    else
                    Console.WriteLine("Box1 不大于 Box2");
                    if (Box1 < Box2)
                        Console.WriteLine("Box1 小于 Box2");
                        else
                    Console.WriteLine("Box1 不小于 Box2");
                    if (Box1 >= Box2)
                    Console.WriteLine("Box1 大于等于 Box2");
                    else
                    Console.WriteLine("Box1 不大于等于 Box2");
                    if (Box1 <= Box2)
                    Console.WriteLine("Box1 小于等于 Box2");
                    else
                    Console.WriteLine("Box1 不小于等于 Box2");
                    if (Box1 != Box2)
                    Console.WriteLine("Box1 不等于 Box2");
                    else
                    Console.WriteLine("Box1 等于 Box2");
                    Box4 = Box3;
                    if (Box3 == Box4)
                    Console.WriteLine("Box3 等于 Box4");
                    else
                    Console.WriteLine("Box3 不等于 Box4");
            
                    Console.ReadKey();
        }
    }
}