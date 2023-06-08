using System;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect1 = new Rectangle(5, 5);
            Console.WriteLine(rect1.Lenght);
            Rectangle rect2;
            rect2.Lenght = 5;
            rect2.Width = 5;

        }
        struct Rectangle
        {
            public double Lenght;
            public double Width;
            public Rectangle(double Lenght, double Width) { 
               this.Lenght = Lenght;
               this.Width = Width;
            }
        }
    }
}