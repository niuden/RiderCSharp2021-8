using System;
namespace RiderCSharp2021
{
    public class C20_Heriatge3Multiple
    {
        public void show()
        {
            Rectangle3 Rect = new Rectangle3();
            int area;
            Rect.setWidth(5);
            Rect.setHeight(7);
            area = Rect.getArea();
            // 打印对象的面积
            Console.WriteLine("总面积： {0}",  Rect.getArea());
            Console.WriteLine("油漆总成本： ${0}" , Rect.getCost(area));
            Console.ReadKey();
        }
    }
    class Shape3
    {
        public void setWidth(int w)
        {
            width = w;
        }
        public void setHeight(int h)
        {
            height = h;
        }
        protected int width;
        protected int height;
    }

    // 基类 PaintCost
    public interface PaintCost
    {
        int getCost(int area);

    }
    // 派生类
    class Rectangle3 : Shape3, PaintCost
    {
        public int getArea()
        {
            return (width * height);
        }
        public int getCost(int area)
        {
            return area * 70;
        }
    }

}